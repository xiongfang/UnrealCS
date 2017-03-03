#pragma once

namespace UnrealEngine
{
	class _ADecalActor
	{
		static UClass* StaticClass(){return ADecalActor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ADecalActor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
