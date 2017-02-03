#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionVectorParameter
	{
		static UClass* StaticClass(){return UMaterialExpressionVectorParameter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionVectorParameter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
