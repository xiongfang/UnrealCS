#pragma once

namespace UnrealEngine
{
	class _UDamageType
	{
		static UClass* StaticClass(){return UDamageType::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDamageType::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
