#pragma once

namespace UnrealEngine
{
	class _UTimelineTemplate
	{
		static UClass* StaticClass(){return UTimelineTemplate::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UTimelineTemplate::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
