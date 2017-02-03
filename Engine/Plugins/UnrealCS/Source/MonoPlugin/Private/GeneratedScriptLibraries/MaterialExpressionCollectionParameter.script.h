#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionCollectionParameter
	{
		static UClass* StaticClass(){return UMaterialExpressionCollectionParameter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionCollectionParameter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
