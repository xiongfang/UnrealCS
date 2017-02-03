#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionStaticBoolParameter
	{
		static UClass* StaticClass(){return UMaterialExpressionStaticBoolParameter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionStaticBoolParameter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
