#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionTextureObject
	{
		static UClass* StaticClass(){return UMaterialExpressionTextureObject::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionTextureObject::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
