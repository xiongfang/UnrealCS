#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionRotateAboutAxis
	{
		static UClass* StaticClass(){return UMaterialExpressionRotateAboutAxis::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionRotateAboutAxis::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
