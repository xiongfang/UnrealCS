#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionComponentMask
	{
		static UClass* StaticClass(){return UMaterialExpressionComponentMask::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionComponentMask::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
