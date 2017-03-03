#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionBumpOffset
	{
		static UClass* StaticClass(){return UMaterialExpressionBumpOffset::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionBumpOffset::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
