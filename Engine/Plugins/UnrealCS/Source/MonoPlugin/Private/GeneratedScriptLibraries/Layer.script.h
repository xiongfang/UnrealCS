#pragma once

namespace UnrealEngine
{
	class _ULayer
	{
		static UClass* StaticClass(){return ULayer::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ULayer::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
