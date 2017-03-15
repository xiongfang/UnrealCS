// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#include "MonoScriptCodeGenerator.h"
#include "ScriptGeneratorPluginPrivatePCH.h"

#include "DocHelper.h"
#include "IPluginManager.h"


FMonoScriptCodeGenerator::FMonoScriptCodeGenerator(const FString& RootLocalPath, const FString& RootBuildPath, const FString& OutputDirectory, const FString& InIncludeBase)
	: FScriptCodeGeneratorBase(RootLocalPath, RootBuildPath, OutputDirectory, InIncludeBase)
{
	FString PluginDir = IPluginManager::Get().FindPlugin(TEXT("UnrealCS"))->GetBaseDir();
	GeneratedCodePath = FPaths::Combine(*PluginDir, TEXT("Source"), TEXT("MonoPlugin"), TEXT("Private"), TEXT("GeneratedScriptLibraries"));

	CSFileExportPath = FPaths::Combine(*RootLocalPath, TEXT("GeneratedScriptFile"));
	DocHelper::InitializeToolTipLocalization();


	//BlackList.AddStruct("RepMovement");
	//BlackList.AddStruct("DialogueWaveParameter");
	BlackList.AddClass("KismetArrayLibrary");
	BlackList.AddClass("MeshVertexPainterKismetLibrary");
	BlackList.AddClass("VisualLoggerKismetLibrary");
	BlackList.AddFunction("BlueprintFunctionLibrary", "MakeStringAssetReference");
	BlackList.AddFunction("KismetSystemLibrary", "StackTrace");
	BlackList.AddFunction("ParticleSystem", "ContainsEmitterType");
	BlackList.AddFunction("Texture2D", "Blueprint_GetSizeX");
	BlackList.AddFunction("Texture2D", "Blueprint_GetSizeY");
	BlackList.AddClass("MaterialInstanceDynamic");
	BlackList.AddClass("Object");
	BlackList.AddClass("LevelStreamingKismet");
	BlackList.AddFunction("SceneCapture2D", "OnInterpToggle");
	//BlackList.AddStruct("AtmospherePrecomputeParameters");
	BlackList.AddFunction("AtmosphericFogComponent", "StartPrecompute");
	BlackList.AddFunction("TimelineComponent", "OnRep_Timeline");
	BlackList.AddFunction("LevelStreaming", "CreateInstance");
	BlackList.AddFunction("NavModifierVolume", "SetAreaClass");
	BlackList.AddFunction("MatineeActor", "EnableGroupByName");
	BlackList.AddFunction("PlanarReflection", "OnInterpToggle");


	//deprecated
	BlackList.AddFunction("AnimInstance", "GetCurrentStateElapsedTime");
	BlackList.AddFunction("AnimInstance", "GetStateWeight");
	BlackList.AddFunction("AnimInstance", "GetAnimAssetPlayerTimeFromEndFraction");
	BlackList.AddFunction("AnimInstance", "GetAnimAssetPlayerTimeFromEnd");
	BlackList.AddFunction("AnimInstance", "GetAnimAssetPlayerTimeFraction");
	BlackList.AddFunction("AnimInstance", "GetAnimAssetPlayerLength");
	BlackList.AddFunction("AnimInstance", "PlaySlotAnimation");
	BlackList.AddFunction("SceneComponent", "DetachFromParent");
	BlackList.AddFunction("GameplayStatics", "BeginSpawningActorFromClass");
}

