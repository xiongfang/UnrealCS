#pragma once

namespace UnrealEngine
{
	class _UAnimCompositeBase
	{
		static UClass* StaticClass(){return UAnimCompositeBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimCompositeBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
