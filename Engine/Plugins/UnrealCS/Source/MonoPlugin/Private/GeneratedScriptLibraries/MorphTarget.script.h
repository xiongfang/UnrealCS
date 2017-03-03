#pragma once

namespace UnrealEngine
{
	class _UMorphTarget
	{
		static UClass* StaticClass(){return UMorphTarget::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMorphTarget::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
