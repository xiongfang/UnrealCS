// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once
#include "MonoScriptBind_Component.h"
namespace UnrealEngine
{
	class _UMonoScriptBind_Component
	{
		static UClass* StaticClass()
		{
			return UMonoScriptBind_Component::StaticClass();
		}

	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMonoActorComponent::StaticClass", (const void*)StaticClass);
		}
	};
}