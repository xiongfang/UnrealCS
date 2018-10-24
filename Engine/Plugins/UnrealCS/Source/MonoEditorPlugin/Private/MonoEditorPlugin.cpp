// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#include "MonoEditorPluginPrivatePCH.h"
#include "IMonoEditorPlugin.h"

#include "MonoTextBuilder.h"
#include "PropertyHandler.h"
#include "DocHelper.h"
#include "LevelEditor.h"

#define LOCTEXT_NAMESPACE "MonoEditor"

DEFINE_LOG_CATEGORY(LogMonoEditor);



/**
* Script blueprint module
*/
class FScriptEditorPlugin : public IMonoEditorPlugin
{
	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;

public:
	TSharedPtr<FExtender> MainMenuExtender;

	//菜单
	void AddMainMenuExtension();
	void RemoveMainMenuExtension();
	void ExtendFileMenu(FMenuBuilder& MenuBuilder);

	void OpenProject();
	void Export();

	//struct ClassInfo
	//{
	//	bool CanExport;
	//	UClass* Class;
	//};
	//TArray<ClassInfo> ClassInfos;


	FString ExportPath;

	//全部类
	TArray<UClass*> NeededExportedClass;
	TArray<UScriptStruct*> NeededExportedStruct;
	TArray<UEnum*> NeededExportedEnums;
	bool CollectExportInfo(UStruct* Struct);
	void CollectExportInfo(UFunction* Function);
	void CollectExportInfo(UProperty* Property);

	PropertyHandlerFactroy Factory;
	bool IsFunctionSupported(UClass* Class, UFunction* Function);
	bool IsStructSupported(UScriptStruct* Struct);
	bool IsClassSupported(UClass* Class);
	bool IsEnumSupported(UEnum* Property);

	FMonoTextBuilder ExportFunction(const FString& ClassNameCPP, UClass* Class, UFunction* Function);
	void ExportEnum(UEnum* e);
	void ExportClass(UClass* c);
	void ExportStruct(UScriptStruct* c);
};

IMPLEMENT_MODULE(FScriptEditorPlugin, MonoEditorPlugin)

void FScriptEditorPlugin::StartupModule()
{
	//only initialize agent and menus if we have a UI
	if (!IsRunningCommandlet())
	{
		AddMainMenuExtension();
	}
}

void FScriptEditorPlugin::ShutdownModule()
{
	if (!IsRunningCommandlet())
	{
		RemoveMainMenuExtension();
	}
}


void FScriptEditorPlugin::AddMainMenuExtension()
{
	// Add menu option for level editor tutorial
	MainMenuExtender = MakeShareable(new FExtender);
	MainMenuExtender->AddMenuExtension("FileProject", EExtensionHook::After, NULL, FMenuExtensionDelegate::CreateRaw(this, &FScriptEditorPlugin::ExtendFileMenu));
	FLevelEditorModule& LevelEditorModule = FModuleManager::LoadModuleChecked<FLevelEditorModule>("LevelEditor");
	LevelEditorModule.GetMenuExtensibilityManager()->AddExtender(MainMenuExtender);
}

void FScriptEditorPlugin::RemoveMainMenuExtension()
{
	if (MainMenuExtender.IsValid() && FModuleManager::Get().IsModuleLoaded("LevelEditor"))
	{
		FLevelEditorModule& LevelEditorModule = FModuleManager::LoadModuleChecked<FLevelEditorModule>("LevelEditor");
		LevelEditorModule.GetMenuExtensibilityManager()->RemoveExtender(MainMenuExtender);
	}
}

