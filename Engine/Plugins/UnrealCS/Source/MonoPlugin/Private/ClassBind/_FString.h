// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

namespace UnrealEngine
{
	class _FString
	{
		static MonoString* ToString(FString* Str)
		{
			return FStringToMonoString(*Str);
		}
		static FString FromString(MonoString* ret)
		{
			return MonoStringToFString(ret);
		}

	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.FString::ToString", (const void*)ToString);
			mono_add_internal_call("UnrealEngine.FString::FromString", (const void*)FromString);
		}
	};
}