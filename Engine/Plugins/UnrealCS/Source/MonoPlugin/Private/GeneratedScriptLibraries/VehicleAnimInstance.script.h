#pragma once

namespace UnrealEngine
{
	class _UVehicleAnimInstance
	{
		static AWheeledVehicle* GetVehicle(UVehicleAnimInstance* _this)
		{
			AWheeledVehicle* ___ret = _this->GetVehicle();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UVehicleAnimInstance::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UVehicleAnimInstance::GetVehicle",(const void*)GetVehicle);
			mono_add_internal_call("UnrealEngine.UVehicleAnimInstance::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
