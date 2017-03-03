#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionTextureBase
	{
		static UClass* StaticClass(){return UMaterialExpressionTextureBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionTextureBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
