#pragma once

namespace UnrealEngine
{
	class _UPawnMovementComponent
	{
		static APawn* GetPawnOwner(UPawnMovementComponent* _this)
		{
			APawn* ___ret = _this->GetPawnOwner();
			return ___ret;
			
		}
		static int32 IsMoveInputIgnored(UPawnMovementComponent* _this)
		{
			bool ___ret = _this->IsMoveInputIgnored();
			return ___ret?1:0;
			
		}
		static FVector ConsumeInputVector(UPawnMovementComponent* _this)
		{
			FVector ___ret = _this->ConsumeInputVector();
			return ___ret;
			
		}
		static FVector GetLastInputVector(UPawnMovementComponent* _this)
		{
			FVector ___ret = _this->GetLastInputVector();
			return ___ret;
			
		}
		static FVector GetPendingInputVector(UPawnMovementComponent* _this)
		{
			FVector ___ret = _this->GetPendingInputVector();
			return ___ret;
			
		}
		static void AddInputVector(UPawnMovementComponent* _this,FVector* WorldVector,int32 bForce)
		{
			_this->AddInputVector(*WorldVector,bForce>0?true:false);
			
		}
		static UClass* StaticClass(){return UPawnMovementComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPawnMovementComponent::GetPawnOwner",(const void*)GetPawnOwner);
			mono_add_internal_call("UnrealEngine.UPawnMovementComponent::IsMoveInputIgnored",(const void*)IsMoveInputIgnored);
			mono_add_internal_call("UnrealEngine.UPawnMovementComponent::ConsumeInputVector",(const void*)ConsumeInputVector);
			mono_add_internal_call("UnrealEngine.UPawnMovementComponent::GetLastInputVector",(const void*)GetLastInputVector);
			mono_add_internal_call("UnrealEngine.UPawnMovementComponent::GetPendingInputVector",(const void*)GetPendingInputVector);
			mono_add_internal_call("UnrealEngine.UPawnMovementComponent::AddInputVector",(const void*)AddInputVector);
			mono_add_internal_call("UnrealEngine.UPawnMovementComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
