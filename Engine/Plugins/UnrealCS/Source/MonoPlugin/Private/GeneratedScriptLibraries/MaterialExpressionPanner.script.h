#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionPanner
	{
		static UClass* StaticClass(){return UMaterialExpressionPanner::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionPanner::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