void FScriptEditorPlugin::ExtendFileMenu(FMenuBuilder& MenuBuilder)
{
	MenuBuilder.BeginSection("C#", LOCTEXT("UnrealCSLabel", "UnrealCS"));
	{
		MenuBuilder.AddMenuEntry(
			LOCTEXT("MonoPluginMenuEntryTitle", "Open Project"),
			LOCTEXT("MonoPluginMenuEntryToolTip", "Open C# Script Project"),
			FSlateIcon(FEditorStyle::GetStyleSetName(), "LevelEditor.UnrealCS"),
			FUIAction(FExecuteAction::CreateRaw(this, &FScriptEditorPlugin::OpenProject)));
		MenuBuilder.AddMenuEntry(
			LOCTEXT("MonoPluginMenuEntryTitle_exp", "Export C#"),
			LOCTEXT("MonoPluginMenuEntryToolTip_exp", "Export c# class library"),
			FSlateIcon(FEditorStyle::GetStyleSetName(), "LevelEditor.UnrealCS"),
			FUIAction(FExecuteAction::CreateRaw(this, &FScriptEditorPlugin::Export)));
	}
	MenuBuilder.EndSection();
}
void FScriptEditorPlugin::OpenProject()
{
	UE_LOG(LogMonoEditor, Warning, TEXT("OpenProject"));



	//查看数据
	UE_LOG(LogMonoEditor, Error, TEXT("Load Successed"));
}

bool SaveHeaderIfChanged(const FString& HeaderPath, const FString& NewHeaderContents)
{
	FString OriginalHeaderLocal;
	FFileHelper::LoadFileToString(OriginalHeaderLocal, *HeaderPath);

	const bool bHasChanged = OriginalHeaderLocal.Len() == 0 || FCString::Strcmp(*OriginalHeaderLocal, *NewHeaderContents);
	if (bHasChanged)
	{
		if (!FFileHelper::SaveStringToFile(NewHeaderContents, *HeaderPath))
		{
			UE_LOG(LogMonoEditor, Warning, TEXT("Failed to save header export: '%s'"), *HeaderPath);
		}
	}

	return bHasChanged;
}

FString GetClassNameCPP(UStruct* Class)
{
	return FString::Printf(TEXT("%s%s"), Class->GetPrefixCPP(), *Class->GetName());
}

int GetStructSize(UScriptStruct* ScriptStruct)
{
	if (ScriptStruct->GetCppStructOps())
	{
		return ScriptStruct->GetCppStructOps()->GetSize();
	}
	else
	{
		return ScriptStruct->GetStructureSize();
	}
}


bool FScriptEditorPlugin::IsStructSupported(UScriptStruct* Struct)
{
	//if (BlackList.HasStruct(Struct))
	//	return false;

	return true;
}
bool FScriptEditorPlugin::IsClassSupported(UClass* Class)
{
	bool bCanExport = (Class->ClassFlags & (CLASS_RequiredAPI | CLASS_MinimalAPI)) != 0;
	if (!bCanExport)
		return false;

	//if (BlackList.HasClass(Class))
	//	return false;

	return bCanExport;
}
bool FScriptEditorPlugin::IsEnumSupported(UEnum* Enum)
{
	//return !BlackList.HasEnum(Enum);
	return true;
}
bool FScriptEditorPlugin::IsFunctionSupported(UClass* Class, UFunction* Function)
{
	// We don't support delegates and non-public functions
	if ((Function->FunctionFlags & FUNC_Delegate))
	{
		return false;
	}

	// We don't support delegates and non-public functions
	if (!(Function->FunctionFlags & (FUNC_Public))
		|| Function->HasMetaData("DeprecatedFunction")
		|| Function->HasAnyFunctionFlags(FUNC_BlueprintEvent)
		//|| Function->HasAnyFunctionFlags(FUNC_Static)
		//|| Function->GetBoolMetaData("BlueprintInternalUseOnly")
		)
	{
		return false;
	}


	//if (BlackList.HasFunction(Class, Function))
	//	return false;


	for (TFieldIterator<UProperty> ParamIt(Function); ParamIt; ++ParamIt)
	{
		UProperty* Param = *ParamIt;
		if (!Factory.IsPropertySupported(Param))
			return false;
	}

	if (Function->GetOwnerClass() != Class)
	{
		return false;
	}
	return true;
}

