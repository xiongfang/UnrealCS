#pragma once

namespace UnrealEngine
{
	class _UAnimCompress_RemoveLinearKeys
	{
		static UClass* StaticClass(){return UAnimCompress_RemoveLinearKeys::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimCompress_RemoveLinearKeys::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
