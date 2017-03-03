#pragma once

namespace UnrealEngine
{
	class _AAbstractNavData
	{
		static UClass* StaticClass(){return AAbstractNavData::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AAbstractNavData::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
