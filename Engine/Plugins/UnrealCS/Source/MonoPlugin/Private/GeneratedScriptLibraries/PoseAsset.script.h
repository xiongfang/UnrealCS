#pragma once

namespace UnrealEngine
{
	class _UPoseAsset
	{
		static UClass* StaticClass(){return UPoseAsset::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPoseAsset::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
