#pragma once

namespace UnrealEngine
{
	class _UAnimCompress_RemoveTrivialKeys
	{
		static UClass* StaticClass(){return UAnimCompress_RemoveTrivialKeys::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimCompress_RemoveTrivialKeys::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
