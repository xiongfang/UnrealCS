#pragma once

namespace UnrealEngine
{
	class _UVisualLoggerDebugSnapshotInterface
	{
		static UClass* StaticClass(){return UVisualLoggerDebugSnapshotInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UVisualLoggerDebugSnapshotInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
