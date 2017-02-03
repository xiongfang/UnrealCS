// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

namespace UnrealEngine
{
	class _FMulticastScriptDelegate
	{
		static void Add(TMulticastScriptDelegate<FWeakObjectPtr>* _this, UObject* InObject, MonoString* FuncName)
		{
			TScriptDelegate<FWeakObjectPtr> Del;
			Del.BindUFunction(InObject, MonoStringToFName(FuncName));
			_this->Add(Del);
		}
		static void Remove(TMulticastScriptDelegate<FWeakObjectPtr>* _this, UObject* InObject, MonoString* FuncName)
		{
			TScriptDelegate<FWeakObjectPtr> Del;
			Del.BindUFunction(InObject, MonoStringToFName(FuncName));
			_this->Remove(Del);
		}

	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.FMulticastScriptDelegate::Add", (const void*)Add);
			mono_add_internal_call("UnrealEngine.FMulticastScriptDelegate::Remove", (const void*)Remove);
		}
	};
}