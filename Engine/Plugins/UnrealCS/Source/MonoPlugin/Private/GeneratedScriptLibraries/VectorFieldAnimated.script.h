#pragma once

namespace UnrealEngine
{
	class _UVectorFieldAnimated
	{
		static UClass* StaticClass(){return UVectorFieldAnimated::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UVectorFieldAnimated::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
