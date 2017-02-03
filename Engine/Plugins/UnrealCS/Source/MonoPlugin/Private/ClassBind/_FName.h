// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

namespace UnrealEngine
{
	class _FName
	{
		static MonoString* ToString(FName* Name)
		{
			return FNameToMonoString(*Name);
		}
		static FName FromString(MonoString* ret)
		{
			return MonoStringToFName(ret);
		}

	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.FName::ToString", (const void*)ToString);
			mono_add_internal_call("UnrealEngine.FName::FromString", (const void*)FromString);
		}
	};
}