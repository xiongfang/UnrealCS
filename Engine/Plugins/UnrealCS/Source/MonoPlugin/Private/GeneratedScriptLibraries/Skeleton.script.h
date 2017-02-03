#pragma once

namespace UnrealEngine
{
	class _USkeleton
	{
		static UClass* StaticClass(){return USkeleton::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USkeleton::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
