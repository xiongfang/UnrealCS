#pragma once

namespace UnrealEngine
{
	class _UPhysicsHandleComponent
	{
		static void SetInterpolationSpeed(UPhysicsHandleComponent* _this,float NewInterpolationSpeed)
		{
			_this->SetInterpolationSpeed(NewInterpolationSpeed);
			
		}
		static void SetAngularStiffness(UPhysicsHandleComponent* _this,float NewAngularStiffness)
		{
			_this->SetAngularStiffness(NewAngularStiffness);
			
		}
		static void SetAngularDamping(UPhysicsHandleComponent* _this,float NewAngularDamping)
		{
			_this->SetAngularDamping(NewAngularDamping);
			
		}
		static void SetLinearStiffness(UPhysicsHandleComponent* _this,float NewLinearStiffness)
		{
			_this->SetLinearStiffness(NewLinearStiffness);
			
		}
		static void SetLinearDamping(UPhysicsHandleComponent* _this,float NewLinearDamping)
		{
			_this->SetLinearDamping(NewLinearDamping);
			
		}
		static void GetTargetLocationAndRotation(UPhysicsHandleComponent* _this,FVector* TargetLocation,FRotator* TargetRotation)
		{
			_this->GetTargetLocationAndRotation(*TargetLocation,*TargetRotation);
			
		}
		static void SetTargetLocationAndRotation(UPhysicsHandleComponent* _this,FVector* NewLocation,FRotator* NewRotation)
		{
			_this->SetTargetLocationAndRotation(*NewLocation,*NewRotation);
			
		}
		static void SetTargetRotation(UPhysicsHandleComponent* _this,FRotator* NewRotation)
		{
			_this->SetTargetRotation(*NewRotation);
			
		}
		static void SetTargetLocation(UPhysicsHandleComponent* _this,FVector* NewLocation)
		{
			_this->SetTargetLocation(*NewLocation);
			
		}
		static void ReleaseComponent(UPhysicsHandleComponent* _this)
		{
			_this->ReleaseComponent();
			
		}
		static void GrabComponent(UPhysicsHandleComponent* _this,UPrimitiveComponent* Component,MonoString* InBoneName,FVector* GrabLocation,int32 bConstrainRotation)
		{
			FName InBoneName_temp=MonoStringToFName(InBoneName);
			_this->GrabComponent(Component,InBoneName_temp,*GrabLocation,bConstrainRotation>0?true:false);
			
		}
		static UClass* StaticClass(){return UPhysicsHandleComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPhysicsHandleComponent::SetInterpolationSpeed",(const void*)SetInterpolationSpeed);
			mono_add_internal_call("UnrealEngine.UPhysicsHandleComponent::SetAngularStiffness",(const void*)SetAngularStiffness);
			mono_add_internal_call("UnrealEngine.UPhysicsHandleComponent::SetAngularDamping",(const void*)SetAngularDamping);
			mono_add_internal_call("UnrealEngine.UPhysicsHandleComponent::SetLinearStiffness",(const void*)SetLinearStiffness);
			mono_add_internal_call("UnrealEngine.UPhysicsHandleComponent::SetLinearDamping",(const void*)SetLinearDamping);
			mono_add_internal_call("UnrealEngine.UPhysicsHandleComponent::GetTargetLocationAndRotation",(const void*)GetTargetLocationAndRotation);
			mono_add_internal_call("UnrealEngine.UPhysicsHandleComponent::SetTargetLocationAndRotation",(const void*)SetTargetLocationAndRotation);
			mono_add_internal_call("UnrealEngine.UPhysicsHandleComponent::SetTargetRotation",(const void*)SetTargetRotation);
			mono_add_internal_call("UnrealEngine.UPhysicsHandleComponent::SetTargetLocation",(const void*)SetTargetLocation);
			mono_add_internal_call("UnrealEngine.UPhysicsHandleComponent::ReleaseComponent",(const void*)ReleaseComponent);
			mono_add_internal_call("UnrealEngine.UPhysicsHandleComponent::GrabComponent",(const void*)GrabComponent);
			mono_add_internal_call("UnrealEngine.UPhysicsHandleComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
