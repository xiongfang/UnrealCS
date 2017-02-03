// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once
#include "MonoScriptBind_Character.h"
namespace UnrealEngine
{
	class _AMonoScriptBind_Character
	{
		static UClass* StaticClass()
		{
			return AMonoScriptBind_Character::StaticClass();
		}

	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AMonoCharacter::StaticClass", (const void*)StaticClass);
		}
	};
}
