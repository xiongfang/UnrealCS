#pragma once

namespace UnrealEngine
{
	class _UShadowMapTexture2D
	{
		static UClass* StaticClass(){return UShadowMapTexture2D::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UShadowMapTexture2D::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
