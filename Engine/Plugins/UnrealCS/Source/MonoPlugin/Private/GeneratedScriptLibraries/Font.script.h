#pragma once

namespace UnrealEngine
{
	class _UFont
	{
		static UClass* StaticClass(){return UFont::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UFont::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
