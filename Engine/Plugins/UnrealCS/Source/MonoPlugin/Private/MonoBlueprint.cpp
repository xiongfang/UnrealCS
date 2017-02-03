// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#include "MonoPluginPrivatePCH.h"
#include "MonoBlueprint.h"
#include "MonoScriptClass.h"
#if WITH_EDITOR
#include "BlueprintEditorUtils.h"
#endif

/////////////////////////////////////////////////////
// UMonoBlueprint

UMonoBlueprint::UMonoBlueprint(const FObjectInitializer& ObjectInitializer)
	: Super(ObjectInitializer)
{
}

#if WITH_EDITORONLY_DATA
void UMonoBlueprint::GetAssetRegistryTags(TArray<FAssetRegistryTag>& OutTags) const
{
	OutTags.Add(FAssetRegistryTag(SourceFileTagName(), SourceFilePath, FAssetRegistryTag::TT_Hidden));

	Super::GetAssetRegistryTags(OutTags);
}
#endif

#if WITH_EDITOR
UClass* UMonoBlueprint::GetBlueprintClass() const
{
	return UMonoScriptClass::StaticClass();
}

bool UMonoBlueprint::ValidateGeneratedClass(const UClass* InClass)
{
	bool Result = Super::ValidateGeneratedClass(InClass);

	const UMonoScriptClass* GeneratedClass = Cast<const UMonoScriptClass>(InClass);
	if (!ensure(GeneratedClass))
	{
		return false;
	}
	const UMonoBlueprint* Blueprint = Cast<UMonoBlueprint>(GetBlueprintFromClass(GeneratedClass));
	if (!ensure(Blueprint))
	{
		return false;
	}

	return Result;
}

void UMonoBlueprint::UpdateScriptStatus()
{
	FDateTime OldTimeStamp;
	bool bCodeDirty = !FDateTime::Parse(SourceFileTimestamp, OldTimeStamp);

	if (!bCodeDirty)
	{
		FDateTime TimeStamp = IFileManager::Get().GetTimeStamp(*SourceFilePath);
		bCodeDirty = TimeStamp > OldTimeStamp;
	}

	if (bCodeDirty)
	{
		FBlueprintEditorUtils::MarkBlueprintAsModified(this);
	}
}

void UMonoBlueprint::UpdateSourceCodeIfChanged()
{
	ClassName = GetName();
	/*FDateTime OldTimeStamp;
	bool bCodeDirty = !FDateTime::Parse(SourceFileTimestamp, OldTimeStamp);
	FDateTime TimeStamp = IFileManager::Get().GetTimeStamp(*SourceFilePath);
	bCodeDirty = bCodeDirty || (TimeStamp > OldTimeStamp);

	if (bCodeDirty)
	{
		FString NewScript;
		if (FFileHelper::LoadFileToString(NewScript, *SourceFilePath))
		{
			SourceCode = NewScript;
			SourceFileTimestamp = TimeStamp.ToString();
		}
	}*/
}
#endif