#pragma once

namespace UnrealEngine
{
	class _UAnimMetaData
	{
		static UClass* StaticClass(){return UAnimMetaData::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimMetaData::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
