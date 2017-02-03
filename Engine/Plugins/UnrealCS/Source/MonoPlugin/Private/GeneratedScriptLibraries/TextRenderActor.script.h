#pragma once

namespace UnrealEngine
{
	class _ATextRenderActor
	{
		static UClass* StaticClass(){return ATextRenderActor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ATextRenderActor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
