#pragma once

namespace UnrealEngine
{
	class _ULightmappedSurfaceCollection
	{
		static UClass* StaticClass(){return ULightmappedSurfaceCollection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ULightmappedSurfaceCollection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
