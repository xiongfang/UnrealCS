#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionComment
	{
		static UClass* StaticClass(){return UMaterialExpressionComment::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionComment::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
