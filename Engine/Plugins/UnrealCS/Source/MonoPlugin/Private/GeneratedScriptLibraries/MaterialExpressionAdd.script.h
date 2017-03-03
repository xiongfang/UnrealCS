#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionAdd
	{
		static UClass* StaticClass(){return UMaterialExpressionAdd::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionAdd::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
