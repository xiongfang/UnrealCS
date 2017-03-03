#pragma once

namespace UnrealEngine
{
	class _ATargetPoint
	{
		static UClass* StaticClass(){return ATargetPoint::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ATargetPoint::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
