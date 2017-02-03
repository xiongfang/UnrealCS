#pragma once

namespace UnrealEngine
{
	class _UTireType
	{
		static UClass* StaticClass(){return UTireType::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UTireType::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
