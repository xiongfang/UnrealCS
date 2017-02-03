#pragma once

namespace UnrealEngine
{
	class _UNavPathObserverInterface
	{
		static UClass* StaticClass(){return UNavPathObserverInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavPathObserverInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
