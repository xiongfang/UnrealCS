// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#pragma once
#include "MonoTextBuilder.h"

class MONOHELPER_API DocHelper
{
public:
	static void InitializeToolTipLocalization();
	static FMonoTextBuilder AppendDocCommentSummary(const FString& SummaryText);
	static FString GetEnumValueMetaData(const UEnum& InEnum, const TCHAR* MetadataKey, int32 ValueIndex);
	static FString GetEnumValueToolTip(const UEnum& InEnum, int32 ValueIndex);
	static FString GetFieldToolTip(const UField& InField);
};