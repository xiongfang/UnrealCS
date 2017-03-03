#pragma once

namespace UnrealEngine
{
	class _UBlendSpaceBase
	{
		static UClass* StaticClass(){return UBlendSpaceBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBlendSpaceBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