void FScriptEditorPlugin::Export()
{
	UE_LOG(LogMonoEditor, Warning, TEXT("Export"));

	DocHelper::InitializeToolTipLocalization();


	NeededExportedClass.Empty();
	NeededExportedEnums.Empty();
	NeededExportedStruct.Empty();


	ExportPath = FPaths::Combine(*FPaths::RootDir(), TEXT("GeneratedScriptFile"));

	//收集需要导出的类
	{
		//导出所有类的属性偏移量
		for (TObjectIterator<UStruct> it; it; ++it)
		{
			UScriptStruct* Struct = Cast<UScriptStruct>(*it);
			UClass* Class = Cast<UClass>(*it);

			if (Class != nullptr)
			{
				if (!NeededExportedClass.Contains(Class) && IsClassSupported(Class))
				{
					//ClassInfo ci;
					//ci.CanExport = CollectExportInfo(Class);
					CollectExportInfo(Class);
					//ci.Class = Class;
					//ClassInfos.Add(ci);
					NeededExportedClass.Add(Class);
				}
			}
			
		}
	}


	FString Path = FPaths::Combine(*FPaths::RootDir(), TEXT("GeneratedScriptFile"));

	//导出类
	{
		for (auto Class : NeededExportedClass)
		{
			ExportClass(Class);
		}
	}

	//导出枚举
	{

		for (auto e : NeededExportedEnums)
		{
			ExportEnum(e);
		}
	}

	//导出结构体
	{

		for (auto e : NeededExportedStruct)
		{
			ExportStruct(e);
		}
	}
}


bool FScriptEditorPlugin::CollectExportInfo(UStruct* Struct)
{
	if (UClass * Class = Cast<UClass>(Struct))
	{
		if (!IsClassSupported(Class) || NeededExportedClass.Contains(Class))
		{
			UE_LOG(LogMonoEditor, Log, TEXT("Skip Class %s"), *Class->GetName())
				return false;
		}
	}
	else if (UScriptStruct * ScriptStruct = Cast<UScriptStruct>(Struct))
	{
		if (!IsStructSupported(ScriptStruct) || NeededExportedStruct.Contains(Struct))
		{
			UE_LOG(LogMonoEditor, Log, TEXT("Skip Struct %s"), *Struct->GetName())
				return false;
		}
		NeededExportedStruct.Add(ScriptStruct);
	}

	for (TFieldIterator<UProperty> PropertyIt(Struct /*, EFieldIteratorFlags::ExcludeSuper*/); PropertyIt; ++PropertyIt)
	{
		UProperty* PropertyChild = *PropertyIt;
		CollectExportInfo(PropertyChild);
	}

	for (TFieldIterator<UFunction> FuncIt(Struct, EFieldIteratorFlags::ExcludeSuper); FuncIt; ++FuncIt)
	{
		UFunction* Function = *FuncIt;
		CollectExportInfo(Function);
	}

	return true;
}
void FScriptEditorPlugin::CollectExportInfo(UFunction* Function)
{
	for (TFieldIterator<UProperty> ParamIt(Function); ParamIt; ++ParamIt)
	{
		UProperty* Param = *ParamIt;
		CollectExportInfo(Param);
	}
}
void FScriptEditorPlugin::CollectExportInfo(UProperty* Property)
{
	//枚举值
	if (Property->IsA(UByteProperty::StaticClass()))
	{
		UByteProperty* ByteProp = Cast<UByteProperty>(Property);
		if (ByteProp->GetIntPropertyEnum() != NULL)
		{
			if (!NeededExportedEnums.Contains(ByteProp->GetIntPropertyEnum()))
				NeededExportedEnums.Add(ByteProp->GetIntPropertyEnum());
		}
	}

	//数组
	if (Property->IsA(UArrayProperty::StaticClass()))
	{
		UArrayProperty* ArrayProp = CastChecked<UArrayProperty>(Property);
		CollectExportInfo(ArrayProp->Inner);
	}

	if (Property->IsA(UStructProperty::StaticClass()))
	{
		UStructProperty* StructProp = Cast<UStructProperty>(Property);
		CollectExportInfo(StructProp->Struct);
	}
}




