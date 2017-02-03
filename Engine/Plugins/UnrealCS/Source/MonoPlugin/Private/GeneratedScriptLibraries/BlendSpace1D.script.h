#pragma once

namespace UnrealEngine
{
	class _UBlendSpace1D
	{
		static UClass* StaticClass(){return UBlendSpace1D::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBlendSpace1D::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
