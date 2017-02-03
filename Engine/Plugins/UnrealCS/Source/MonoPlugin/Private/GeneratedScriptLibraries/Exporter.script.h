#pragma once

namespace UnrealEngine
{
	class _UExporter
	{
		static UClass* StaticClass(){return UExporter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UExporter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
