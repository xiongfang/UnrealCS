#pragma once

namespace UnrealEngine
{
	class _APawn
	{
		static int32 IsMoveInputIgnored(APawn* _this)
		{
			bool ___ret = _this->IsMoveInputIgnored();
			return ___ret?1:0;
			
		}
		static void AddControllerRollInput(APawn* _this,float Val)
		{
			_this->AddControllerRollInput(Val);
			
		}
		static void AddControllerYawInput(APawn* _this,float Val)
		{
			_this->AddControllerYawInput(Val);
			
		}
		static void AddControllerPitchInput(APawn* _this,float Val)
		{
			_this->AddControllerPitchInput(Val);
			
		}
		static FVector ConsumeMovementInputVector(APawn* _this)
		{
			FVector ___ret = _this->ConsumeMovementInputVector();
			return ___ret;
			
		}
		static FVector GetLastMovementInputVector(APawn* _this)
		{
			FVector ___ret = _this->GetLastMovementInputVector();
			return ___ret;
			
		}
		static FVector GetPendingMovementInputVector(APawn* _this)
		{
			FVector ___ret = _this->GetPendingMovementInputVector();
			return ___ret;
			
		}
		static void AddMovementInput(APawn* _this,FVector* WorldDirection,float ScaleValue,int32 bForce)
		{
			_this->AddMovementInput(*WorldDirection,ScaleValue,bForce>0?true:false);
			
		}
		static void SpawnDefaultController(APawn* _this)
		{
			_this->SpawnDefaultController();
			
		}
		static void DetachFromControllerPendingDestroy(APawn* _this)
		{
			_this->DetachFromControllerPendingDestroy();
			
		}
		static FRotator GetBaseAimRotation(APawn* _this)
		{
			FRotator ___ret = _this->GetBaseAimRotation();
			return ___ret;
			
		}
		static int32 IsPlayerControlled(APawn* _this)
		{
			bool ___ret = _this->IsPlayerControlled();
			return ___ret?1:0;
			
		}
		static int32 IsLocallyControlled(APawn* _this)
		{
			bool ___ret = _this->IsLocallyControlled();
			return ___ret?1:0;
			
		}
		static FVector GetNavAgentLocation(APawn* _this)
		{
			FVector ___ret = _this->GetNavAgentLocation();
			return ___ret;
			
		}
		static void SetCanAffectNavigationGeneration(APawn* _this,int32 bNewValue,int32 bForceUpdate)
		{
			_this->SetCanAffectNavigationGeneration(bNewValue>0?true:false,bForceUpdate>0?true:false);
			
		}
		static void OnRep_PlayerState(APawn* _this)
		{
			_this->OnRep_PlayerState();
			
		}
		static void OnRep_Controller(APawn* _this)
		{
			_this->OnRep_Controller();
			
		}
		static FRotator GetControlRotation(APawn* _this)
		{
			FRotator ___ret = _this->GetControlRotation();
			return ___ret;
			
		}
		static AController* GetController(APawn* _this)
		{
			AController* ___ret = _this->GetController();
			return ___ret;
			
		}
		static int32 IsControlled(APawn* _this)
		{
			bool ___ret = _this->IsControlled();
			return ___ret?1:0;
			
		}
		static AActor* GetMovementBaseActor(APawn* _this,APawn* Pawn)
		{
			AActor* ___ret = _this->GetMovementBaseActor(Pawn);
			return ___ret;
			
		}
		static void PawnMakeNoise(APawn* _this,float Loudness,FVector* NoiseLocation,int32 bUseNoiseMakerLocation,AActor* NoiseMaker)
		{
			_this->PawnMakeNoise(Loudness,*NoiseLocation,bUseNoiseMakerLocation>0?true:false,NoiseMaker);
			
		}
		static UPawnMovementComponent* GetMovementComponent(APawn* _this)
		{
			UPawnMovementComponent* ___ret = _this->GetMovementComponent();
			return ___ret;
			
		}
		static UClass* StaticClass(){return APawn::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.APawn::IsMoveInputIgnored",(const void*)IsMoveInputIgnored);
			mono_add_internal_call("UnrealEngine.APawn::AddControllerRollInput",(const void*)AddControllerRollInput);
			mono_add_internal_call("UnrealEngine.APawn::AddControllerYawInput",(const void*)AddControllerYawInput);
			mono_add_internal_call("UnrealEngine.APawn::AddControllerPitchInput",(const void*)AddControllerPitchInput);
			mono_add_internal_call("UnrealEngine.APawn::ConsumeMovementInputVector",(const void*)ConsumeMovementInputVector);
			mono_add_internal_call("UnrealEngine.APawn::GetLastMovementInputVector",(const void*)GetLastMovementInputVector);
			mono_add_internal_call("UnrealEngine.APawn::GetPendingMovementInputVector",(const void*)GetPendingMovementInputVector);
			mono_add_internal_call("UnrealEngine.APawn::AddMovementInput",(const void*)AddMovementInput);
			mono_add_internal_call("UnrealEngine.APawn::SpawnDefaultController",(const void*)SpawnDefaultController);
			mono_add_internal_call("UnrealEngine.APawn::DetachFromControllerPendingDestroy",(const void*)DetachFromControllerPendingDestroy);
			mono_add_internal_call("UnrealEngine.APawn::GetBaseAimRotation",(const void*)GetBaseAimRotation);
			mono_add_internal_call("UnrealEngine.APawn::IsPlayerControlled",(const void*)IsPlayerControlled);
			mono_add_internal_call("UnrealEngine.APawn::IsLocallyControlled",(const void*)IsLocallyControlled);
			mono_add_internal_call("UnrealEngine.APawn::GetNavAgentLocation",(const void*)GetNavAgentLocation);
			mono_add_internal_call("UnrealEngine.APawn::SetCanAffectNavigationGeneration",(const void*)SetCanAffectNavigationGeneration);
			mono_add_internal_call("UnrealEngine.APawn::OnRep_PlayerState",(const void*)OnRep_PlayerState);
			mono_add_internal_call("UnrealEngine.APawn::OnRep_Controller",(const void*)OnRep_Controller);
			mono_add_internal_call("UnrealEngine.APawn::GetControlRotation",(const void*)GetControlRotation);
			mono_add_internal_call("UnrealEngine.APawn::GetController",(const void*)GetController);
			mono_add_internal_call("UnrealEngine.APawn::IsControlled",(const void*)IsControlled);
			mono_add_internal_call("UnrealEngine.APawn::GetMovementBaseActor",(const void*)GetMovementBaseActor);
			mono_add_internal_call("UnrealEngine.APawn::PawnMakeNoise",(const void*)PawnMakeNoise);
			mono_add_internal_call("UnrealEngine.APawn::GetMovementComponent",(const void*)GetMovementComponent);
			mono_add_internal_call("UnrealEngine.APawn::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
