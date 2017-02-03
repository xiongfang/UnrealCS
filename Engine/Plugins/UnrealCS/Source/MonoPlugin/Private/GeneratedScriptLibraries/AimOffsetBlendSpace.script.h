#pragma once

namespace UnrealEngine
{
	class _UAimOffsetBlendSpace
	{
		static UClass* StaticClass(){return UAimOffsetBlendSpace::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAimOffsetBlendSpace::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
