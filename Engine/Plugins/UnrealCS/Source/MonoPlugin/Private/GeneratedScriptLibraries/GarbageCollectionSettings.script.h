#pragma once

namespace UnrealEngine
{
	class _UGarbageCollectionSettings
	{
		static UClass* StaticClass(){return UGarbageCollectionSettings::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UGarbageCollectionSettings::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
