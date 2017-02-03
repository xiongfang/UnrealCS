#pragma once

namespace UnrealEngine
{
	class _UMaterialParameterCollection
	{
		static UClass* StaticClass(){return UMaterialParameterCollection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialParameterCollection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
