#pragma once

namespace UnrealEngine
{
	class _USlateTextureAtlasInterface
	{
		static UClass* StaticClass(){return USlateTextureAtlasInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USlateTextureAtlasInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
