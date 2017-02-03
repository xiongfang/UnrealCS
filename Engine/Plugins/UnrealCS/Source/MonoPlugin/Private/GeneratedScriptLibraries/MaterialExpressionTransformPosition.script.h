#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionTransformPosition
	{
		static UClass* StaticClass(){return UMaterialExpressionTransformPosition::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionTransformPosition::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
