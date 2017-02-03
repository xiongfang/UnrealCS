#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionScalarParameter
	{
		static UClass* StaticClass(){return UMaterialExpressionScalarParameter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionScalarParameter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
