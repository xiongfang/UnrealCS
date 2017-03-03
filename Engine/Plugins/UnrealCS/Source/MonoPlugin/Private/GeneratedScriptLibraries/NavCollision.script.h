#pragma once

namespace UnrealEngine
{
	class _UNavCollision
	{
		static UClass* StaticClass(){return UNavCollision::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavCollision::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
