// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#include "MonoEditorPluginPrivatePCH.h"
#include "MonoBlueprintCompiler.h"
#include "KismetCompilerModule.h"
#include "MonoBlueprintEditor.h"
#include "LevelEditor.h"
#include "IMonoPlugin.h"

#include "AssetToolsModule.h"
#include "AssetRegistryModule.h"


#define LOCTEXT_NAMESPACE "MonoEditor"

DEFINE_LOG_CATEGORY(LogMonoEditor);


/**
* Script blueprint editor actions
*/
class FAssetTypeActions_ScriptClass : public FAssetTypeActions_Base
{
public:
	// IAssetTypeActions Implementation
	virtual FText GetName() const override { return NSLOCTEXT("AssetTypeActions", "AssetTypeActions_ScriptClass", "Script Class"); }
	virtual FColor GetTypeColor() const override { return FColor(201, 29, 85); }
	virtual UClass* GetSupportedClass() const override { return UMonoBlueprint::StaticClass(); }
	virtual uint32 GetCategories() override { return EAssetTypeCategories::Misc; }
	virtual void OpenAssetEditor(const TArray<UObject*>& InObjects, TSharedPtr<class IToolkitHost> EditWithinLevelEditor = TSharedPtr<IToolkitHost>()) override
	{
		EToolkitMode::Type Mode = EditWithinLevelEditor.IsValid() ? EToolkitMode::WorldCentric : EToolkitMode::Standalone;

		for (auto ObjIt = InObjects.CreateConstIterator(); ObjIt; ++ObjIt)
		{
			auto Blueprint = Cast<UBlueprint>(*ObjIt);
			if (Blueprint && Blueprint->SkeletonGeneratedClass && Blueprint->GeneratedClass)
			{
				TSharedRef<FMonoBlueprintEditor> NewBlueprintEditor(new FMonoBlueprintEditor());

				TArray<UBlueprint*> Blueprints;
				Blueprints.Add(Blueprint);
				NewBlueprintEditor->InitScriptBlueprintEditor(Mode, EditWithinLevelEditor, Blueprints, true);
			}
			else
			{
				FMessageDialog::Open(EAppMsgType::Ok, 
					FText::FromString(TEXT("Script Blueprint could not be loaded because it derives from an invalid class. Check to make sure the parent class for this blueprint hasn't been removed!")));
			}
		}
	}
};

/**
* Script blueprint module
*/
class FScriptEditorPlugin : public IMonoEditorPlugin, IBlueprintCompiler
{
	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;

public:

	virtual bool CanCompile(const UBlueprint* Blueprint) override;

	virtual void PreCompile(UBlueprint* Blueprint) override;
	virtual void Compile(UBlueprint* Blueprint, const FKismetCompilerOptions& CompileOptions, FCompilerResultsLog& Results, TArray<UObject*>* ObjLoaded) override;
	virtual void PostCompile(UBlueprint* Blueprint) override;

	//菜单
	void AddMainMenuExtension();
	void RemoveMainMenuExtension();
	void ExtendFileMenu(FMenuBuilder& MenuBuilder);
	void HotReload();
	void OpenProject();

	TSharedPtr<FExtender> MainMenuExtender;

	TWeakObjectPtr<UMonoFactory> Factory;
	//UPackage* ClassPackage;
	void Event_OnNewClass(const FString& ClassName,UClass* NewParent);

};

IMPLEMENT_MODULE(FScriptEditorPlugin, MonoEditorPlugin)

void FScriptEditorPlugin::StartupModule()
{
	// Register asset types
	FModuleManager::LoadModuleChecked<FAssetToolsModule>("AssetTools").Get().RegisterAssetTypeActions(MakeShareable(new FAssetTypeActions_ScriptClass));

	// Register blueprint compiler
	IKismetCompilerInterface& KismetCompilerModule = FModuleManager::LoadModuleChecked<IKismetCompilerInterface>("KismetCompiler");
	KismetCompilerModule.GetCompilers().Add(this);

	//only initialize agent and menus if we have a UI
	if (!IsRunningCommandlet())
	{
		AddMainMenuExtension();
	}

	Factory = NewObject<UMonoFactory>();
	Factory->AddToRoot();
	IMonoPlugin::Get().Event_OnNewClass().AddRaw(this, &FScriptEditorPlugin::Event_OnNewClass);
}

void FScriptEditorPlugin::ShutdownModule()
{
	if (!IsRunningCommandlet())
	{
		RemoveMainMenuExtension();
	}
	if (Factory.Get() != NULL)
	{
		Factory->MarkPendingKill();
		Factory = NULL;
	}
	
	IMonoPlugin::Get().Event_OnNewClass().RemoveAll(this);
}

UPackage* FindOrCreatePackage(const FString& Name)
{
	FString PackageName = TEXT("/Game/Scripts/Blueprints/")+Name;
	UPackage* ClassPackage = LoadPackage(NULL, *PackageName, 0);
	if (ClassPackage == NULL)
	{
		UE_LOG(LogMonoEditor, Log, TEXT("Create New Packgage %s"), *PackageName);
		ClassPackage = CreatePackage(NULL, *PackageName);
		ClassPackage->AddToRoot();
	}
	
	return ClassPackage;
}


void FScriptEditorPlugin::Event_OnNewClass(const FString& ClassName,UClass* NewParent)
{
	
	
	UClass* ClassToUse = Factory->GetSupportedClass();

	UPackage* ClassPackage = FindOrCreatePackage(ClassName);

	UObject* NewObj = NULL;
	EObjectFlags Flags = RF_Public | RF_Standalone;

    Factory->NewParentClass =NewParent;
	NewObj = Factory->FactoryCreateNew(ClassToUse, ClassPackage, FName(*ClassName), Flags, NULL, GWarn/*, FName(TEXT("MonoEditor")*/);

	if (NewObj)
	{
		// Notify the asset registry
		FAssetRegistryModule::AssetCreated(NewObj);

		// analytics create record
		//FAssetTools::OnNewCreateRecord(ClassToUse, false);

		// Mark the package dirty...
		ClassPackage->MarkPackageDirty();
	}

}

bool FScriptEditorPlugin::CanCompile(const UBlueprint* Blueprint)
{
	return Cast<UMonoBlueprint>(Blueprint) != nullptr;
}

void FScriptEditorPlugin::PreCompile(UBlueprint* Blueprint)
{

}

void FScriptEditorPlugin::Compile(UBlueprint* Blueprint, const FKismetCompilerOptions& CompileOptions, FCompilerResultsLog& Results, TArray<UObject*>* ObjLoaded)
{
	if (UMonoBlueprint* ScriptBlueprint = Cast<UMonoBlueprint>(Blueprint))
	{
		FMonoBlueprintCompiler Compiler(ScriptBlueprint, Results, CompileOptions, ObjLoaded);
		Compiler.Compile();
		if (!Compiler.NewClass)
		{
			UE_LOG(LogMonoEditor, Warning, TEXT("%s Compile Failed"), *ScriptBlueprint->GetName());
		}
	}
}

void FScriptEditorPlugin::PostCompile(UBlueprint* Blueprint)
{

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
	}
	MenuBuilder.EndSection();
}

void FScriptEditorPlugin::HotReload()
{
	IMonoPlugin::Get().HotReload();
}


void FScriptEditorPlugin::OpenProject()
{
	IMonoPlugin::Get().SendCommand("OpenProject");
}

