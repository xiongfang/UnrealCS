// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

namespace UnrealEngine
{
	class _FText
	{
		static MonoString* ToString(FText* Name)
		{
			return FStringToMonoString((*Name).ToString());
		}
		static FText FromString(MonoString* ret)
		{
			return FText::FromString(MonoStringToFString(ret));
		}

	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.FText::ToString", (const void*)ToString);
			mono_add_internal_call("UnrealEngine.FText::FromString", (const void*)FromString);
		}
	};
}