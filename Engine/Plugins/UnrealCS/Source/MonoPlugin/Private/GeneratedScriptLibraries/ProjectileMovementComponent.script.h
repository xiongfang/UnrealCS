#pragma once

namespace UnrealEngine
{
	class _UProjectileMovementComponent
	{
		static void StopSimulating(UProjectileMovementComponent* _this,FHitResult* HitResult)
		{
			_this->StopSimulating(*HitResult);
			
		}
		static void SetVelocityInLocalSpace(UProjectileMovementComponent* _this,FVector* NewVelocity)
		{
			_this->SetVelocityInLocalSpace(*NewVelocity);
			
		}
		static UClass* StaticClass(){return UProjectileMovementComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UProjectileMovementComponent::StopSimulating",(const void*)StopSimulating);
			mono_add_internal_call("UnrealEngine.UProjectileMovementComponent::SetVelocityInLocalSpace",(const void*)SetVelocityInLocalSpace);
			mono_add_internal_call("UnrealEngine.UProjectileMovementComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
