#pragma once

namespace UnrealEngine
{
	class _UTextureRenderTarget
	{
		static UClass* StaticClass(){return UTextureRenderTarget::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UTextureRenderTarget::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
