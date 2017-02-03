#pragma once

namespace UnrealEngine
{
	class _USlateVectorArtData
	{
		static UClass* StaticClass(){return USlateVectorArtData::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USlateVectorArtData::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
