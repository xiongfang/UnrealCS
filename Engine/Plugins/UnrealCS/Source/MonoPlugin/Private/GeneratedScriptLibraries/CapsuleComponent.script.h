#pragma once

namespace UnrealEngine
{
	class _UCapsuleComponent
	{
		static float GetShapeScale(UCapsuleComponent* _this)
		{
			float ___ret = _this->GetShapeScale();
			return ___ret;
			
		}
		static void GetUnscaledCapsuleSize_WithoutHemisphere(UCapsuleComponent* _this,float* OutRadius,float* OutHalfHeightWithoutHemisphere)
		{
			_this->GetUnscaledCapsuleSize_WithoutHemisphere(*OutRadius,*OutHalfHeightWithoutHemisphere);
			
		}
		static void GetUnscaledCapsuleSize(UCapsuleComponent* _this,float* OutRadius,float* OutHalfHeight)
		{
			_this->GetUnscaledCapsuleSize(*OutRadius,*OutHalfHeight);
			
		}
		static float GetUnscaledCapsuleHalfHeight_WithoutHemisphere(UCapsuleComponent* _this)
		{
			float ___ret = _this->GetUnscaledCapsuleHalfHeight_WithoutHemisphere();
			return ___ret;
			
		}
		static float GetUnscaledCapsuleHalfHeight(UCapsuleComponent* _this)
		{
			float ___ret = _this->GetUnscaledCapsuleHalfHeight();
			return ___ret;
			
		}
		static float GetUnscaledCapsuleRadius(UCapsuleComponent* _this)
		{
			float ___ret = _this->GetUnscaledCapsuleRadius();
			return ___ret;
			
		}
		static void GetScaledCapsuleSize_WithoutHemisphere(UCapsuleComponent* _this,float* OutRadius,float* OutHalfHeightWithoutHemisphere)
		{
			_this->GetScaledCapsuleSize_WithoutHemisphere(*OutRadius,*OutHalfHeightWithoutHemisphere);
			
		}
		static void GetScaledCapsuleSize(UCapsuleComponent* _this,float* OutRadius,float* OutHalfHeight)
		{
			_this->GetScaledCapsuleSize(*OutRadius,*OutHalfHeight);
			
		}
		static float GetScaledCapsuleHalfHeight_WithoutHemisphere(UCapsuleComponent* _this)
		{
			float ___ret = _this->GetScaledCapsuleHalfHeight_WithoutHemisphere();
			return ___ret;
			
		}
		static float GetScaledCapsuleHalfHeight(UCapsuleComponent* _this)
		{
			float ___ret = _this->GetScaledCapsuleHalfHeight();
			return ___ret;
			
		}
		static float GetScaledCapsuleRadius(UCapsuleComponent* _this)
		{
			float ___ret = _this->GetScaledCapsuleRadius();
			return ___ret;
			
		}
		static void SetCapsuleHalfHeight(UCapsuleComponent* _this,float HalfHeight,int32 bUpdateOverlaps)
		{
			_this->SetCapsuleHalfHeight(HalfHeight,bUpdateOverlaps>0?true:false);
			
		}
		static void SetCapsuleRadius(UCapsuleComponent* _this,float Radius,int32 bUpdateOverlaps)
		{
			_this->SetCapsuleRadius(Radius,bUpdateOverlaps>0?true:false);
			
		}
		static void SetCapsuleSize(UCapsuleComponent* _this,float InRadius,float InHalfHeight,int32 bUpdateOverlaps)
		{
			_this->SetCapsuleSize(InRadius,InHalfHeight,bUpdateOverlaps>0?true:false);
			
		}
		static UClass* StaticClass(){return UCapsuleComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCapsuleComponent::GetShapeScale",(const void*)GetShapeScale);
			mono_add_internal_call("UnrealEngine.UCapsuleComponent::GetUnscaledCapsuleSize_WithoutHemisphere",(const void*)GetUnscaledCapsuleSize_WithoutHemisphere);
			mono_add_internal_call("UnrealEngine.UCapsuleComponent::GetUnscaledCapsuleSize",(const void*)GetUnscaledCapsuleSize);
			mono_add_internal_call("UnrealEngine.UCapsuleComponent::GetUnscaledCapsuleHalfHeight_WithoutHemisphere",(const void*)GetUnscaledCapsuleHalfHeight_WithoutHemisphere);
			mono_add_internal_call("UnrealEngine.UCapsuleComponent::GetUnscaledCapsuleHalfHeight",(const void*)GetUnscaledCapsuleHalfHeight);
			mono_add_internal_call("UnrealEngine.UCapsuleComponent::GetUnscaledCapsuleRadius",(const void*)GetUnscaledCapsuleRadius);
			mono_add_internal_call("UnrealEngine.UCapsuleComponent::GetScaledCapsuleSize_WithoutHemisphere",(const void*)GetScaledCapsuleSize_WithoutHemisphere);
			mono_add_internal_call("UnrealEngine.UCapsuleComponent::GetScaledCapsuleSize",(const void*)GetScaledCapsuleSize);
			mono_add_internal_call("UnrealEngine.UCapsuleComponent::GetScaledCapsuleHalfHeight_WithoutHemisphere",(const void*)GetScaledCapsuleHalfHeight_WithoutHemisphere);
			mono_add_internal_call("UnrealEngine.UCapsuleComponent::GetScaledCapsuleHalfHeight",(const void*)GetScaledCapsuleHalfHeight);
			mono_add_internal_call("UnrealEngine.UCapsuleComponent::GetScaledCapsuleRadius",(const void*)GetScaledCapsuleRadius);
			mono_add_internal_call("UnrealEngine.UCapsuleComponent::SetCapsuleHalfHeight",(const void*)SetCapsuleHalfHeight);
			mono_add_internal_call("UnrealEngine.UCapsuleComponent::SetCapsuleRadius",(const void*)SetCapsuleRadius);
			mono_add_internal_call("UnrealEngine.UCapsuleComponent::SetCapsuleSize",(const void*)SetCapsuleSize);
			mono_add_internal_call("UnrealEngine.UCapsuleComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
