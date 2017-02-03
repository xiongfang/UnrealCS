#pragma once

namespace UnrealEngine
{
	class _AMeshMergeCullingVolume
	{
		static UClass* StaticClass(){return AMeshMergeCullingVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AMeshMergeCullingVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
