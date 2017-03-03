// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#include "DocHelper.h"
#include "MonoHelperPrivatePCH.h"


static const FName NAME_ToolTip(TEXT("ToolTip"));

namespace LocalizationHack
{
	struct FLocalizationEntryTracker
	{
		struct FEntry
		{
			FString TableName;
			uint32 SourceStringHash;
			FString LocalizedString;
		};

		typedef TArray<FEntry> FEntryArray;
		typedef TMap<FString, FEntryArray> FKeyTable;
		typedef TMap<FString, FKeyTable> FNamespaceTable;

		FNamespaceTable Namespaces;

		void ReadFromDirectory(const FString& DirectoryPath);
		bool ReadFromFile(const FString& FilePath);
		void ReadFromArchive(FArchive& Archive, const FString& Identifier);
	};

	void FLocalizationEntryTracker::ReadFromDirectory(const FString& DirectoryPath)
	{
		// Find resources in the specified folder.
		TArray<FString> ResourceFileNames;
		IFileManager::Get().FindFiles(ResourceFileNames, *(DirectoryPath / TEXT("*.locres")), true, false);

		// For each resource:
		for (int32 ResourceIndex = 0; ResourceIndex < ResourceFileNames.Num(); ++ResourceIndex)
		{
			const FString ResourceFilePath = DirectoryPath / ResourceFileNames[ResourceIndex];
			ReadFromFile(FPaths::ConvertRelativePathToFull(ResourceFilePath));
		}
	}

	bool FLocalizationEntryTracker::ReadFromFile(const FString& FilePath)
	{
		FArchive* Reader = IFileManager::Get().CreateFileReader(*FilePath);
		if (!Reader)
		{
			return false;
		}

		Reader->SetForceUnicode(true);

		ReadFromArchive(*Reader, FilePath);

		bool Success = Reader->Close();
		delete Reader;

		return Success;
	}

	void FLocalizationEntryTracker::ReadFromArchive(FArchive& Archive, const FString& Identifier)
	{
		// Read namespace count
		uint32 NamespaceCount;
		Archive << NamespaceCount;

		for (uint32 i = 0; i < NamespaceCount; ++i)
		{
			// Read namespace
			FString Namespace;
			Archive << Namespace;

			// Read key count
			uint32 KeyCount;
			Archive << KeyCount;

			FLocalizationEntryTracker::FKeyTable& KeyTable = Namespaces.FindOrAdd(*Namespace);

			for (uint32 j = 0; j < KeyCount; ++j)
			{
				// Read key
				FString Key;
				Archive << Key;

				FLocalizationEntryTracker::FEntryArray& EntryArray = KeyTable.FindOrAdd(*Key);

				FLocalizationEntryTracker::FEntry NewEntry;
				NewEntry.TableName = Identifier;

				// Read string entry.
				Archive << NewEntry.SourceStringHash;
				Archive << NewEntry.LocalizedString;

				EntryArray.Add(NewEntry);
			}
		}
	}

	static FLocalizationEntryTracker ToolTipLocalization;
	static bool ToolTipLocalizationInitialized = false;

	bool FindToolTip(const FString& Namespace, const FString& Key, FString& OutText)
	{
		check(ToolTipLocalizationInitialized);
		FLocalizationEntryTracker::FKeyTable* Table = ToolTipLocalization.Namespaces.Find(Namespace);

		if (nullptr != Table)
		{
			FLocalizationEntryTracker::FEntryArray* Entries = Table->Find(Key);

			if (nullptr != Entries && Entries->Num() > 0)
			{
				OutText = (*Entries)[0].LocalizedString;
				return true;
			}
		}

		return false;
	}
}



void DocHelper::InitializeToolTipLocalization()
{
	if (!LocalizationHack::ToolTipLocalizationInitialized)
	{
		TArray<FString> ToolTipPaths;
		ToolTipPaths.Add(TEXT("../../../Engine/Content/Localization/ToolTips"));

		for (int32 PathIndex = 0; PathIndex < ToolTipPaths.Num(); ++PathIndex)
		{
			const FString& LocalizationPath = ToolTipPaths[PathIndex];
			//Ê¹ÓÃÓ¢ÎÄ
			const FString CulturePath = LocalizationPath / TEXT("en");

			LocalizationHack::ToolTipLocalization.ReadFromDirectory(CulturePath);
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