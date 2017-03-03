#pragma once

namespace UnrealEngine
{
	class _USubUVAnimation
	{
		static UClass* StaticClass(){return USubUVAnimation::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USubUVAnimation::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
