#pragma once

namespace UnrealEngine
{
	class _AWheeledVehicle
	{
		static UClass* StaticClass(){return AWheeledVehicle::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AWheeledVehicle::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
