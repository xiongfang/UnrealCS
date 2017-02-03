#pragma once

namespace UnrealEngine
{
	class _UInterpCurveEdSetup
	{
		static UClass* StaticClass(){return UInterpCurveEdSetup::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpCurveEdSetup::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
