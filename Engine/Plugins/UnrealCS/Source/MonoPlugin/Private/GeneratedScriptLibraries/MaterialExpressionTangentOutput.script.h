#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionTangentOutput
	{
		static UClass* StaticClass(){return UMaterialExpressionTangentOutput::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionTangentOutput::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
