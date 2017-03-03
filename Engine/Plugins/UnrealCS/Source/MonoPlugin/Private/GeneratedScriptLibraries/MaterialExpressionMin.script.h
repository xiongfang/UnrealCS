#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionMin
	{
		static UClass* StaticClass(){return UMaterialExpressionMin::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionMin::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
