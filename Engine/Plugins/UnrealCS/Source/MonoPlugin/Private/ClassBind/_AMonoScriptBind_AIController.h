// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once
#include "MonoScriptBind_AIController.h"

namespace UnrealEngine
{
	class _AMonoScriptBind_AIController
	{
		static UClass* StaticClass()
		{
			return AMonoScriptBind_AIController::StaticClass();
		}

	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AMonoAIController::StaticClass", (const void*)StaticClass);
		}
	};
}
