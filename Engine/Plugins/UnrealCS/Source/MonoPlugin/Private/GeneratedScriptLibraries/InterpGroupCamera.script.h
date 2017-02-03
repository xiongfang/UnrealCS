#pragma once

namespace UnrealEngine
{
	class _UInterpGroupCamera
	{
		static UClass* StaticClass(){return UInterpGroupCamera::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpGroupCamera::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
