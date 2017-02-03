// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#pragma once
#include "CoreUObject.h"

DECLARE_LOG_CATEGORY_EXTERN(LogMonoHelper, Log, All);

#if WITH_EDITOR
#define BOOL_PROPERTY_PRIVATE_MEMBER_OFFSET 136
#else
#define BOOL_PROPERTY_PRIVATE_MEMBER_OFFSET 128
#endif

UProperty* FindScriptPropertyHelper(UStruct* Class, FName PropertyName);