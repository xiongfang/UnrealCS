// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#include "DocHelper.h"
#include "MonoHelperPrivatePCH.h"
#include "LocTextHelper.h"

static const FName NAME_ToolTip(TEXT("ToolTip"));

namespace LocalizationHack
{
	static bool ToolTipLocalizationInitialized = false;
	static FLocTextHelper* Helper = nullptr;

	bool FindToolTip(const FString& Namespace, const FString& Key, FString& OutText)
	{
		check(ToolTipLocalizationInitialized);

		auto m = Helper->FindSourceText(Namespace, Key);
		if (m.IsValid())
		{
			OutText = m->Source.Text;
			return true;
		}

		return false;
	}
}



void DocHelper::InitializeToolTipLocalization()
{
	if (!LocalizationHack::ToolTipLocalizationInitialized)
	{
		if (LocalizationHack::Helper != nullptr)
			return;

		const FString LocTargetName = TEXT("ToolTips");
		const FString LocTargetPath = FPaths::EngineContentDir() / TEXT("Localization") / LocTargetName;

		LocalizationHack::Helper = new FLocTextHelper(LocTargetPath, FString::Printf(TEXT("%s.manifest"), *LocTargetName), FString::Printf(TEXT("%s.archive"), *LocTargetName), TEXT("en"), TArray<FString>(), nullptr);

		// We need the manifest to work with
		{
			FText LoadManifestError;
			if (!LocalizationHack::Helper->LoadAll(ELocTextHelperLoadFlags::Load, &LoadManifestError))
			{
				UE_LOG(LogMonoHelper, Error, TEXT("Failed to load %s"), *LoadManifestError.ToString());
				return;
			}
		}

		LocalizationHack::ToolTipLocalizationInitialized = true;
	}
}

FString DocHelper::GetEnumValueMetaData(const UEnum& InEnum, const TCHAR* MetadataKey, int32 ValueIndex)
{
#if WITH_EDITOR || HACK_HEADER_GENERATOR
	FName EnumValueMetaDataKey(*FString::Printf(TEXT("%s.%s"), *InEnum.GetEnumName(ValueIndex), MetadataKey));

	if (InEnum.HasMetaData(*EnumValueMetaDataKey.ToString()))
	{
		return InEnum.GetMetaData(*EnumValueMetaDataKey.ToString());
	}
#endif
	return FString();
}

FString DocHelper::GetEnumValueToolTip(const UEnum& InEnum, int32 ValueIndex)
{
	FString LocalizedToolTip;
	const FString NativeToolTip = GetEnumValueMetaData(InEnum, *NAME_ToolTip.ToString(), ValueIndex);

	FString Namespace = TEXT("UObjectToolTips");
	FString Key = ValueIndex == INDEX_NONE
		? InEnum.GetFullGroupName(true) + TEXT(".") + InEnum.GetName()
		: InEnum.GetFullGroupName(true) + TEXT(".") + InEnum.GetName() + TEXT(".") + InEnum.GetEnumName(ValueIndex);

	if (!LocalizationHack::FindToolTip(Namespace, Key, LocalizedToolTip))
	{
		LocalizedToolTip = NativeToolTip;
	}

	return LocalizedToolTip;
}

FMonoTextBuilder DocHelper::AppendDocCommentSummary(const FString& SummaryText)
{
	FMonoTextBuilder outText;

	if (SummaryText.Len() > 0)
	{
		int32 DummyIndex;
		if (SummaryText.FindChar('\n', DummyIndex) || SummaryText.FindChar('\r', DummyIndex))
		{
			outText.AppendLine(TEXT("/// <summary>"));

			FString NewSummaryText = SummaryText.Replace(TEXT("\r"), TEXT(""));

			TArray<FString> Lines;
			NewSummaryText.ParseIntoArray(Lines, TEXT("\n"), true);

			for (auto&& Line : Lines)
			{
				outText.AppendLine(FString::Printf(TEXT("/// %s"), *Line));
			}

			outText.AppendLine(TEXT("/// </summary>"));
		}
		else
		{
			outText.AppendLine(FString::Printf(TEXT("/// <summary>%s</summary>"), *SummaryText));
		}

	}

	return outText;
}
FString DocHelper::GetFieldToolTip(const UField& InField)
{
#if WITH_EDITOR || HACK_HEADER_GENERATOR
	if (InField.HasMetaData(NAME_ToolTip))
	{
		FString LocalizedToolTip;
		const FString NativeToolTip = InField.GetMetaData(NAME_ToolTip);

		static const FString Namespace = TEXT("UObjectToolTips");
		const FString Key = InField.GetFullGroupName(true) + TEXT(".") + InField.GetName();

		if (!LocalizationHack::FindToolTip(Namespace, Key, LocalizedToolTip))
		{
			LocalizedToolTip = NativeToolTip;
		}

		return LocalizedToolTip;
	}
#endif
	return FString();
}