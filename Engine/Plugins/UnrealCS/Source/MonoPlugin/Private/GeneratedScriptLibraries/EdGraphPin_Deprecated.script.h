#pragma once

namespace UnrealEngine
{
	class _UEdGraphPin_Deprecated
	{
		static UClass* StaticClass(){return UEdGraphPin_Deprecated::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UEdGraphPin_Deprecated::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
