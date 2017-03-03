#pragma once

namespace UnrealEngine
{
	class _UMaterialParameterCollectionInstance
	{
		static UClass* StaticClass(){return UMaterialParameterCollectionInstance::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialParameterCollectionInstance::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
