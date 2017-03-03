#pragma once

namespace UnrealEngine
{
	class _UTableViewBase
	{
		static UClass* StaticClass(){return UTableViewBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UTableViewBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
