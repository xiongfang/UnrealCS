#pragma once

namespace UnrealEngine
{
	class _UMaterialExpression
	{
		static UClass* StaticClass(){return UMaterialExpression::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpression::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
