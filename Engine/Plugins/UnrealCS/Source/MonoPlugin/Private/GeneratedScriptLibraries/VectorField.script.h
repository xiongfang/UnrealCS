#pragma once

namespace UnrealEngine
{
	class _UVectorField
	{
		static UClass* StaticClass(){return UVectorField::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UVectorField::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
