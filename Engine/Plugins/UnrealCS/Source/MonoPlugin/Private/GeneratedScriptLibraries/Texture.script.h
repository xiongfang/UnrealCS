#pragma once

namespace UnrealEngine
{
	class _UTexture
	{
		static UClass* StaticClass(){return UTexture::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UTexture::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
