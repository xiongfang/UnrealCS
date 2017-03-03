#pragma once

namespace UnrealEngine
{
	class _APreCullTrianglesVolume
	{
		static UClass* StaticClass(){return APreCullTrianglesVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.APreCullTrianglesVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
