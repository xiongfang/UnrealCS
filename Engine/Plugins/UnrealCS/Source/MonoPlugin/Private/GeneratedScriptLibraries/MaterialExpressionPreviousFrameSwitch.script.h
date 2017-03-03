#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionPreviousFrameSwitch
	{
		static UClass* StaticClass(){return UMaterialExpressionPreviousFrameSwitch::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionPreviousFrameSwitch::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
