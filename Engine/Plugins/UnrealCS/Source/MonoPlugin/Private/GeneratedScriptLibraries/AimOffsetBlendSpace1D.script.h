#pragma once

namespace UnrealEngine
{
	class _UAimOffsetBlendSpace1D
	{
		static UClass* StaticClass(){return UAimOffsetBlendSpace1D::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAimOffsetBlendSpace1D::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
