#pragma once

namespace UnrealEngine
{
	class _UPoseWatch
	{
		static UClass* StaticClass(){return UPoseWatch::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPoseWatch::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
