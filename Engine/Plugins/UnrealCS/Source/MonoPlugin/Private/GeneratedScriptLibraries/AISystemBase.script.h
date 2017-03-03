#pragma once

namespace UnrealEngine
{
	class _UAISystemBase
	{
		static UClass* StaticClass(){return UAISystemBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAISystemBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
