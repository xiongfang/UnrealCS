// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once
namespace UnrealEngine
{
	class _UInputComponent_Ext
	{
		typedef void(*callback_t) ();

		static void BindAction(UInputComponent* _this, MonoString* AxisName, int KeyEvent, UObject* Object, callback_t method)
		{
			//_this->BindAction(MonoStringToFName(AxisName), (const EInputEvent)KeyEvent, Object, method);
		}
	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInputComponent::BindAction", (const void*)BindAction);
		}
	};
}
