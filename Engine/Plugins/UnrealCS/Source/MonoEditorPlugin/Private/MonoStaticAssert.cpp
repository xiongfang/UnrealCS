// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#include "MonoEditorPluginPrivatePCH.h"

static_assert(sizeof(FName) == 12, "error FKey Size");
static_assert(sizeof(FScriptArray) == 16, "error FScriptArray Size");
static_assert(sizeof(FString) == 16, "error FString Size");
static_assert(sizeof(FScriptBitArray) == 32, "error FScriptBitArray Size");
static_assert(sizeof(FScriptSparseArray) == 56, "error FScriptSparseArray Size");
static_assert(sizeof(FScriptSparseArrayLayout) == 12, "error FScriptSparseArrayLayout Size");
static_assert(sizeof(FScriptSet) == 80, "error FScriptSet Size");
static_assert(sizeof(FScriptSetLayout) == 28, "error FScriptSetLayout Size");
static_assert(sizeof(FScriptMap) == 80, "error FScriptMap Size");
static_assert(sizeof(FText) == 24, "error FText Size");
static_assert(sizeof(TMulticastScriptDelegate<FWeakObjectPtr>) == 16, "error TMulticastScriptDelegate Size");
static_assert(sizeof(TScriptDelegate<FWeakObjectPtr>) == 20, "error TScriptDelegate Size");
