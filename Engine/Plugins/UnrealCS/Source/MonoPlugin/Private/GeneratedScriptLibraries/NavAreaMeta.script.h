#pragma once

namespace UnrealEngine
{
	class _UNavAreaMeta
	{
		static UClass* StaticClass(){return UNavAreaMeta::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavAreaMeta::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
