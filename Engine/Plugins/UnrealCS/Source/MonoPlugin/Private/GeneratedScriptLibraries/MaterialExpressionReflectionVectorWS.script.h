#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionReflectionVectorWS
	{
		static UClass* StaticClass(){return UMaterialExpressionReflectionVectorWS::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionReflectionVectorWS::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
