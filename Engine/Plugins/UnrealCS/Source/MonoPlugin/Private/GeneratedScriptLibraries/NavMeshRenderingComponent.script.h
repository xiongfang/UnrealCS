#pragma once

namespace UnrealEngine
{
	class _UNavMeshRenderingComponent
	{
		static UClass* StaticClass(){return UNavMeshRenderingComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavMeshRenderingComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
