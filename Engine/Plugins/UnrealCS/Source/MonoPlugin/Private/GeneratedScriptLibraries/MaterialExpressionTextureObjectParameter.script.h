#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionTextureObjectParameter
	{
		static UClass* StaticClass(){return UMaterialExpressionTextureObjectParameter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionTextureObjectParameter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
