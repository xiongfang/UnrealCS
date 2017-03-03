#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionMakeMaterialAttributes
	{
		static UClass* StaticClass(){return UMaterialExpressionMakeMaterialAttributes::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionMakeMaterialAttributes::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
