#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionFeatureLevelSwitch
	{
		static UClass* StaticClass(){return UMaterialExpressionFeatureLevelSwitch::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionFeatureLevelSwitch::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
