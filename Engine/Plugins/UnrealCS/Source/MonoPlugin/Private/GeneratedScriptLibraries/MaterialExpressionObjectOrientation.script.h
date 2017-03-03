#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionObjectOrientation
	{
		static UClass* StaticClass(){return UMaterialExpressionObjectOrientation::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionObjectOrientation::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
