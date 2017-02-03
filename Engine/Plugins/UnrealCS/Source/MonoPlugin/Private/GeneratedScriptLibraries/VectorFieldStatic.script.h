#pragma once

namespace UnrealEngine
{
	class _UVectorFieldStatic
	{
		static UClass* StaticClass(){return UVectorFieldStatic::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UVectorFieldStatic::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
