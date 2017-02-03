#pragma once

namespace UnrealEngine
{
	class _UViewport
	{
		static AActor* Spawn(UViewport* _this,TSubclassOf<AActor>  ActorClass)
		{
			AActor* ___ret = _this->Spawn(ActorClass);
			return ___ret;
			
		}
		static void SetViewRotation(UViewport* _this,FRotator* Rotation)
		{
			_this->SetViewRotation(*Rotation);
			
		}
		static FRotator GetViewRotation(UViewport* _this)
		{
			FRotator ___ret = _this->GetViewRotation();
			return ___ret;
			
		}
		static void SetViewLocation(UViewport* _this,FVector* Location)
		{
			_this->SetViewLocation(*Location);
			
		}
		static FVector GetViewLocation(UViewport* _this)
		{
			FVector ___ret = _this->GetViewLocation();
			return ___ret;
			
		}
		static UWorld* GetViewportWorld(UViewport* _this)
		{
			UWorld* ___ret = _this->GetViewportWorld();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UViewport::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UViewport::Spawn",(const void*)Spawn);
			mono_add_internal_call("UnrealEngine.UViewport::SetViewRotation",(const void*)SetViewRotation);
			mono_add_internal_call("UnrealEngine.UViewport::GetViewRotation",(const void*)GetViewRotation);
			mono_add_internal_call("UnrealEngine.UViewport::SetViewLocation",(const void*)SetViewLocation);
			mono_add_internal_call("UnrealEngine.UViewport::GetViewLocation",(const void*)GetViewLocation);
			mono_add_internal_call("UnrealEngine.UViewport::GetViewportWorld",(const void*)GetViewportWorld);
			mono_add_internal_call("UnrealEngine.UViewport::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
