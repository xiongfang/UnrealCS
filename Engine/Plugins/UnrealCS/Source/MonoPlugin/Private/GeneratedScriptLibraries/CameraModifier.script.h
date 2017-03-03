#pragma once

namespace UnrealEngine
{
	class _UCameraModifier
	{
		static void EnableModifier(UCameraModifier* _this)
		{
			_this->EnableModifier();
			
		}
		static void DisableModifier(UCameraModifier* _this,int32 bImmediate)
		{
			_this->DisableModifier(bImmediate>0?true:false);
			
		}
		static AActor* GetViewTarget(UCameraModifier* _this)
		{
			AActor* ___ret = _this->GetViewTarget();
			return ___ret;
			
		}
		static int32 IsDisabled(UCameraModifier* _this)
		{
			bool ___ret = _this->IsDisabled();
			return ___ret?1:0;
			
		}
		static UClass* StaticClass(){return UCameraModifier::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCameraModifier::EnableModifier",(const void*)EnableModifier);
			mono_add_internal_call("UnrealEngine.UCameraModifier::DisableModifier",(const void*)DisableModifier);
			mono_add_internal_call("UnrealEngine.UCameraModifier::GetViewTarget",(const void*)GetViewTarget);
			mono_add_internal_call("UnrealEngine.UCameraModifier::IsDisabled",(const void*)IsDisabled);
			mono_add_internal_call("UnrealEngine.UCameraModifier::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
