#pragma once

namespace UnrealEngine
{
	class _UThumbnailInfo
	{
		static UClass* StaticClass(){return UThumbnailInfo::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UThumbnailInfo::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
