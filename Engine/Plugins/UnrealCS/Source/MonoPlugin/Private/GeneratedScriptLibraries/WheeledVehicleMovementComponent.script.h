#pragma once

namespace UnrealEngine
{
	class _UWheeledVehicleMovementComponent
	{
		static void SetAvoidanceEnabled(UWheeledVehicleMovementComponent* _this,int32 bEnable)
		{
			_this->SetAvoidanceEnabled(bEnable>0?true:false);
			
		}
		static void SetGroupsToIgnore(UWheeledVehicleMovementComponent* _this,int32 GroupFlags)
		{
			_this->SetGroupsToIgnore(GroupFlags);
			
		}
		static void SetGroupsToAvoid(UWheeledVehicleMovementComponent* _this,int32 GroupFlags)
		{
			_this->SetGroupsToAvoid(GroupFlags);
			
		}
		static void SetAvoidanceGroup(UWheeledVehicleMovementComponent* _this,int32 GroupFlags)
		{
			_this->SetAvoidanceGroup(GroupFlags);
			
		}
		static int32 GetUseAutoGears(UWheeledVehicleMovementComponent* _this)
		{
			bool ___ret = _this->GetUseAutoGears();
			return ___ret?1:0;
			
		}
		static int32 GetTargetGear(UWheeledVehicleMovementComponent* _this)
		{
			int32 ___ret = _this->GetTargetGear();
			return ___ret;
			
		}
		static int32 GetCurrentGear(UWheeledVehicleMovementComponent* _this)
		{
			int32 ___ret = _this->GetCurrentGear();
			return ___ret;
			
		}
		static float GetEngineMaxRotationSpeed(UWheeledVehicleMovementComponent* _this)
		{
			float ___ret = _this->GetEngineMaxRotationSpeed();
			return ___ret;
			
		}
		static float GetEngineRotationSpeed(UWheeledVehicleMovementComponent* _this)
		{
			float ___ret = _this->GetEngineRotationSpeed();
			return ___ret;
			
		}
		static float GetForwardSpeed(UWheeledVehicleMovementComponent* _this)
		{
			float ___ret = _this->GetForwardSpeed();
			return ___ret;
			
		}
		static void SetUseAutoGears(UWheeledVehicleMovementComponent* _this,int32 bUseAuto)
		{
			_this->SetUseAutoGears(bUseAuto>0?true:false);
			
		}
		static void SetTargetGear(UWheeledVehicleMovementComponent* _this,int32 GearNum,int32 bImmediate)
		{
			_this->SetTargetGear(GearNum,bImmediate>0?true:false);
			
		}
		static void SetGearDown(UWheeledVehicleMovementComponent* _this,int32 bNewGearDown)
		{
			_this->SetGearDown(bNewGearDown>0?true:false);
			
		}
		static void SetGearUp(UWheeledVehicleMovementComponent* _this,int32 bNewGearUp)
		{
			_this->SetGearUp(bNewGearUp>0?true:false);
			
		}
		static void SetHandbrakeInput(UWheeledVehicleMovementComponent* _this,int32 bNewHandbrake)
		{
			_this->SetHandbrakeInput(bNewHandbrake>0?true:false);
			
		}
		static void SetSteeringInput(UWheeledVehicleMovementComponent* _this,float Steering)
		{
			_this->SetSteeringInput(Steering);
			
		}
		static void SetThrottleInput(UWheeledVehicleMovementComponent* _this,float Throttle)
		{
			_this->SetThrottleInput(Throttle);
			
		}
		static UClass* StaticClass(){return UWheeledVehicleMovementComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWheeledVehicleMovementComponent::SetAvoidanceEnabled",(const void*)SetAvoidanceEnabled);
			mono_add_internal_call("UnrealEngine.UWheeledVehicleMovementComponent::SetGroupsToIgnore",(const void*)SetGroupsToIgnore);
			mono_add_internal_call("UnrealEngine.UWheeledVehicleMovementComponent::SetGroupsToAvoid",(const void*)SetGroupsToAvoid);
			mono_add_internal_call("UnrealEngine.UWheeledVehicleMovementComponent::SetAvoidanceGroup",(const void*)SetAvoidanceGroup);
			mono_add_internal_call("UnrealEngine.UWheeledVehicleMovementComponent::GetUseAutoGears",(const void*)GetUseAutoGears);
			mono_add_internal_call("UnrealEngine.UWheeledVehicleMovementComponent::GetTargetGear",(const void*)GetTargetGear);
			mono_add_internal_call("UnrealEngine.UWheeledVehicleMovementComponent::GetCurrentGear",(const void*)GetCurrentGear);
			mono_add_internal_call("UnrealEngine.UWheeledVehicleMovementComponent::GetEngineMaxRotationSpeed",(const void*)GetEngineMaxRotationSpeed);
			mono_add_internal_call("UnrealEngine.UWheeledVehicleMovementComponent::GetEngineRotationSpeed",(const void*)GetEngineRotationSpeed);
			mono_add_internal_call("UnrealEngine.UWheeledVehicleMovementComponent::GetForwardSpeed",(const void*)GetForwardSpeed);
			mono_add_internal_call("UnrealEngine.UWheeledVehicleMovementComponent::SetUseAutoGears",(const void*)SetUseAutoGears);
			mono_add_internal_call("UnrealEngine.UWheeledVehicleMovementComponent::SetTargetGear",(const void*)SetTargetGear);
			mono_add_internal_call("UnrealEngine.UWheeledVehicleMovementComponent::SetGearDown",(const void*)SetGearDown);
			mono_add_internal_call("UnrealEngine.UWheeledVehicleMovementComponent::SetGearUp",(const void*)SetGearUp);
			mono_add_internal_call("UnrealEngine.UWheeledVehicleMovementComponent::SetHandbrakeInput",(const void*)SetHandbrakeInput);
			mono_add_internal_call("UnrealEngine.UWheeledVehicleMovementComponent::SetSteeringInput",(const void*)SetSteeringInput);
			mono_add_internal_call("UnrealEngine.UWheeledVehicleMovementComponent::SetThrottleInput",(const void*)SetThrottleInput);
			mono_add_internal_call("UnrealEngine.UWheeledVehicleMovementComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
