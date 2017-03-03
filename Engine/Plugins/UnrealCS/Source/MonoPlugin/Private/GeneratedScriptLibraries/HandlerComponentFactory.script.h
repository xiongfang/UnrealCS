#pragma once

namespace UnrealEngine
{
	class _UHandlerComponentFactory
	{
		static UClass* StaticClass(){return UHandlerComponentFactory::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UHandlerComponentFactory::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
