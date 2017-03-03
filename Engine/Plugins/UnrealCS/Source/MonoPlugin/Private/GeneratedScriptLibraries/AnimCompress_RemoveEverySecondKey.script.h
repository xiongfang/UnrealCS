#pragma once

namespace UnrealEngine
{
	class _UAnimCompress_RemoveEverySecondKey
	{
		static UClass* StaticClass(){return UAnimCompress_RemoveEverySecondKey::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimCompress_RemoveEverySecondKey::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
