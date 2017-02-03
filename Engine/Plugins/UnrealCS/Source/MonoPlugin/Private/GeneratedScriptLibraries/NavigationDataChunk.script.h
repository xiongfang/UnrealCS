#pragma once

namespace UnrealEngine
{
	class _UNavigationDataChunk
	{
		static UClass* StaticClass(){return UNavigationDataChunk::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavigationDataChunk::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