void FMonoScriptCodeGenerator::FinishExport()
{
	//导出类
	{
		for (auto Class : ClassInfos)
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

	//写入需要导出的类和结构体到文件
	{
		FString ExportStructs;
		ExportStructs += "const char* ExportedStructName[]={\r\n";

		for (auto s : NeededExportedStruct)
		{
			const FString ClassNameCPP = GetStructNameCPP(s);
			ExportStructs += FString::Printf(TEXT("\t\"%s\",\r\n"), *ClassNameCPP);
		}
		ExportStructs += "\tNULL\r\n};\r\n";
		ExportStructs += "const char* ExportedClassName[]={\r\n";
		//写入需要修复的类
		for (auto Class : ClassInfos)
		{
			if (Class.CanExport)
			{
				const FString ClassNameCPP = GetClassNameCPP(Class.Class);
				ExportStructs += FString::Printf(TEXT("\t\"%s\",\r\n"), *ClassNameCPP);
			}
		}
		ExportStructs += "\tNULL\r\n};\r\n";


		//保存到编辑器目录
		FString csFileName = IPluginManager::Get().FindPlugin(TEXT("UnrealCS"))->GetBaseDir();
		csFileName = FPaths::Combine(*csFileName, TEXT("Source"), TEXT("MonoPlugin"), TEXT("Private"), TEXT("ImplementStruct.h"));
		SaveHeaderIfChanged(csFileName, ExportStructs);
	}
	



	GlueAllGeneratedFiles();
	RenameTempFiles();
}

void FMonoScriptCodeGenerator::GlueAllGeneratedFiles()
{
	// Generate inl library file
	FString LibGlueFilename = GeneratedCodePath / TEXT("GeneratedScriptLibraries.inl");
	FString LibGlue;

	// Include all source header files
	for (auto& HeaderFilename : AllSourceClassHeaders)
	{
		// Re-base to make sure we're including the right files on a remote machine
		FString NewFilename(RebaseToBuildPath(HeaderFilename));
		LibGlue += FString::Printf(TEXT("#include \"%s\"\r\n"), *NewFilename);
	}

	// Include all script glue headers
	for (auto& HeaderFilename : AllScriptHeaders)
	{
		// Re-base to make sure we're including the right files on a remote machine
		FString NewFilename(FPaths::GetCleanFilename(HeaderFilename));
		LibGlue += FString::Printf(TEXT("#include \"%s\"\r\n"), *NewFilename);
	}
	
	LibGlue += TEXT("\r\n namespace UnrealEngine{\r\n void MonoBindFunctions()\r\n{\r\n");
	for (auto Class : ClassInfos)
	{
		if (Class.CanExport)
		{
			const FString ClassNameCPP = GetClassNameCPP(Class.Class);
			LibGlue += FString::Printf(TEXT("\t_%s::BindFunctions();\r\n"), *ClassNameCPP);
		}

	}
	LibGlue += TEXT("}\r\n\r\n}");

	SaveHeaderIfChanged(LibGlueFilename, LibGlue);
}

void FMonoScriptCodeGenerator::ExportClass(ClassInfo& CI)
{
	UClass* Class = CI.Class;

	TArray<FString> AllExportedFunctions;

	const FString ClassNameCPP = GetClassNameCPP(Class);

	GeneratedCSFile.Empty();
	GeneratedCSFile = TEXT("using System;\r\nusing System.Runtime.CompilerServices;\r\n");
	GeneratedCSFile += TEXT("using System.Runtime.InteropServices;\r\n");


	UClass* superClass = Class->GetSuperClass();

	if (superClass != NULL)
	{
		FString SuperClassName = GetClassNameCPP(superClass);
		GeneratedCSFile += FString::Printf(TEXT("namespace UnrealEngine{\r\npublic partial class %s:%s \r\n{\r\n"), *ClassNameCPP, *SuperClassName);
	}
	else
	{
		GeneratedCSFile += FString::Printf(TEXT("namespace UnrealEngine{\r\npublic partial class %s \r\n{\r\n"), *ClassNameCPP);
	}

	if (CI.CanExport)
	{
		if (!CI.SourceHeader.IsEmpty())
			AllSourceClassHeaders.Add(CI.SourceHeader);

		AllScriptHeaders.Add(CI.ClassHeader);


		FMonoTextBuilder GeneratedGlue;
		GeneratedGlue.AppendLine(TEXT("#pragma once"));
		GeneratedGlue.AppendLine();
		GeneratedGlue.AppendLine(TEXT("namespace UnrealEngine"));
		GeneratedGlue.OpenBrace();
		GeneratedGlue.AppendLine(FString::Printf(TEXT("class _%s"), *ClassNameCPP));
		GeneratedGlue.OpenBrace();

		// Export all functions
		for (TFieldIterator<UFunction> FuncIt(Class, EFieldIteratorFlags::ExcludeSuper); FuncIt; ++FuncIt)
		{
			UFunction* Function = *FuncIt;
			if (IsFunctionSupported(Class, Function))
			{
				AllExportedFunctions.Add(Function->GetName());
				UE_LOG(LogScriptGenerator, Log, TEXT("Exporting Function %s"), *Function->GetName());
				GeneratedGlue.Append(ExportFunction(ClassNameCPP, Class, Function));
			}
			else
			{
				UE_LOG(LogScriptGenerator, Log, TEXT("Skip Function %s"), *Function->GetName());
			}
		}

		//// Export properties that are owned by this class
		//int32 PropertyIndex = 0;
		//for (TFieldIterator<UProperty> PropertyIt(Class, EFieldIteratorFlags::ExcludeSuper); PropertyIt; ++PropertyIt, ++PropertyIndex)
		//{
		//	UProperty* Property = *PropertyIt;
		//	if (Factory.IsPropertySupported(Property))
		//	{
		//		FMonoTextBuilder Text = Factory.BuildCppProperty(ClassNameCPP, Property);
		//		if (Text.ToText().Len() > 0)
		//		{
		//			GeneratedGlue.Append(Text);
		//			UE_LOG(LogScriptGenerator, Log, TEXT("Exporting Property %s"), *Property->GetName());
		//			AllExportedFunctions.Add(FString::Printf(TEXT("Get_%s"), *Property->GetName()));
		//			AllExportedFunctions.Add(FString::Printf(TEXT("Set_%s"), *Property->GetName()));
		//		}
		//	}
		//	else
		//	{
		//		UE_LOG(LogScriptGenerator, Log, TEXT("Skip Property %s"), *Property->GetName());
		//	}
		//}


		GeneratedGlue.AppendLine(FString::Printf(TEXT("static UClass* StaticClass(){return %s::StaticClass();}"), *ClassNameCPP));

		GeneratedGlue.AppendLine(TEXT("public:"));
		GeneratedGlue.AppendLine(TEXT("static void BindFunctions()"));
		GeneratedGlue.OpenBrace();

		for (int i = 0; i < AllExportedFunctions.Num(); i++)
		{
			GeneratedGlue.AppendLine(FString::Printf(TEXT("mono_add_internal_call(\"UnrealEngine.%s::%s\",(const void*)%s);"),
				*ClassNameCPP, *AllExportedFunctions[i], *AllExportedFunctions[i]));
		}
		GeneratedGlue.AppendLine(FString::Printf(TEXT("mono_add_internal_call(\"UnrealEngine.%s::StaticClass\",(const void*)StaticClass);"),
			*ClassNameCPP));

		GeneratedGlue.CloseBrace();//BindFunctions
		GeneratedGlue.CloseBrace();
		GeneratedGlue.Append(";");//Class
		GeneratedGlue.CloseBrace();//Namespace
		

		SaveHeaderIfChanged(CI.ClassHeader, GeneratedGlue.ToText());

		GeneratedCSFile += TEXT("\t[MethodImplAttribute(MethodImplOptions.InternalCall)]\r\n\tpublic extern static new IntPtr StaticClass();\r\n");
	}
	

	GeneratedCSFile += TEXT("}\r\n}\r\n");
	FString csFileName = FPaths::Combine(*CSFileExportPath, *(ClassNameCPP + TEXT(".cs")));
	SaveHeaderIfChanged(csFileName, GeneratedCSFile);
}

void FMonoScriptCodeGenerator::ExportClass(UClass* Class, const FString& SourceHeaderFilename, const FString& GeneratedHeaderFilename, bool bHasChanged)
{
	if (!NeededExportedClass.Contains(Class))
	{
		ClassInfo ci;
		ci.CanExport = CollectExportInfo(Class);
		ci.SourceHeader = SourceHeaderFilename;
		ci.ClassHeader = GetScriptHeaderForClass(Class);
		ci.Class = Class;
		ClassInfos.Add(ci);
		NeededExportedClass.Add(Class);
	}
}
bool FMonoScriptCodeGenerator::CollectExportInfo(UStruct* Struct)
{
	if (UClass * Class = Cast<UClass>(Struct))
	{
		if (!IsClassSupported(Class) || NeededExportedClass.Contains(Class))
		{
			UE_LOG(LogScriptGenerator,Log,TEXT("Skip Class %s"),*Class->GetName())
			return false;
		}
	}
	else if(UScriptStruct * ScriptStruct = Cast<UScriptStruct>(Struct))
	{
		if (!IsStructSupported(ScriptStruct) || NeededExportedStruct.Contains(Struct))
		{
			UE_LOG(LogScriptGenerator, Log, TEXT("Skip Struct %s"), *Struct->GetName())
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

void FMonoScriptCodeGenerator::CollectExportInfo(UFunction* Function)
{
	for (TFieldIterator<UProperty> ParamIt(Function); ParamIt; ++ParamIt)
	{
		UProperty* Param = *ParamIt;
		CollectExportInfo(Param);
	}
}
void FMonoScriptCodeGenerator::CollectExportInfo(UProperty* Property)
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

FMonoTextBuilder FMonoScriptCodeGenerator::ExportFunction(const FString& ClassNameCPP, UClass* Class, UFunction* Function)
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
			static_func?TEXT("static"):TEXT(""), ReturnValue?*Factory.GetCSharpParamTypeName(ReturnValue):TEXT("void"), *Function->GetName()));

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
					if(DefaultParamValue.Len()>0)
						Body_Public += FString::Printf(TEXT("=%s"), *DefaultParamValue);
					else
						Body_Public += FString::Printf(TEXT("=%s"), *Factory.GetNullReturnCSharpValue(Function,Param));
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

		FString Caller = static_func ? TEXT("IntPtr.Zero"):TEXT("_this.Get()");

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


		GeneratedCSFile += Body_Static.ToText();
		GeneratedCSFile += Body_Public.ToText();


	}

	//C++声明以及返回值
	{
		UProperty* ReturnValue = Function->GetReturnProperty();
		FMonoTextBuilder FuncText;
		if(ReturnValue!=nullptr)
			FuncText += FString::Printf(TEXT("static %s %s(%s* _this"),*Factory.GetCppMarshalReturnTypeName(ReturnValue), *Function->GetName(), *GetClassNameCPP(Class));
		else
			FuncText += FString::Printf(TEXT("static void %s(%s* _this"), *Function->GetName(), *GetClassNameCPP(Class));

		for (TFieldIterator<UProperty> ParamIt(Function); ParamIt; ++ParamIt)
		{
			UProperty* Param = *ParamIt;
			if (!(Param->GetPropertyFlags() & CPF_ReturnParm))
			{
				FuncText += FString::Printf(TEXT(",%s %s"), *Factory.GetCppMarshalTypeName(Param), *Param->GetName());
			}
		}
		FuncText.AppendLine(TEXT(")"));
		FuncText.OpenBrace();

		FMonoTextBuilder PreCallDeclare;
		FMonoTextBuilder PostCallSet;
		FMonoTextBuilder paramList;

		bool first = true;
		for (TFieldIterator<UProperty> ParamIt(Function); ParamIt; ++ParamIt)
		{
			UProperty* Param = *ParamIt;
			if (!(Param->GetPropertyFlags() & CPF_ReturnParm))
			{
				if (!first)
					paramList += ",";
				{
					PreCallDeclare.AppendLine(Factory.BuildCppFuncPreCall(Param));
					PostCallSet.AppendLine(Factory.BuildCppFuncPostSet(Param));
					paramList += Factory.BuildCppCallParam(Param);

					first = false;
				}
			}
		}
		FuncText.Append(PreCallDeclare);

		if (ReturnValue)
		{
			FuncText.AppendLine(FString::Printf(TEXT("%s ___ret = _this->%s(%s);"), *Factory.GetCppParamTypeName(ReturnValue), *Function->GetName(), *paramList.ToText()));
			FuncText.AppendLine(Factory.BuildCppFuncReturn(ReturnValue));

		}
		else
		{
			FuncText.AppendLine(FString::Printf(TEXT("_this->%s(%s);"), *Function->GetName(), *paramList.ToText()));
		}
		FuncText.Append(PostCallSet);
		FuncText.CloseBrace();

		return FuncText;
	}
}



