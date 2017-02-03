#pragma once

namespace UnrealEngine
{
	class _UIntSerialization
	{
		static UClass* StaticClass(){return UIntSerialization::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UIntSerialization::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
