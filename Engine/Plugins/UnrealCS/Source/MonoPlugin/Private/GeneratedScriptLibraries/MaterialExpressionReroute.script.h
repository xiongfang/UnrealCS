#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionReroute
	{
		static UClass* StaticClass(){return UMaterialExpressionReroute::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionReroute::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
