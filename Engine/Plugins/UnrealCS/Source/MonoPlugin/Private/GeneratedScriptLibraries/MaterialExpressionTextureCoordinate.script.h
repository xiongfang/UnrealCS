#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionTextureCoordinate
	{
		static UClass* StaticClass(){return UMaterialExpressionTextureCoordinate::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionTextureCoordinate::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
