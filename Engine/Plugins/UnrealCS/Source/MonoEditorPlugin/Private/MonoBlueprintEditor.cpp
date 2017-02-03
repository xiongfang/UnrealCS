// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#include "MonoEditorPluginPrivatePCH.h"
#include "SKismetInspector.h"
#include "MonoBlueprintEditor.h"
#include "BlueprintEditorModes.h"

#define LOCTEXT_NAMESPACE "MonoEditor"

FMonoBlueprintEditor::FMonoBlueprintEditor()
{
}

FMonoBlueprintEditor::~FMonoBlueprintEditor()
{
	UMonoBlueprint* Blueprint = GetScriptBlueprintObj();
	if ( Blueprint )
	{
		Blueprint->OnChanged().RemoveAll(this);
	}
}

void FMonoBlueprintEditor::InitScriptBlueprintEditor(const EToolkitMode::Type Mode, const TSharedPtr< IToolkitHost >& InitToolkitHost, const TArray<UBlueprint*>& InBlueprints, bool bShouldOpenInDefaultsMode)
{
	InitBlueprintEditor(Mode, InitToolkitHost, InBlueprints, bShouldOpenInDefaultsMode);
	SetCurrentMode(FBlueprintEditorApplicationModes::BlueprintDefaultsMode);
}

void FMonoBlueprintEditor::AddApplicationMode(FName ModeName, TSharedRef<FApplicationMode> Mode)
{
	if (ModeName == FBlueprintEditorApplicationModes::BlueprintDefaultsMode)
	{
		FBlueprintEditor::AddApplicationMode(ModeName, Mode);
	}
}

UMonoBlueprint* FMonoBlueprintEditor::GetScriptBlueprintObj() const
{
	return Cast<UMonoBlueprint>(GetBlueprintObj());
}

UBlueprint* FMonoBlueprintEditor::GetBlueprintObj() const
{
	auto Blueprint = FBlueprintEditor::GetBlueprintObj();
	//auto ScriptBlueprint = Cast<UMonoBlueprint>(Blueprint);
	//ScriptBlueprint->
	return Blueprint;
}

#undef LOCTEXT_NAMESPACE
