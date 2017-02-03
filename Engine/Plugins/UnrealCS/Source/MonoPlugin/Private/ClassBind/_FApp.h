// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once
namespace UnrealEngine
{
	class _FApp
	{
		static void AddTickableObject(MonoObject* obj)
		{
			FMonoDomain::Get()->AddTickableObject(obj);
		}
		static void RemoveTickableObject(MonoObject* obj)
		{
			FMonoDomain::Get()->RemoveTickableObject(obj);
		}
		static MonoString* GetGameName()
		{
			return FStringToMonoString(FApp::GetGameName());
		}
	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.FApp::AddTickableObject", (const void*)AddTickableObject);
			mono_add_internal_call("UnrealEngine.FApp::RemoveTickableObject", (const void*)RemoveTickableObject);
			mono_add_internal_call("UnrealEngine.FApp::GetGameName", (const void*)GetGameName);
		}
	};
}
