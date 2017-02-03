#pragma once

namespace UnrealEngine
{
	class _AWindDirectionalSource
	{
		static UClass* StaticClass(){return AWindDirectionalSource::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AWindDirectionalSource::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
