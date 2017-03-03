#pragma once

namespace UnrealEngine
{
	class _UInterpTrackVectorMaterialParam
	{
		static UClass* StaticClass(){return UInterpTrackVectorMaterialParam::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackVectorMaterialParam::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
