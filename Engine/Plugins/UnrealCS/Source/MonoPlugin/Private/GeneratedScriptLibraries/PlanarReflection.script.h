#pragma once

namespace UnrealEngine
{
	class _APlanarReflection
	{
		static UClass* StaticClass(){return APlanarReflection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.APlanarReflection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
