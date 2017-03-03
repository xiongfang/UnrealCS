#pragma once

namespace UnrealEngine
{
	class _UInterpToMovementComponent
	{
		static void FinaliseControlPoints(UInterpToMovementComponent* _this)
		{
			_this->FinaliseControlPoints();
			
		}
		static void RestartMovement(UInterpToMovementComponent* _this,float InitialDirection)
		{
			_this->RestartMovement(InitialDirection);
			
		}
		static void StopSimulating(UInterpToMovementComponent* _this,FHitResult* HitResult)
		{
			_this->StopSimulating(*HitResult);
			
		}
		static UClass* StaticClass(){return UInterpToMovementComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpToMovementComponent::FinaliseControlPoints",(const void*)FinaliseControlPoints);
			mono_add_internal_call("UnrealEngine.UInterpToMovementComponent::RestartMovement",(const void*)RestartMovement);
			mono_add_internal_call("UnrealEngine.UInterpToMovementComponent::StopSimulating",(const void*)StopSimulating);
			mono_add_internal_call("UnrealEngine.UInterpToMovementComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
