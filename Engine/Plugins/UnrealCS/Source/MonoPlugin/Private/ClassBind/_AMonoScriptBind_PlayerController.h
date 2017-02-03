// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once
#include "MonoScriptBind_PlayerController.h"

namespace UnrealEngine
{
	class _AMonoScriptBind_PlayerController
	{
		static UClass* StaticClass()
		{
			return AMonoScriptBind_PlayerController::StaticClass();
		}

	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AMonoPlayerController::StaticClass", (const void*)StaticClass);
		}
	};
}