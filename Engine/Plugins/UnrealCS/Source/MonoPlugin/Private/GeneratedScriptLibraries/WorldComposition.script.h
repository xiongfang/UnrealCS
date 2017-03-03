#pragma once

namespace UnrealEngine
{
	class _UWorldComposition
	{
		static UClass* StaticClass(){return UWorldComposition::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWorldComposition::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
