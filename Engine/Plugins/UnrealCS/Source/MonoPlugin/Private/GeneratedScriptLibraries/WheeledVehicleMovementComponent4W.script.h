#pragma once

namespace UnrealEngine
{
	class _UWheeledVehicleMovementComponent4W
	{
		static UClass* StaticClass(){return UWheeledVehicleMovementComponent4W::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWheeledVehicleMovementComponent4W::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
