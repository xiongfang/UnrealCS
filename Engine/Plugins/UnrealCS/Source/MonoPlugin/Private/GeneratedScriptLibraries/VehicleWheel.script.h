#pragma once

namespace UnrealEngine
{
	class _UVehicleWheel
	{
		static float GetSuspensionOffset(UVehicleWheel* _this)
		{
			float ___ret = _this->GetSuspensionOffset();
			return ___ret;
			
		}
		static float GetRotationAngle(UVehicleWheel* _this)
		{
			float ___ret = _this->GetRotationAngle();
			return ___ret;
			
		}
		static float GetSteerAngle(UVehicleWheel* _this)
		{
			float ___ret = _this->GetSteerAngle();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UVehicleWheel::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UVehicleWheel::GetSuspensionOffset",(const void*)GetSuspensionOffset);
			mono_add_internal_call("UnrealEngine.UVehicleWheel::GetRotationAngle",(const void*)GetRotationAngle);
			mono_add_internal_call("UnrealEngine.UVehicleWheel::GetSteerAngle",(const void*)GetSteerAngle);
			mono_add_internal_call("UnrealEngine.UVehicleWheel::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
