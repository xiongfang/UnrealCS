#pragma once

namespace UnrealEngine
{
	class _UMaterialFunction
	{
		static UClass* StaticClass(){return UMaterialFunction::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialFunction::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
