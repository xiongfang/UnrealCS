#pragma once

namespace UnrealEngine
{
	class _UAnimationAsset
	{
		static UClass* StaticClass(){return UAnimationAsset::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimationAsset::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
