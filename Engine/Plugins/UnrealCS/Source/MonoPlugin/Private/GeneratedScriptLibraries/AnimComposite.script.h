#pragma once

namespace UnrealEngine
{
	class _UAnimComposite
	{
		static UClass* StaticClass(){return UAnimComposite::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimComposite::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
