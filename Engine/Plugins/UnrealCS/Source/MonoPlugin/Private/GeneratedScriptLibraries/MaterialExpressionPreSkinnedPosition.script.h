#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionPreSkinnedPosition
	{
		static UClass* StaticClass(){return UMaterialExpressionPreSkinnedPosition::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionPreSkinnedPosition::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
