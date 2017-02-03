#pragma once

namespace UnrealEngine
{
	class _UMaterialInstance
	{
		static UClass* StaticClass(){return UMaterialInstance::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialInstance::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
