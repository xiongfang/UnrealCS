#pragma once

namespace UnrealEngine
{
	class _UAnimSet
	{
		static UClass* StaticClass(){return UAnimSet::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimSet::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
