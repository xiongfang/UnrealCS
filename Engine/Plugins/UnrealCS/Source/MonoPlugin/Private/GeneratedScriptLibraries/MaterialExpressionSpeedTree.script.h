#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionSpeedTree
	{
		static UClass* StaticClass(){return UMaterialExpressionSpeedTree::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionSpeedTree::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
