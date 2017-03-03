#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionPreSkinnedNormal
	{
		static UClass* StaticClass(){return UMaterialExpressionPreSkinnedNormal::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionPreSkinnedNormal::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
