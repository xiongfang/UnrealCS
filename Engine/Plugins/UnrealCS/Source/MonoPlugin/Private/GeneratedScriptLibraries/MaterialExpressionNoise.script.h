#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionNoise
	{
		static UClass* StaticClass(){return UMaterialExpressionNoise::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionNoise::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
