#pragma once

namespace UnrealEngine
{
	class _UAnimClassData
	{
		static UClass* StaticClass(){return UAnimClassData::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimClassData::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
