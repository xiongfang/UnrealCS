#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionViewProperty
	{
		static UClass* StaticClass(){return UMaterialExpressionViewProperty::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionViewProperty::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
