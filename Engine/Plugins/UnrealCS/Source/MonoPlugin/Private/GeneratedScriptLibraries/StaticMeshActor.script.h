#pragma once

namespace UnrealEngine
{
	class _AStaticMeshActor
	{
		static UClass* StaticClass(){return AStaticMeshActor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AStaticMeshActor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
