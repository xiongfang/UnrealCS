#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionWorldPosition
	{
		static UClass* StaticClass(){return UMaterialExpressionWorldPosition::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionWorldPosition::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
