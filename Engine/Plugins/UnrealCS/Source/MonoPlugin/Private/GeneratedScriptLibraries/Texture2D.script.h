#pragma once

namespace UnrealEngine
{
	class _UTexture2D
	{
		static UClass* StaticClass(){return UTexture2D::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UTexture2D::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
