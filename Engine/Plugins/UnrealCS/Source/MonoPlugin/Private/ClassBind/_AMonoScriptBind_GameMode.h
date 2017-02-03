// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once
#include "MonoScriptBind_GameMode.h"
namespace UnrealEngine
{

	class _AMonoScriptBind_GameMode
	{
		static UClass* StaticClass()
		{
			return AMonoScriptBind_GameMode::StaticClass();
		}

	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AMonoGameMode::StaticClass", (const void*)StaticClass);
		}
	};
}