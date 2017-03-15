// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#pragma once

#include "Headers_Core.h"
#include "Headers_CoreUObject.h"
#include "Headers_Engine.h"


#include "IMonoEditorPlugin.h"

#include "ModuleManager.h"


//#include "UnrealEd.h"
#include "Classes/Factories/Factory.h"
#include "Editor.h"
#include "EditorStyleSet.h"
#include "EngineDefines.h"

#include "Misc/Timespan.h"

#include "EditorComponents.h"
#include "EditorReimportHandler.h"
#include "TexAlignTools.h"

#include "TickableEditorObject.h"


#include "Kismet2/ComponentEditorUtils.h"
#include "Commandlets/EditorCommandlets.h"
#include "EditorUndoClient.h"
#include "EditorModeTools.h"
#include "UnrealWidget.h"
#include "Editor.h"

#include "EditorViewportClient.h"
#include "LevelEditorViewport.h"

#include "EditorModeRegistry.h"
#include "EdMode.h"
#include "EditorModeManager.h"
#include "EditorModes.h"

#include "MRUList.h"


//#include "../Private/GeomFitUtils.h"

#include "UnrealEdMisc.h"
#include "EditorDirectories.h"
#include "Utils.h"
#include "FileHelpers.h"
#include "EditorModeInterpolation.h"
#include "PhysicsManipulationMode.h"
#include "PhysicsAssetUtils.h"


#include "Dialogs/Dialogs.h"
#include "Viewports.h"

#include "UnrealEdGlobals.h"

//#include "UnrealEdMessages.h"

#include "EditorAnalytics.h"


#include "Framework/MultiBox/MultiBoxBuilder.h"
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