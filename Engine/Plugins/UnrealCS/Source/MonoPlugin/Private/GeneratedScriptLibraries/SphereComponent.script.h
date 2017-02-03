#pragma once

namespace UnrealEngine
{
	class _USphereComponent
	{
		static float GetShapeScale(USphereComponent* _this)
		{
			float ___ret = _this->GetShapeScale();
			return ___ret;
			
		}
		static float GetUnscaledSphereRadius(USphereComponent* _this)
		{
			float ___ret = _this->GetUnscaledSphereRadius();
			return ___ret;
			
		}
		static float GetScaledSphereRadius(USphereComponent* _this)
		{
			float ___ret = _this->GetScaledSphereRadius();
			return ___ret;
			
		}
		static void SetSphereRadius(USphereComponent* _this,float InSphereRadius,int32 bUpdateOverlaps)
		{
			_this->SetSphereRadius(InSphereRadius,bUpdateOverlaps>0?true:false);
			
		}
		static UClass* StaticClass(){return USphereComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USphereComponent::GetShapeScale",(const void*)GetShapeScale);
			mono_add_internal_call("UnrealEngine.USphereComponent::GetUnscaledSphereRadius",(const void*)GetUnscaledSphereRadius);
			mono_add_internal_call("UnrealEngine.USphereComponent::GetScaledSphereRadius",(const void*)GetScaledSphereRadius);
			mono_add_internal_call("UnrealEngine.USphereComponent::SetSphereRadius",(const void*)SetSphereRadius);
			mono_add_internal_call("UnrealEngine.USphereComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
