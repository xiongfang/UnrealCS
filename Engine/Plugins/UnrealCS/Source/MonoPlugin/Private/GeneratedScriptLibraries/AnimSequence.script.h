#pragma once

namespace UnrealEngine
{
	class _UAnimSequence
	{
		static UClass* StaticClass(){return UAnimSequence::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimSequence::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
