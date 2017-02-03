#pragma once

namespace UnrealEngine
{
	class _UAnimCompress_BitwiseCompressOnly
	{
		static UClass* StaticClass(){return UAnimCompress_BitwiseCompressOnly::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimCompress_BitwiseCompressOnly::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
