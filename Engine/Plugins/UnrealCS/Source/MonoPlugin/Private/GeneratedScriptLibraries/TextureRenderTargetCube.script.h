#pragma once

namespace UnrealEngine
{
	class _UTextureRenderTargetCube
	{
		static UClass* StaticClass(){return UTextureRenderTargetCube::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UTextureRenderTargetCube::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
