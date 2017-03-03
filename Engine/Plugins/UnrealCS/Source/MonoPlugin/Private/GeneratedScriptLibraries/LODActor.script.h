#pragma once

namespace UnrealEngine
{
	class _ALODActor
	{
		static UClass* StaticClass(){return ALODActor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ALODActor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
