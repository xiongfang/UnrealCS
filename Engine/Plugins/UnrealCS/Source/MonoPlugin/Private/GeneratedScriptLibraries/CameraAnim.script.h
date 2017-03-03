#pragma once

namespace UnrealEngine
{
	class _UCameraAnim
	{
		static UClass* StaticClass(){return UCameraAnim::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCameraAnim::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
