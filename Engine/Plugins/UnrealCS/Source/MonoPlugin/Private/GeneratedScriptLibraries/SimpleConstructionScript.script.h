#pragma once

namespace UnrealEngine
{
	class _USimpleConstructionScript
	{
		static UClass* StaticClass(){return USimpleConstructionScript::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USimpleConstructionScript::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
