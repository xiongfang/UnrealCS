// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

namespace UnrealEngine
{
	class _FWeakObjectPtr
	{
		static int IsValid(FWeakObjectPtr* _this)
		{
			return _this->IsValid() ? 1 : 0;
		}

		static void Reset(FWeakObjectPtr* _this)
		{
			_this->Reset();
		}

		static void Set(FWeakObjectPtr* _this, UObject* Obj)
		{
			*_this = Obj;
		}
		static UObject* Get(FWeakObjectPtr* _this)
		{
            return _this->Get();
		}
	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.FWeakObjectPtr::IsValid", (const void*)IsValid);
			mono_add_internal_call("UnrealEngine.FWeakObjectPtr::Reset", (const void*)Reset);
			mono_add_internal_call("UnrealEngine.FWeakObjectPtr::Set", (const void*)Set);
			mono_add_internal_call("UnrealEngine.FWeakObjectPtr::Get", (const void*)Get);
		}
	};
}
