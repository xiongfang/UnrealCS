#pragma once

namespace UnrealEngine
{
	class _UNavMovementComponent
	{
		static int32 IsFlying(UNavMovementComponent* _this)
		{
			bool ___ret = _this->IsFlying();
			return ___ret?1:0;
			
		}
		static int32 IsSwimming(UNavMovementComponent* _this)
		{
			bool ___ret = _this->IsSwimming();
			return ___ret?1:0;
			
		}
		static int32 IsMovingOnGround(UNavMovementComponent* _this)
		{
			bool ___ret = _this->IsMovingOnGround();
			return ___ret?1:0;
			
		}
		static int32 IsFalling(UNavMovementComponent* _this)
		{
			bool ___ret = _this->IsFalling();
			return ___ret?1:0;
			
		}
		static int32 IsCrouching(UNavMovementComponent* _this)
		{
			bool ___ret = _this->IsCrouching();
			return ___ret?1:0;
			
		}
		static void StopMovementKeepPathing(UNavMovementComponent* _this)
		{
			_this->StopMovementKeepPathing();
			
		}
		static void StopActiveMovement(UNavMovementComponent* _this)
		{
			_this->StopActiveMovement();
			
		}
		static UClass* StaticClass(){return UNavMovementComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavMovementComponent::IsFlying",(const void*)IsFlying);
			mono_add_internal_call("UnrealEngine.UNavMovementComponent::IsSwimming",(const void*)IsSwimming);
			mono_add_internal_call("UnrealEngine.UNavMovementComponent::IsMovingOnGround",(const void*)IsMovingOnGround);
			mono_add_internal_call("UnrealEngine.UNavMovementComponent::IsFalling",(const void*)IsFalling);
			mono_add_internal_call("UnrealEngine.UNavMovementComponent::IsCrouching",(const void*)IsCrouching);
			mono_add_internal_call("UnrealEngine.UNavMovementComponent::StopMovementKeepPathing",(const void*)StopMovementKeepPathing);
			mono_add_internal_call("UnrealEngine.UNavMovementComponent::StopActiveMovement",(const void*)StopActiveMovement);
			mono_add_internal_call("UnrealEngine.UNavMovementComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
