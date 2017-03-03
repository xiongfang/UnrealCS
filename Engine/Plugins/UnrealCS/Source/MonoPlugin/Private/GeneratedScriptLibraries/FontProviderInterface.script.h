#pragma once

namespace UnrealEngine
{
	class _UFontProviderInterface
	{
		static UClass* StaticClass(){return UFontProviderInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UFontProviderInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
