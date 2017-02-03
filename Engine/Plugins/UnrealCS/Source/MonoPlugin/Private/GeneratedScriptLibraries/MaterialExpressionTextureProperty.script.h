#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionTextureProperty
	{
		static UClass* StaticClass(){return UMaterialExpressionTextureProperty::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionTextureProperty::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
