// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

#include "Engine/Blueprint.h"
#include "MonoBlueprint.generated.h"

/**
* The Script blueprint generates script-defined classes
*/
UCLASS(BlueprintType)
class MONOPLUGIN_API UMonoBlueprint : public UBlueprint
{
	GENERATED_UCLASS_BODY()

public:
	/** Path to the script text used to construct this asset. Relative to the object's package, BaseDir() or absolute */
	UPROPERTY(Category = Script, VisibleAnywhere, BlueprintReadWrite)
	FString SourceFilePath;
	/** Date/Time-stamp of the file from the last import. */
	UPROPERTY(Category = Script, VisibleAnywhere)
	FString SourceFileTimestamp;

	/** Script source code. @todo: this should be editor-only */
	UPROPERTY()
	FString ClassName;

#if WITH_EDITORONLY_DATA
	/** Override to ensure we write out the asset import data */
	virtual void GetAssetRegistryTags(TArray<FAssetRegistryTag>& OutTags) const;
#endif

#if WITH_EDITOR
	virtual UClass* GetBlueprintClass() const override;

	virtual bool SupportedByDefaultBlueprintFactory() const override
	{
		return false;
	}
	// End of UBlueprint interface

	static bool ValidateGeneratedClass(const UClass* InClass);
	void UpdateScriptStatus();

	/**
	* Checks if the source code changed and updates it if so (does not recompile the class)
	*/
	void UpdateSourceCodeIfChanged();
#endif
};