FMonoTextBuilder FScriptEditorPlugin::ExportFunction(const FString& ClassNameCPP, UClass* Class, UFunction* Function)
{
	UClass* FuncSuper = NULL;
	bool static_func = Function->HasAnyFunctionFlags(FUNC_Static);

	//C#声明以及返回值
	{
		FMonoTextBuilder Body_Static;
		FMonoTextBuilder Body_Public;
		Body_Static.AppendLine("[MethodImplAttribute(MethodImplOptions.InternalCall)]");
		UProperty* ReturnValue = Function->GetReturnProperty();
		if (ReturnValue)
		{
			Body_Static += FString::Printf(TEXT("extern static %s %s(IntPtr _this"), *Factory.GetCSharpMarshalReturnTypeName(ReturnValue), *Function->GetName());
		}
		else
		{
			Body_Static += FString::Printf(TEXT("extern static void %s(IntPtr _this"), *Function->GetName());
		}

		Body_Public.AppendLine();
		Body_Public += DocHelper::AppendDocCommentSummary(DocHelper::GetFieldToolTip(*Function));
		Body_Public.Append(FString::Printf(TEXT("public %s %s %s("),
			static_func ? TEXT("static") : TEXT(""), ReturnValue ? *Factory.GetCSharpParamTypeName(ReturnValue) : TEXT("void"), *Function->GetName()));

		FMonoTextBuilder PreCallDeclare;
		FMonoTextBuilder PostCallSet;
		FMonoTextBuilder paramList;
		bool first = true;
		bool HasDefaultParamter = false;
		for (TFieldIterator<UProperty> ParamIt(Function); ParamIt; ++ParamIt)
		{
			UProperty* Param = *ParamIt;
			if (!(Param->GetPropertyFlags() & CPF_ReturnParm))
			{

				if (!first)
				{
					Body_Public += ",";
				}

				Body_Static += FString::Printf(TEXT(",%s %s"), *Factory.GetCSharpMarshalTypeName(Param), *Param->GetName());
				FString DefaultParamValue = Factory.GetCSharpDefaultParameterValue(Function, Param);
				Body_Public += FString::Printf(TEXT("%s %s"), *Factory.GetCSharpParamTypeName(Param), *Param->GetName());
				if (HasDefaultParamter || DefaultParamValue.Len() > 0)
				{
					HasDefaultParamter = true;
					if (DefaultParamValue.Len()>0)
						Body_Public += FString::Printf(TEXT("=%s"), *DefaultParamValue);
					else
						Body_Public += FString::Printf(TEXT("=%s"), *Factory.GetNullReturnCSharpValue(Function, Param));
				}

				PreCallDeclare.AppendLine(Factory.BuildCSharpFuncPreCall(Param));
				PostCallSet.AppendLine(Factory.BuildCSharpFuncPostSet(Param));
				paramList += FString::Printf(TEXT(",%s"), *Factory.BuildCSharpCallParam(Param));


				if (first)
				{
					first = false;
				}
			}
		}

		Body_Static.AppendLine(");");
		Body_Public.AppendLine(")");
		Body_Public.OpenBrace();

		if (!static_func)
		{
			Body_Public.AppendLine(TEXT("CheckIsValid();"));

		}

		Body_Public.Append(PreCallDeclare);

		FString Caller = static_func ? TEXT("IntPtr.Zero") : TEXT("_this.Get()");

		if (ReturnValue != NULL)
		{
			Body_Public.AppendLine(FString::Printf(TEXT("%s ___ret = %s(%s%s);"), *Factory.GetCSharpMarshalReturnTypeName(ReturnValue), *Function->GetName(), *Caller, *paramList.ToText()));
			Body_Public.Append(PostCallSet);
			Body_Public.AppendLine(Factory.BuildCSharpFuncReturn(ReturnValue));
		}
		else
		{
			Body_Public.AppendLine(FString::Printf(TEXT("%s(%s%s);"), *Function->GetName(), *Caller, *paramList.ToText()));
			Body_Public.Append(PostCallSet);

		}
		Body_Public.CloseBrace();

		FMonoTextBuilder GeneratedCSFile;
		GeneratedCSFile += Body_Static.ToText();
		GeneratedCSFile += Body_Public.ToText();

		return GeneratedCSFile;
	}
}


