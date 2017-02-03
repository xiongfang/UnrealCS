#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionStaticSwitchParameter
	{
		static UClass* StaticClass(){return UMaterialExpressionStaticSwitchParameter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionStaticSwitchParameter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
