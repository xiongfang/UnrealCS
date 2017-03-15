// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

#include "Headers_Core.h"
#include "Headers_CoreUObject.h"
#include "Headers_Engine.h"

#include "IMonoPlugin.h"




#include "ModuleManager.h"
#include "Engine/EngineTypes.h"
#include "Tickable.h"

#if WITH_EDITOR
#include "Editor.h"
#endif

#if WITH_MONO

#if WITH_EDITOR
#define WITH_MONO_HOTRELOAD 1
#else
#define WITH_MONO_HOTRELOAD 0
#endif

#ifdef _MSC_VER
#pragma warning(push)
#pragma warning(disable:4510) // disable "default constructor could not be generated" - triggered by C style struct defs
#pragma warning(disable:4610) // disable "struct can never be instantiated" - triggered by C style struct defs
#endif

#if PLATFORM_WINDOWS
#pragma pack(push,8)
#endif // PLATFORM_WINDOWS

// Bump this when we upgrade mono, to force a recompile
// MONO_REBUILD_BUMP 3

#include <mono/jit/jit.h>
#include <mono/metadata/assembly.h>
#include <mono/metadata/debug-helpers.h>
#include <mono/metadata/exception.h>
#include <mono/metadata/mono-gc.h>
#include <mono/metadata/mono-debug.h>
#include <mono/metadata/threads.h>
#include <mono/utils/mono-logger.h>
#include <mono/metadata/attrdefs.h>

#if PLATFORM_WINDOWS
#pragma pack(pop)
#endif

#ifdef _MSC_VER
#pragma warning(pop)
#endif

DECLARE_LOG_CATEGORY_EXTERN(LogMono, Log, All);

#define MONO_UE4_NAMESPACE "UnrealEngine"
#define MONO_GAME_NAMESPACE "Game"


#include "MonoScriptClass.h"
#include "MonoDomain.h"

#endif