void FScriptEditorPlugin::ExportEnum(UEnum* e)
{
	UE_LOG(LogMonoEditor, Log, TEXT("Export Enum %s"), *e->GetName());
	FString typeName = e->GetName();
	FMonoTextBuilder EnumContext;
	EnumContext.AppendLine("using System;");
	EnumContext.AppendLine("using System.Runtime.CompilerServices;");
	EnumContext.AppendLine("using System.Runtime.InteropServices;");
	EnumContext.AppendLine("namespace UnrealEngine");
	EnumContext.OpenBrace();


	EnumContext += DocHelper::AppendDocCommentSummary(DocHelper::GetFieldToolTip(*e));
	EnumContext.AppendLine(FString::Printf(TEXT("public enum %s:byte"), *typeName));
	EnumContext.OpenBrace();

	for (int i = 0; i < e->NumEnums(); i++)
	{
		FString EnumName = e->GetNameByIndex(i).ToString();
		if (EnumName.StartsWith(typeName))
			EnumName = EnumName.Right(EnumName.Len() - (typeName.Len() + 2));
		EnumContext += DocHelper::AppendDocCommentSummary(DocHelper::GetEnumValueToolTip(*e, i));
		EnumContext.AppendLine(FString::Printf(TEXT("%s=%d,"), *(EnumName), e->GetValueByIndex(i)));
	}
	EnumContext.CloseBrace();
	EnumContext.CloseBrace();


	FString csFileName = FPaths::Combine(*ExportPath, *(typeName + TEXT(".cs")));
	SaveHeaderIfChanged(csFileName, EnumContext.ToText());
}
void FScriptEditorPlugin::ExportClass(UClass* Class)
{
	const FString ClassNameCPP = GetClassNameCPP(Class);

	FMonoTextBuilder GeneratedCSFile;

	GeneratedCSFile.AppendLine(TEXT("using System;"));
	GeneratedCSFile.AppendLine(TEXT("using System.Runtime.CompilerServices;"));
	GeneratedCSFile.AppendLine(TEXT("using System.Runtime.InteropServices;"));
	GeneratedCSFile.AppendLine(TEXT("namespace UnrealEngine"));
	GeneratedCSFile.OpenBrace();

	GeneratedCSFile += DocHelper::AppendDocCommentSummary(DocHelper::GetFieldToolTip(*Class));
	GeneratedCSFile.AppendLine(FString::Printf(TEXT("public partial class %s"), *ClassNameCPP));
	GeneratedCSFile.OpenBrace();


	//属性
	{
		TArray<FString> PropertyNames;


		int boolIndex = 0;
		int32 PropertyIndex = 0;
		for (TFieldIterator<UProperty> PropertyIt(Class, EFieldIteratorFlags::ExcludeSuper); PropertyIt; ++PropertyIt, ++PropertyIndex)
		{
			UProperty* Property = *PropertyIt;
			if (Factory.IsPropertySupported(Property))
			{

				FString PropertyName = Property->GetName();
				PropertyNames.Add(PropertyName);


				FString PropertyOffsetName = FString::Printf(TEXT("%s__Offset"), *PropertyName);

				GeneratedCSFile.AppendLine(FString::Printf(TEXT("static readonly int %s;"), *PropertyOffsetName));
				GeneratedCSFile += DocHelper::AppendDocCommentSummary(DocHelper::GetFieldToolTip(*Property));
				GeneratedCSFile.Append(Factory.BuildCSharpClassProperty(Property));

				GeneratedCSFile.AppendLine();
			}
		}

		//静态构造函数
		//{

		//	GeneratedCSFile.AppendLine(FString::Printf(TEXT("static %s()"), *ClassNameCPP));
		//	GeneratedCSFile.OpenBrace();

		//	GeneratedCSFile.AppendLine(FString::Printf(TEXT("IntPtr NativeClassPtr=GetNativeClassFromName(\"%s\");"), *Class->GetName()));

		//	for (auto PropertyName : PropertyNames)
		//	{
		//		FString PropertyOffsetName = FString::Printf(TEXT("%s__Offset"), *PropertyName);
		//		GeneratedCSFile.AppendLine(FString::Printf(TEXT("%s=GetPropertyOffset(NativeClassPtr,\"%s\");"), *PropertyOffsetName, *PropertyName));
		//	}

		//	GeneratedCSFile.CloseBrace();
		//}
	}


	//方法
	{
		TArray<FString> AllExportedFunctions;

		// Export all functions
		for (TFieldIterator<UFunction> FuncIt(Class, EFieldIteratorFlags::ExcludeSuper); FuncIt; ++FuncIt)
		{
			UFunction* Function = *FuncIt;
			if (IsFunctionSupported(Class, Function))
			{
				AllExportedFunctions.Add(Function->GetName());
				UE_LOG(LogMonoEditor, Log, TEXT("Exporting Function %s"), *Function->GetName());
				GeneratedCSFile += ExportFunction(ClassNameCPP, Class, Function);
			}
			else
			{
				UE_LOG(LogMonoEditor, Log, TEXT("Skip Function %s"), *Function->GetName());
			}
		}
	}



	GeneratedCSFile.CloseBrace();//class
	GeneratedCSFile.CloseBrace();//namespace

	if (SaveHeaderIfChanged(*FPaths::Combine(*ExportPath, (*(ClassNameCPP + ".cs"))), GeneratedCSFile.ToText()))
	{
		UE_LOG(LogMonoEditor, Log, TEXT("Exporting Class Properties %s"), *ClassNameCPP);
	}
}
void FScriptEditorPlugin::ExportStruct(UScriptStruct* Struct)
{
	UScriptStruct* s = Struct;
	FString typeName = GetClassNameCPP(s);

	UE_LOG(LogMonoEditor, Log, TEXT("Export Struct %s"), *s->GetName());

	FMonoTextBuilder StructCSFile;

	StructCSFile.AppendLine("using System;");
	StructCSFile.AppendLine("using System.Runtime.CompilerServices;");
	StructCSFile.AppendLine("using System.Runtime.InteropServices;");
	StructCSFile.AppendLine(TEXT("namespace UnrealEngine"));
	StructCSFile.OpenBrace();


	StructCSFile += DocHelper::AppendDocCommentSummary(DocHelper::GetFieldToolTip(*s));
	StructCSFile.AppendLine(FString::Printf(TEXT("[StructLayout(LayoutKind.Explicit,Size=%d)]"), GetStructSize(s)));

	StructCSFile.AppendLine(FString::Printf(TEXT("public partial struct %s"), *typeName));
	StructCSFile.OpenBrace();

	int32 PropertyIndex = 0;
	for (TFieldIterator<UProperty> PropertyIt(s /*, EFieldIteratorFlags::ExcludeSuper*/); PropertyIt; ++PropertyIt, ++PropertyIndex)
	{
		UProperty* Property = *PropertyIt;
		if (Factory.IsPropertySupported(Property))
		{
			StructCSFile += DocHelper::AppendDocCommentSummary(DocHelper::GetFieldToolTip(*Property));
			StructCSFile.Append(Factory.BuildCSharpStructProperty(typeName, Property));

		}
	}
	StructCSFile.CloseBrace();
	StructCSFile.CloseBrace();

	FString csFileName = FPaths::Combine(*ExportPath, *(typeName + TEXT(".cs")));
	SaveHeaderIfChanged(csFileName, StructCSFile.ToText());
}