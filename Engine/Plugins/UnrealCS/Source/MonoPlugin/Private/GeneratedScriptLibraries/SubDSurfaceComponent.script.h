#pragma once

namespace UnrealEngine
{
	class _USubDSurfaceComponent
	{
		static int32 SetMesh(USubDSurfaceComponent* _this,USubDSurface* NewMesh)
		{
			bool ___ret = _this->SetMesh(NewMesh);
			return ___ret?1:0;
			
		}
		static UClass* StaticClass(){return USubDSurfaceComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USubDSurfaceComponent::SetMesh",(const void*)SetMesh);
			mono_add_internal_call("UnrealEngine.USubDSurfaceComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
