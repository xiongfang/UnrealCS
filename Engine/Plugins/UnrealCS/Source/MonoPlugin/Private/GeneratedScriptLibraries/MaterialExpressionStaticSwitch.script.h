#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionStaticSwitch
	{
		static UClass* StaticClass(){return UMaterialExpressionStaticSwitch::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionStaticSwitch::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
