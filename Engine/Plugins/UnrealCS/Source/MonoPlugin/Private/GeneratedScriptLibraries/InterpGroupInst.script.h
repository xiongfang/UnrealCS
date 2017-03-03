#pragma once

namespace UnrealEngine
{
	class _UInterpGroupInst
	{
		static UClass* StaticClass(){return UInterpGroupInst::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpGroupInst::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
