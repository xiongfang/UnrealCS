#pragma once

namespace UnrealEngine
{
	class _UTextureCube
	{
		static UClass* StaticClass(){return UTextureCube::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UTextureCube::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
