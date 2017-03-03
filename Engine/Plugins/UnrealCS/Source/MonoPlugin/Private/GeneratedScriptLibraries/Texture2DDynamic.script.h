#pragma once

namespace UnrealEngine
{
	class _UTexture2DDynamic
	{
		static UClass* StaticClass(){return UTexture2DDynamic::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UTexture2DDynamic::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
