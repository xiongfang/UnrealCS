#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionPower
	{
		static UClass* StaticClass(){return UMaterialExpressionPower::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionPower::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
