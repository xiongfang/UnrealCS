#pragma once

namespace UnrealEngine
{
	class _ALightmassImportanceVolume
	{
		static UClass* StaticClass(){return ALightmassImportanceVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ALightmassImportanceVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
