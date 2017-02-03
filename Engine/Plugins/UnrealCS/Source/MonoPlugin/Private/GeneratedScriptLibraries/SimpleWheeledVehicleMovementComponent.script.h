#pragma once

namespace UnrealEngine
{
	class _USimpleWheeledVehicleMovementComponent
	{
		static void SetSteerAngle(USimpleWheeledVehicleMovementComponent* _this,float SteerAngle,int32 WheelIndex)
		{
			_this->SetSteerAngle(SteerAngle,WheelIndex);
			
		}
		static void SetDriveTorque(USimpleWheeledVehicleMovementComponent* _this,float DriveTorque,int32 WheelIndex)
		{
			_this->SetDriveTorque(DriveTorque,WheelIndex);
			
		}
		static void SetBrakeTorque(USimpleWheeledVehicleMovementComponent* _this,float BrakeTorque,int32 WheelIndex)
		{
			_this->SetBrakeTorque(BrakeTorque,WheelIndex);
			
		}
		static UClass* StaticClass(){return USimpleWheeledVehicleMovementComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USimpleWheeledVehicleMovementComponent::SetSteerAngle",(const void*)SetSteerAngle);
			mono_add_internal_call("UnrealEngine.USimpleWheeledVehicleMovementComponent::SetDriveTorque",(const void*)SetDriveTorque);
			mono_add_internal_call("UnrealEngine.USimpleWheeledVehicleMovementComponent::SetBrakeTorque",(const void*)SetBrakeTorque);
			mono_add_internal_call("UnrealEngine.USimpleWheeledVehicleMovementComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
