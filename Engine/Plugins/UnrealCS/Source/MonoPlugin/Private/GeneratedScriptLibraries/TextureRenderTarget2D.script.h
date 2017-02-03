#pragma once

namespace UnrealEngine
{
	class _UTextureRenderTarget2D
	{
		static UClass* StaticClass(){return UTextureRenderTarget2D::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UTextureRenderTarget2D::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
