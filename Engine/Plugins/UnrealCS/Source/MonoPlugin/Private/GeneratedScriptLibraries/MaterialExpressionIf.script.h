#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionIf
	{
		static UClass* StaticClass(){return UMaterialExpressionIf::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionIf::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
