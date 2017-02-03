#pragma once

namespace UnrealEngine
{
	class _UBlendableInterface
	{
		static UClass* StaticClass(){return UBlendableInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBlendableInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
