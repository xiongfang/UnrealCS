#pragma once

namespace UnrealEngine
{
	class _UEdGraphSchema
	{
		static UClass* StaticClass(){return UEdGraphSchema::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UEdGraphSchema::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
