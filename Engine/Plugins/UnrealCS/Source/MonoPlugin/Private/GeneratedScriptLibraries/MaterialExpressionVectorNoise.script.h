#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionVectorNoise
	{
		static UClass* StaticClass(){return UMaterialExpressionVectorNoise::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionVectorNoise::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
