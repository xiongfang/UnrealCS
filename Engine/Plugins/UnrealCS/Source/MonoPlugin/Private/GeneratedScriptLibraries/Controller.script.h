#pragma once

namespace UnrealEngine
{
	class _AController
	{
		static void ResetIgnoreInputFlags(AController* _this)
		{
			_this->ResetIgnoreInputFlags();
			
		}
		static int32 IsLookInputIgnored(AController* _this)
		{
			bool ___ret = _this->IsLookInputIgnored();
			return ___ret?1:0;
			
		}
		static void ResetIgnoreLookInput(AController* _this)
		{
			_this->ResetIgnoreLookInput();
			
		}
		static void SetIgnoreLookInput(AController* _this,int32 bNewLookInput)
		{
			_this->SetIgnoreLookInput(bNewLookInput>0?true:false);
			
		}
		static int32 IsMoveInputIgnored(AController* _this)
		{
			bool ___ret = _this->IsMoveInputIgnored();
			return ___ret?1:0;
			
		}
		static void ResetIgnoreMoveInput(AController* _this)
		{
			_this->ResetIgnoreMoveInput();
			
		}
		static void SetIgnoreMoveInput(AController* _this,int32 bNewMoveInput)
		{
			_this->SetIgnoreMoveInput(bNewMoveInput>0?true:false);
			
		}
		static void StopMovement(AController* _this)
		{
			_this->StopMovement();
			
		}
		static void UnPossess(AController* _this)
		{
			_this->UnPossess();
			
		}
		static void Possess(AController* _this,APawn* InPawn)
		{
			_this->Possess(InPawn);
			
		}
		static int32 IsLocalController(AController* _this)
		{
			bool ___ret = _this->IsLocalController();
			return ___ret?1:0;
			
		}
		static int32 IsLocalPlayerController(AController* _this)
		{
			bool ___ret = _this->IsLocalPlayerController();
			return ___ret?1:0;
			
		}
		static int32 IsPlayerController(AController* _this)
		{
			bool ___ret = _this->IsPlayerController();
			return ___ret?1:0;
			
		}
		static FRotator GetDesiredRotation(AController* _this)
		{
			FRotator ___ret = _this->GetDesiredRotation();
			return ___ret;
			
		}
		static AActor* GetViewTarget(AController* _this)
		{
			AActor* ___ret = _this->GetViewTarget();
			return ___ret;
			
		}
		static APawn* K2_GetPawn(AController* _this)
		{
			APawn* ___ret = _this->K2_GetPawn();
			return ___ret;
			
		}
		static void ClientSetRotation(AController* _this,FRotator* NewRotation,int32 bResetCamera)
		{
			_this->ClientSetRotation(*NewRotation,bResetCamera>0?true:false);
			
		}
		static void ClientSetLocation(AController* _this,FVector* NewLocation,FRotator* NewRotation)
		{
			_this->ClientSetLocation(*NewLocation,*NewRotation);
			
		}
		static void OnRep_PlayerState(AController* _this)
		{
			_this->OnRep_PlayerState();
			
		}
		static void OnRep_Pawn(AController* _this)
		{
			_this->OnRep_Pawn();
			
		}
		static int32 LineOfSightTo(AController* _this,AActor* Other,FVector* ViewPoint,int32 bAlternateChecks)
		{
			bool ___ret = _this->LineOfSightTo(Other,*ViewPoint,bAlternateChecks>0?true:false);
			return ___ret?1:0;
			
		}
		static void SetInitialLocationAndRotation(AController* _this,FVector* NewLocation,FRotator* NewRotation)
		{
			_this->SetInitialLocationAndRotation(*NewLocation,*NewRotation);
			
		}
		static void SetControlRotation(AController* _this,FRotator* NewRotation)
		{
			_this->SetControlRotation(*NewRotation);
			
		}
		static FRotator GetControlRotation(AController* _this)
		{
			FRotator ___ret = _this->GetControlRotation();
			return ___ret;
			
		}
		static UClass* StaticClass(){return AController::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AController::ResetIgnoreInputFlags",(const void*)ResetIgnoreInputFlags);
			mono_add_internal_call("UnrealEngine.AController::IsLookInputIgnored",(const void*)IsLookInputIgnored);
			mono_add_internal_call("UnrealEngine.AController::ResetIgnoreLookInput",(const void*)ResetIgnoreLookInput);
			mono_add_internal_call("UnrealEngine.AController::SetIgnoreLookInput",(const void*)SetIgnoreLookInput);
			mono_add_internal_call("UnrealEngine.AController::IsMoveInputIgnored",(const void*)IsMoveInputIgnored);
			mono_add_internal_call("UnrealEngine.AController::ResetIgnoreMoveInput",(const void*)ResetIgnoreMoveInput);
			mono_add_internal_call("UnrealEngine.AController::SetIgnoreMoveInput",(const void*)SetIgnoreMoveInput);
			mono_add_internal_call("UnrealEngine.AController::StopMovement",(const void*)StopMovement);
			mono_add_internal_call("UnrealEngine.AController::UnPossess",(const void*)UnPossess);
			mono_add_internal_call("UnrealEngine.AController::Possess",(const void*)Possess);
			mono_add_internal_call("UnrealEngine.AController::IsLocalController",(const void*)IsLocalController);
			mono_add_internal_call("UnrealEngine.AController::IsLocalPlayerController",(const void*)IsLocalPlayerController);
			mono_add_internal_call("UnrealEngine.AController::IsPlayerController",(const void*)IsPlayerController);
			mono_add_internal_call("UnrealEngine.AController::GetDesiredRotation",(const void*)GetDesiredRotation);
			mono_add_internal_call("UnrealEngine.AController::GetViewTarget",(const void*)GetViewTarget);
			mono_add_internal_call("UnrealEngine.AController::K2_GetPawn",(const void*)K2_GetPawn);
			mono_add_internal_call("UnrealEngine.AController::ClientSetRotation",(const void*)ClientSetRotation);
			mono_add_internal_call("UnrealEngine.AController::ClientSetLocation",(const void*)ClientSetLocation);
			mono_add_internal_call("UnrealEngine.AController::OnRep_PlayerState",(const void*)OnRep_PlayerState);
			mono_add_internal_call("UnrealEngine.AController::OnRep_Pawn",(const void*)OnRep_Pawn);
			mono_add_internal_call("UnrealEngine.AController::LineOfSightTo",(const void*)LineOfSightTo);
			mono_add_internal_call("UnrealEngine.AController::SetInitialLocationAndRotation",(const void*)SetInitialLocationAndRotation);
			mono_add_internal_call("UnrealEngine.AController::SetControlRotation",(const void*)SetControlRotation);
			mono_add_internal_call("UnrealEngine.AController::GetControlRotation",(const void*)GetControlRotation);
			mono_add_internal_call("UnrealEngine.AController::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
