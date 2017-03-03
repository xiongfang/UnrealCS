#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionParticleSubUV
	{
		static UClass* StaticClass(){return UMaterialExpressionParticleSubUV::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionParticleSubUV::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
