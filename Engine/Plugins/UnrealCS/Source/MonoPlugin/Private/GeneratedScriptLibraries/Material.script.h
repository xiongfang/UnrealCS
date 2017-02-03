#pragma once

namespace UnrealEngine
{
	class _UMaterial
	{
		static UClass* StaticClass(){return UMaterial::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterial::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
