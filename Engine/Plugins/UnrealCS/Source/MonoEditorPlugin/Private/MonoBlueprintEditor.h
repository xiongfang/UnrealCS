// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

#include "Editor/Kismet/Public/BlueprintEditor.h"

/**
 * Script blueprint editor (extends Blueprint editor)
 */
class FMonoBlueprintEditor : public FBlueprintEditor
{
public:
	FMonoBlueprintEditor();
	virtual ~FMonoBlueprintEditor();

	/** Initializes script editor */
	void InitScriptBlueprintEditor(const EToolkitMode::Type Mode, const TSharedPtr< IToolkitHost >& InitToolkitHost, const TArray<UBlueprint*>& InBlueprints, bool bShouldOpenInDefaultsMode);

	/** Work around for the fact there's no other way to prevent Components Mode and Graph Mode from being entered/created */
	virtual void AddApplicationMode(FName ModeName, TSharedRef<FApplicationMode> Mode) override;

	/** @return The Script blueprint currently being edited in this editor */
	class UMonoBlueprint* GetScriptBlueprintObj() const;

	virtual UBlueprint* GetBlueprintObj() const override;
};
