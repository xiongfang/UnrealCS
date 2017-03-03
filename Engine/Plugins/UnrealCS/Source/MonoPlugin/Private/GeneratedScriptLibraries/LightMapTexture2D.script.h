#pragma once

namespace UnrealEngine
{
	class _ULightMapTexture2D
	{
		static UClass* StaticClass(){return ULightMapTexture2D::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ULightMapTexture2D::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
