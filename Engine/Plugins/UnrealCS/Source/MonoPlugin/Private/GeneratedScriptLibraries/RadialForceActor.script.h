#pragma once

namespace UnrealEngine
{
	class _ARadialForceActor
	{
		static UClass* StaticClass(){return ARadialForceActor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ARadialForceActor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
