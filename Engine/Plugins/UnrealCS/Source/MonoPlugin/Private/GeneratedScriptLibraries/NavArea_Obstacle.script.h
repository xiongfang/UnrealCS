#pragma once

namespace UnrealEngine
{
	class _UNavArea_Obstacle
	{
		static UClass* StaticClass(){return UNavArea_Obstacle::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavArea_Obstacle::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
