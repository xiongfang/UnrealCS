#pragma once

namespace UnrealEngine
{
	class _UFontFaceInterface
	{
		static UClass* StaticClass(){return UFontFaceInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UFontFaceInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
