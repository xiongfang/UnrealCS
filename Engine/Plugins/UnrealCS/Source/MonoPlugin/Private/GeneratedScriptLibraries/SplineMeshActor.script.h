#pragma once

namespace UnrealEngine
{
	class _ASplineMeshActor
	{
		static UClass* StaticClass(){return ASplineMeshActor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ASplineMeshActor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
