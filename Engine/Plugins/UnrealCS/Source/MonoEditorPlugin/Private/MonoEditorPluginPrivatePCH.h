// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#pragma once

#include "IMonoEditorPlugin.h"
#include "CoreUObject.h"
#include "ModuleManager.h"
#include "Engine.h"
#include "UnrealEd.h"
#include "MonoScriptClass.h"
#include "MonoFactory.h"
//#include "ReimportScriptFactory.h"
#include "AssetTypeActions_Base.h"
#include "ClassViewerModule.h"
#include "ClassViewerFilter.h"
#include "Kismet2/KismetEditorUtilities.h"
#include "Kismet2/SClassPickerDialog.h"


DECLARE_LOG_CATEGORY_EXTERN(LogMonoEditor, Log, All);

#define WITH_MONO_HOTRELOAD 1