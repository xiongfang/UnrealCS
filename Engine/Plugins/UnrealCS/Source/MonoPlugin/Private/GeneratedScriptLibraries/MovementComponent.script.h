#pragma once

namespace UnrealEngine
{
	class _UMovementComponent
	{
		static void SnapUpdatedComponentToPlane(UMovementComponent* _this)
		{
			_this->SnapUpdatedComponentToPlane();
			
		}
		static FVector ConstrainNormalToPlane(UMovementComponent* _this,FVector* Normal)
		{
			FVector ___ret = _this->ConstrainNormalToPlane(*Normal);
			return ___ret;
			
		}
		static FVector ConstrainLocationToPlane(UMovementComponent* _this,FVector* Location)
		{
			FVector ___ret = _this->ConstrainLocationToPlane(*Location);
			return ___ret;
			
		}
		static FVector ConstrainDirectionToPlane(UMovementComponent* _this,FVector* Direction)
		{
			FVector ___ret = _this->ConstrainDirectionToPlane(*Direction);
			return ___ret;
			
		}
		static FVector GetPlaneConstraintOrigin(UMovementComponent* _this)
		{
			FVector ___ret = _this->GetPlaneConstraintOrigin();
			return ___ret;
			
		}
		static FVector GetPlaneConstraintNormal(UMovementComponent* _this)
		{
			FVector ___ret = _this->GetPlaneConstraintNormal();
			return ___ret;
			
		}
		static void SetPlaneConstraintEnabled(UMovementComponent* _this,int32 bEnabled)
		{
			_this->SetPlaneConstraintEnabled(bEnabled>0?true:false);
			
		}
		static void SetPlaneConstraintOrigin(UMovementComponent* _this,FVector* PlaneOrigin)
		{
			_this->SetPlaneConstraintOrigin(*PlaneOrigin);
			
		}
		static void SetPlaneConstraintFromVectors(UMovementComponent* _this,FVector* Forward,FVector* Up)
		{
			_this->SetPlaneConstraintFromVectors(*Forward,*Up);
			
		}
		static void SetPlaneConstraintNormal(UMovementComponent* _this,FVector* PlaneNormal)
		{
			_this->SetPlaneConstraintNormal(*PlaneNormal);
			
		}
		static int32 K2_MoveUpdatedComponent(UMovementComponent* _this,FVector* Delta,FRotator* NewRotation,FHitResult* OutHit,int32 bSweep,int32 bTeleport)
		{
			bool ___ret = _this->K2_MoveUpdatedComponent(*Delta,*NewRotation,*OutHit,bSweep>0?true:false,bTeleport>0?true:false);
			return ___ret?1:0;
			
		}
		static void SetUpdatedComponent(UMovementComponent* _this,USceneComponent* NewUpdatedComponent)
		{
			_this->SetUpdatedComponent(NewUpdatedComponent);
			
		}
		static void PhysicsVolumeChanged(UMovementComponent* _this,APhysicsVolume* NewVolume)
		{
			_this->PhysicsVolumeChanged(NewVolume);
			
		}
		static APhysicsVolume* GetPhysicsVolume(UMovementComponent* _this)
		{
			APhysicsVolume* ___ret = _this->GetPhysicsVolume();
			return ___ret;
			
		}
		static void StopMovementImmediately(UMovementComponent* _this)
		{
			_this->StopMovementImmediately();
			
		}
		static int32 IsExceedingMaxSpeed(UMovementComponent* _this,float MaxSpeed)
		{
			bool ___ret = _this->IsExceedingMaxSpeed(MaxSpeed);
			return ___ret?1:0;
			
		}
		static float K2_GetModifiedMaxSpeed(UMovementComponent* _this)
		{
			float ___ret = _this->K2_GetModifiedMaxSpeed();
			return ___ret;
			
		}
		static float GetMaxSpeed(UMovementComponent* _this)
		{
			float ___ret = _this->GetMaxSpeed();
			return ___ret;
			
		}
		static float GetGravityZ(UMovementComponent* _this)
		{
			float ___ret = _this->GetGravityZ();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UMovementComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovementComponent::SnapUpdatedComponentToPlane",(const void*)SnapUpdatedComponentToPlane);
			mono_add_internal_call("UnrealEngine.UMovementComponent::ConstrainNormalToPlane",(const void*)ConstrainNormalToPlane);
			mono_add_internal_call("UnrealEngine.UMovementComponent::ConstrainLocationToPlane",(const void*)ConstrainLocationToPlane);
			mono_add_internal_call("UnrealEngine.UMovementComponent::ConstrainDirectionToPlane",(const void*)ConstrainDirectionToPlane);
			mono_add_internal_call("UnrealEngine.UMovementComponent::GetPlaneConstraintOrigin",(const void*)GetPlaneConstraintOrigin);
			mono_add_internal_call("UnrealEngine.UMovementComponent::GetPlaneConstraintNormal",(const void*)GetPlaneConstraintNormal);
			mono_add_internal_call("UnrealEngine.UMovementComponent::SetPlaneConstraintEnabled",(const void*)SetPlaneConstraintEnabled);
			mono_add_internal_call("UnrealEngine.UMovementComponent::SetPlaneConstraintOrigin",(const void*)SetPlaneConstraintOrigin);
			mono_add_internal_call("UnrealEngine.UMovementComponent::SetPlaneConstraintFromVectors",(const void*)SetPlaneConstraintFromVectors);
			mono_add_internal_call("UnrealEngine.UMovementComponent::SetPlaneConstraintNormal",(const void*)SetPlaneConstraintNormal);
			mono_add_internal_call("UnrealEngine.UMovementComponent::K2_MoveUpdatedComponent",(const void*)K2_MoveUpdatedComponent);
			mono_add_internal_call("UnrealEngine.UMovementComponent::SetUpdatedComponent",(const void*)SetUpdatedComponent);
			mono_add_internal_call("UnrealEngine.UMovementComponent::PhysicsVolumeChanged",(const void*)PhysicsVolumeChanged);
			mono_add_internal_call("UnrealEngine.UMovementComponent::GetPhysicsVolume",(const void*)GetPhysicsVolume);
			mono_add_internal_call("UnrealEngine.UMovementComponent::StopMovementImmediately",(const void*)StopMovementImmediately);
			mono_add_internal_call("UnrealEngine.UMovementComponent::IsExceedingMaxSpeed",(const void*)IsExceedingMaxSpeed);
			mono_add_internal_call("UnrealEngine.UMovementComponent::K2_GetModifiedMaxSpeed",(const void*)K2_GetModifiedMaxSpeed);
			mono_add_internal_call("UnrealEngine.UMovementComponent::GetMaxSpeed",(const void*)GetMaxSpeed);
			mono_add_internal_call("UnrealEngine.UMovementComponent::GetGravityZ",(const void*)GetGravityZ);
			mono_add_internal_call("UnrealEngine.UMovementComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
