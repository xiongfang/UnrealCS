#pragma once

namespace UnrealEngine
{
	class _UAnimCompress
	{
		static UClass* StaticClass(){return UAnimCompress::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimCompress::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
