#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionClamp
	{
		static UClass* StaticClass(){return UMaterialExpressionClamp::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionClamp::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
