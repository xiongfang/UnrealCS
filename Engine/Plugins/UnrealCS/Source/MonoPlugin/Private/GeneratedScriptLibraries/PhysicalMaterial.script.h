#pragma once

namespace UnrealEngine
{
	class _UPhysicalMaterial
	{
		static UClass* StaticClass(){return UPhysicalMaterial::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPhysicalMaterial::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
