#pragma once

namespace UnrealEngine
{
	class _UCheckedStateBinding
	{
		static UClass* StaticClass(){return UCheckedStateBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCheckedStateBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
