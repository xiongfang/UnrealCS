#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionParameter
	{
		static UClass* StaticClass(){return UMaterialExpressionParameter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionParameter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
