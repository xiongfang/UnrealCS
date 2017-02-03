#pragma once

namespace UnrealEngine
{
	class _UAnimMontage
	{
		static UClass* StaticClass(){return UAnimMontage::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimMontage::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
