// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#include "MonoPluginPrivatePCH.h"
#include "MonoDomain.h"
#include "MonoTextBuilder.h"
#include "PropertyHandler.h"
#include "DocHelper.h"

DEFINE_LOG_CATEGORY(LogMono);

class FScriptPlugin : public IMonoPlugin, FSelfRegisteringExec
{
	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
	virtual bool Exec(class UWorld* InWorld, const TCHAR* Cmd, FOutputDevice& Ar)override;

	virtual void HotReload() override;
	virtual void FixSize() override;
	// main app domain created when JIT is initialized
	TUniquePtr<FMonoDomain> Domain;

	FOnNewClass OnNewClass;

	FOnNewClass& Event_OnNewClass()
	{
		return OnNewClass;
	}

	virtual void SendCommand(const FString& cmd) override
	{
		FMonoDomain::Get()->SendCommand(cmd);
	}

	TArray<FString> MonoExportedClasses;
	TArray<FString> MonoExportedStructs;

	PropertyHandlerFactroy PropertyFactory;

};

IMPLEMENT_MODULE(FScriptPlugin, MonoPlugin)



void FScriptPlugin::StartupModule()
{
#if WITH_EDITOR
	DocHelper::InitializeToolTipLocalization();
	FMonoDomain::Install();
#endif

	Mono::LoadMonoDLL();
	// main app domain created when JIT is initialized
	Domain.Reset(new FMonoDomain());
}

void FScriptPlugin::ShutdownModule()
{
	//FScriptObjectReferencer::Shutdown();

	Domain.Reset();
	Mono::UnloadMonoDLL();
}

void FScriptPlugin::HotReload()
{
	//Domain.Reset();
	//获取文件列表

	//重新加载dll
	//Domain.Reset(new FMonoDomain());
	//通知热加载
	Domain->HotReload();
}