FString FMonoScriptCodeGenerator::GetStructNameCPP(UStruct* Class)
{
	return FString::Printf(TEXT("%s%s"), Class->GetPrefixCPP(), *Class->GetName());
}

void FMonoScriptCodeGenerator::ExportEnum(UEnum* e)
{
	UE_LOG(LogScriptGenerator, Log, TEXT("Export Enum %s"), *e->GetName());
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


	FString csFileName = FPaths::Combine(*CSFileExportPath, *(typeName + TEXT(".cs")));
	SaveHeaderIfChanged(csFileName, EnumContext.ToText());
}

bool FMonoScriptCodeGenerator::IsStructSupported(UScriptStruct* Struct)
{
	if (BlackList.HasStruct(Struct))
		return false;

	return true;
}
bool FMonoScriptCodeGenerator::IsClassSupported(UClass* Class)
{
	bool bCanExport = (Class->ClassFlags & (CLASS_RequiredAPI | CLASS_MinimalAPI)) != 0;
	if (!bCanExport)
		return false;

	if (BlackList.HasClass(Class))
		return false;

	return bCanExport;
}
bool FMonoScriptCodeGenerator::IsEnumSupported(UEnum* Enum)
{
	return !BlackList.HasEnum(Enum);
}

bool FMonoScriptCodeGenerator::IsFunctionSupported(UClass* Class, UFunction* Function)
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


	if (BlackList.HasFunction(Class, Function))
		return false;


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

