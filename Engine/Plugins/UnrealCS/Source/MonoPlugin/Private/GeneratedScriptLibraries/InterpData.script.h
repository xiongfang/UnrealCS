#pragma once

namespace UnrealEngine
{
	class _UInterpData
	{
		static UClass* StaticClass(){return UInterpData::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpData::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
