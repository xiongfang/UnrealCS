#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionQualitySwitch
	{
		static UClass* StaticClass(){return UMaterialExpressionQualitySwitch::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionQualitySwitch::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
