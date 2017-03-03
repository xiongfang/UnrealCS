#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionAntialiasedTextureMask
	{
		static UClass* StaticClass(){return UMaterialExpressionAntialiasedTextureMask::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionAntialiasedTextureMask::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
