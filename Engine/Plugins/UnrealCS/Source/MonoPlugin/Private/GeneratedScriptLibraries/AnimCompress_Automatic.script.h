#pragma once

namespace UnrealEngine
{
	class _UAnimCompress_Automatic
	{
		static UClass* StaticClass(){return UAnimCompress_Automatic::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimCompress_Automatic::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
