// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#include "MonoEditorPluginPrivatePCH.h"
#include "MonoFactory.h"
#include "MonoScriptClass.h"
#include "MonoScriptBind_Component.h"
#include "MonoBlueprint.h"
#include "Kismet2/KismetEditorUtilities.h"

UMonoFactory::UMonoFactory(const FObjectInitializer& ObjectInitializer)
	: Super(ObjectInitializer)
{
	SupportedClass = UMonoBlueprint::StaticClass();
	ParentClass = UMonoScriptBind_Component::StaticClass();

	//FScriptContextBase::GetSupportedScriptFileFormats(Formats);

	bCreateNew = true;
	bEditorImport = false;
	bText = true;
	bEditAfterNew = true;
}

bool UMonoFactory::ConfigureProperties()
{
	//// Null the parent class so we can check for selection later
	//ParentClass = NULL;

	//// Load the class viewer module to display a class picker
	//FClassViewerModule& ClassViewerModule = FModuleManager::LoadModuleChecked<FClassViewerModule>("ClassViewer");

	//// Fill in options
	//FClassViewerInitializationOptions Options;
	//Options.Mode = EClassViewerMode::ClassPicker;
	//Options.DisplayMode = EClassViewerDisplayMode::TreeView;
	//Options.bShowObjectRootClass = true;
	//Options.bIsBlueprintBaseOnly = true;
	//Options.bShowUnloadedBlueprints = true;

	//const FText TitleText = NSLOCTEXT("EditorFactories", "CreateScriptOptions", "Pick Parent Class");
	//UClass* ChosenClass = NULL;
	//const bool bPressedOk = SClassPickerDialog::PickClass(TitleText, Options, ChosenClass, UScriptBlueprintGeneratedClass::StaticClass());
	//if (bPressedOk)
	//{
	//	ParentClass = ChosenClass;
	//}

	return true;
}


bool UMonoFactory::DoesSupportClass(UClass* Class)
{
	return Class == UMonoBlueprint::StaticClass();
}

//UObject* UMonoFactory::FactoryCreateText(UClass* InClass, UObject* InParent, FName InName, EObjectFlags Flags, UObject* Context, const TCHAR* Type, const TCHAR*& Buffer, const TCHAR* BufferEnd, FFeedbackContext* Warn)
//{
//	GEditor->SelectNone(true, true, false);
//
//	UMonoBlueprint* NewBlueprint = nullptr;
//	TAutoPtr<FScriptContextBase> ScriptContext(FScriptContextBase::CreateContext(Buffer, nullptr, nullptr));
//	if (ScriptContext.IsValid())
//	{
//		NewBlueprint = Cast<UMonoBlueprint>(FindObject<UBlueprint>(InParent, *InName.ToString()));
//		if (NewBlueprint != nullptr)
//		{
//			NewBlueprint->Modify();
//		}
//		else
//		{
//			NewBlueprint = CastChecked<UMonoBlueprint>(FKismetEditorUtilities::CreateBlueprint(ParentClass, InParent, InName, BPTYPE_Normal, UMonoBlueprint::StaticClass(), UScriptBlueprintGeneratedClass::StaticClass(), "UMonoFactory"));
//		}
//		NewBlueprint->SourceFilePath = FReimportManager::SanitizeImportFilename(CurrentFilename, NewBlueprint);
//		NewBlueprint->ClassName = Buffer;
//		NewBlueprint->SourceFileTimestamp = IFileManager::Get().GetTimeStamp(*NewBlueprint->SourceFilePath).ToString();
//
//		// Need to make sure we compile with the new source code
//		FKismetEditorUtilities::CompileBlueprint(NewBlueprint);
//
//		FEditorDelegates::OnAssetPostImport.Broadcast(this, NewBlueprint);
//	}
//	else
//	{
//		UE_LOG(LogScriptEditorPlugin, Warning, TEXT("Failed to import %s: could not compile script."), *CurrentFilename);
//	}
//
//	return NewBlueprint;
//}

UObject* UMonoFactory::FactoryCreateNew(UClass* InClass, UObject* InParent, FName InName, EObjectFlags Flags, UObject* Context, FFeedbackContext* Warn)
{
	UMonoBlueprint* NewBlueprint = nullptr;
	NewBlueprint = Cast<UMonoBlueprint>(FindObject<UBlueprint>(InParent, *InName.ToString()));
	if (NewBlueprint != nullptr)
	{
		NewBlueprint->Modify();
	}
	else
	{
        //默认蓝图父类为UMonoConpententClass
        UClass* ParentClassNew =ParentClass;
        //如果有新父类
        if(NewParentClass!=nullptr)
        {
            ParentClassNew = NewParentClass;
        }

		NewBlueprint = CastChecked<UMonoBlueprint>(FKismetEditorUtilities::CreateBlueprint(ParentClassNew, InParent, InName, BPTYPE_Normal, UMonoBlueprint::StaticClass(), UMonoScriptClass::StaticClass(), "UMonoFactory"));
	}
    //NewBlueprint->AssetImportData->Update(CurrentFilename);
	//NewBlueprint->SourceFilePath = FReimportManager::SanitizeImportFilename(CurrentFilename, NewBlueprint);
	NewBlueprint->ClassName = InName.ToString();
	NewBlueprint->SourceFileTimestamp = IFileManager::Get().GetTimeStamp(*NewBlueprint->SourceFilePath).ToString();
	
	// Need to make sure we compile with the new source code
	FKismetEditorUtilities::CompileBlueprint(NewBlueprint);
	
	FEditorDelegates::OnAssetPostImport.Broadcast(this, NewBlueprint);
	return NewBlueprint;
}