bool FScriptPlugin::Exec(class UWorld* InWorld, const TCHAR* Cmd, FOutputDevice& Ar)
{
	if (Cmd == FString("FixSize"))
	{
		FixSize();
		return true;
	}
	return false;
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
			UE_LOG(LogMono, Warning, TEXT("Failed to save header export: '%s'"), *HeaderPath);
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

#include "ImplementStruct.h"

void FScriptPlugin::FixSize()
{

//#if WITH_ANDROID
//	const FString Path = FPaths::Combine(*FPaths::GameDir(), TEXT("GeneratedScriptFile_Android_Game"));
//	FString EDITOR_TEXT = TEXT("WITH_GAME");
//#elif WITH_WINDOWS
//#if WITH_EDITOR
//	const FString Path = FPaths::Combine(*FPaths::GameDir(), TEXT("GeneratedScriptFile_Windows_Editor"));
//	FString EDITOR_TEXT = TEXT("WITH_EDITOR");
//#else
//	const FString Path = FPaths::Combine(*FPaths::GameDir(), TEXT("GeneratedScriptFile_Windows_Game"));
//	FString EDITOR_TEXT = TEXT("WITH_GAME");
//#endif
//#elif WITH_MAC
//#if WITH_EDITOR
//	const FString Path = FPaths::Combine(*FPaths::GameDir(), TEXT("GeneratedScriptFile_Mac_Editor"));
//	FString EDITOR_TEXT = TEXT("WITH_EDITOR");
//#else
//	const FString Path = FPaths::Combine(*FPaths::GameDir(), TEXT("GeneratedScriptFile_Mac_Game"));
//	FString EDITOR_TEXT = TEXT("WITH_GAME");
//#endif
//#endif

	FString Path = FPaths::Combine(*FPaths::RootDir(), TEXT("GeneratedScriptFile"));

#if WITH_EDITOR
	Path += TEXT("_Editor");
	FString EDITOR_TEXT = TEXT("WITH_EDITOR");
#else
	Path += TEXT("_Game");
	FString EDITOR_TEXT = TEXT("WITH_GAME");
#endif

#if PLATFORM_64BITS
	Path += TEXT("_64bits");
	FString BIT_TEXT = TEXT("PLATFORM_64BITS");
#else
	Path += TEXT("_32bits");
	FString BIT_TEXT = TEXT("PLATFORM_32BITS");
#endif

	MonoExportedClasses.Empty();
	MonoExportedStructs.Empty();


	int NameIndex = 0;
	while (ExportedStructName[NameIndex] != NULL)
	{
		MonoExportedStructs.Add(ExportedStructName[NameIndex]);
		NameIndex++;
	}
	NameIndex = 0;
	while (ExportedClassName[NameIndex] != NULL)
	{
		MonoExportedClasses.Add(ExportedClassName[NameIndex]);
		NameIndex++;
	}

	//导出所有类的属性偏移量
	for (TObjectIterator<UStruct> it; it; ++it)
	{
		UScriptStruct* Struct = Cast<UScriptStruct>(*it);
		UClass* Class = Cast<UClass>(*it);

		if (Class != NULL)
		{
			const FString ClassNameCPP = GetClassNameCPP(Class);
			if (!MonoExportedClasses.Contains(ClassNameCPP))
				continue;

			FMonoTextBuilder GeneratedCSFile;
			GeneratedCSFile.AppendLine("#if " + EDITOR_TEXT);
			GeneratedCSFile.AppendLine("#if " + BIT_TEXT);

			GeneratedCSFile.AppendLine(TEXT("using System;"));
			GeneratedCSFile.AppendLine(TEXT("using System.Runtime.CompilerServices;"));
			GeneratedCSFile.AppendLine(TEXT("using System.Runtime.InteropServices;"));
			GeneratedCSFile.AppendLine(TEXT("namespace UnrealEngine"));
			GeneratedCSFile.OpenBrace();

			GeneratedCSFile += DocHelper::AppendDocCommentSummary(DocHelper::GetFieldToolTip(*Class));
			GeneratedCSFile.AppendLine(FString::Printf(TEXT("public partial class %s"), *ClassNameCPP));
			GeneratedCSFile.OpenBrace();

			TArray<FString> PropertyNames;

			bool has_member = false;
			int boolIndex = 0;
			int32 PropertyIndex = 0;
			for (TFieldIterator<UProperty> PropertyIt(Class, EFieldIteratorFlags::ExcludeSuper); PropertyIt; ++PropertyIt, ++PropertyIndex)
			{
				UProperty* Property = *PropertyIt;
				if (PropertyFactory.IsPropertySupported(Property))
				{
					has_member = true;
					FString PropertyName = Property->GetName();
					PropertyNames.Add(PropertyName);


					FString PropertyOffsetName = FString::Printf(TEXT("%s__Offset"), *PropertyName);

					GeneratedCSFile.AppendLine(FString::Printf(TEXT("static readonly int %s;"), *PropertyOffsetName));
					GeneratedCSFile += DocHelper::AppendDocCommentSummary(DocHelper::GetFieldToolTip(*Property));
					GeneratedCSFile.Append(PropertyFactory.BuildCSharpClassProperty(Property));

					GeneratedCSFile.AppendLine();
				}
			}

			if (!has_member)
			{
				GeneratedCSFile.CloseBrace();//class
				GeneratedCSFile.CloseBrace();//namespace
				continue;
			}


			//静态构造函数
			{

				GeneratedCSFile.AppendLine(FString::Printf(TEXT("static %s()"), *ClassNameCPP));
				GeneratedCSFile.OpenBrace();

				GeneratedCSFile.AppendLine(FString::Printf(TEXT("IntPtr NativeClassPtr=GetNativeClassFromName(\"%s\");"), *Class->GetName()));

				for (auto PropertyName : PropertyNames)
				{
					FString PropertyOffsetName = FString::Printf(TEXT("%s__Offset"), *PropertyName);
					GeneratedCSFile.AppendLine(FString::Printf(TEXT("%s=GetPropertyOffset(NativeClassPtr,\"%s\");"), *PropertyOffsetName, *PropertyName));
				}

				GeneratedCSFile.CloseBrace();
			}
			GeneratedCSFile.CloseBrace();//class
			GeneratedCSFile.CloseBrace();//namespace

			GeneratedCSFile.AppendLine("#endif");
			GeneratedCSFile.AppendLine("#endif");

			if (SaveHeaderIfChanged(*FPaths::Combine(*Path, (*(ClassNameCPP + "_FixSize.cs"))), GeneratedCSFile.ToText()))
			{
				UE_LOG(LogMono, Log, TEXT("Exporting Class Properties %s"), *ClassNameCPP);
			}
		}
		else if (Struct != NULL)
		{
			UScriptStruct* s = Struct;
			FString typeName = GetClassNameCPP(s);
			if (!MonoExportedStructs.Contains(typeName))
				continue;

			UE_LOG(LogMono, Log, TEXT("Export Struct %s"), *s->GetName());

			FMonoTextBuilder StructCSFile;
			StructCSFile.AppendLine("#if " + EDITOR_TEXT);
			StructCSFile.AppendLine("#if " + BIT_TEXT);

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
				if (PropertyFactory.IsPropertySupported(Property))
				{
					StructCSFile += DocHelper::AppendDocCommentSummary(DocHelper::GetFieldToolTip(*Property));
					StructCSFile.Append(PropertyFactory.BuildCSharpStructProperty(typeName, Property));

				}
			}
			StructCSFile.CloseBrace();
			StructCSFile.CloseBrace();

			StructCSFile.AppendLine("#endif");
			StructCSFile.AppendLine("#endif");

			FString csFileName = FPaths::Combine(*Path, *(typeName + TEXT(".cs")));
			SaveHeaderIfChanged(csFileName, StructCSFile.ToText());
		}

	}
}
