#pragma once

namespace UnrealEngine
{
	class _ACharacter
	{
		static float GetAnimRootMotionTranslationScale(ACharacter* _this)
		{
			float ___ret = _this->GetAnimRootMotionTranslationScale();
			return ___ret;
			
		}
		static int32 IsPlayingNetworkedRootMotionMontage(ACharacter* _this)
		{
			bool ___ret = _this->IsPlayingNetworkedRootMotionMontage();
			return ___ret?1:0;
			
		}
		static int32 IsPlayingRootMotion(ACharacter* _this)
		{
			bool ___ret = _this->IsPlayingRootMotion();
			return ___ret?1:0;
			
		}
		static void OnRep_RootMotion(ACharacter* _this)
		{
			_this->OnRep_RootMotion();
			
		}
		static void ClientCheatGhost(ACharacter* _this)
		{
			_this->ClientCheatGhost();
			
		}
		static void ClientCheatFly(ACharacter* _this)
		{
			_this->ClientCheatFly();
			
		}
		static void ClientCheatWalk(ACharacter* _this)
		{
			_this->ClientCheatWalk();
			
		}
		static void UnCrouch(ACharacter* _this,int32 bClientSimulation)
		{
			_this->UnCrouch(bClientSimulation>0?true:false);
			
		}
		static void Crouch(ACharacter* _this,int32 bClientSimulation)
		{
			_this->Crouch(bClientSimulation>0?true:false);
			
		}
		static void LaunchCharacter(ACharacter* _this,FVector* LaunchVelocity,int32 bXYOverride,int32 bZOverride)
		{
			_this->LaunchCharacter(*LaunchVelocity,bXYOverride>0?true:false,bZOverride>0?true:false);
			
		}
		static UAnimMontage* GetCurrentMontage(ACharacter* _this)
		{
			UAnimMontage* ___ret = _this->GetCurrentMontage();
			return ___ret;
			
		}
		static void StopAnimMontage(ACharacter* _this,UAnimMontage* AnimMontage)
		{
			_this->StopAnimMontage(AnimMontage);
			
		}
		static float PlayAnimMontage(ACharacter* _this,UAnimMontage* AnimMontage,float InPlayRate,MonoString* StartSectionName)
		{
			FName StartSectionName_temp=MonoStringToFName(StartSectionName);
			float ___ret = _this->PlayAnimMontage(AnimMontage,InPlayRate,StartSectionName_temp);
			return ___ret;
			
		}
		static int32 IsJumpProvidingForce(ACharacter* _this)
		{
			bool ___ret = _this->IsJumpProvidingForce();
			return ___ret?1:0;
			
		}
		static int32 CanJump(ACharacter* _this)
		{
			bool ___ret = _this->CanJump();
			return ___ret?1:0;
			
		}
		static void StopJumping(ACharacter* _this)
		{
			_this->StopJumping();
			
		}
		static void Jump(ACharacter* _this)
		{
			_this->Jump();
			
		}
		static void OnRep_IsCrouched(ACharacter* _this)
		{
			_this->OnRep_IsCrouched();
			
		}
		static void SetReplicateMovement(ACharacter* _this,int32 bInReplicateMovement)
		{
			_this->SetReplicateMovement(bInReplicateMovement>0?true:false);
			
		}
		static void OnRep_ReplicatedBasedMovement(ACharacter* _this)
		{
			_this->OnRep_ReplicatedBasedMovement();
			
		}
		static UClass* StaticClass(){return ACharacter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ACharacter::GetAnimRootMotionTranslationScale",(const void*)GetAnimRootMotionTranslationScale);
			mono_add_internal_call("UnrealEngine.ACharacter::IsPlayingNetworkedRootMotionMontage",(const void*)IsPlayingNetworkedRootMotionMontage);
			mono_add_internal_call("UnrealEngine.ACharacter::IsPlayingRootMotion",(const void*)IsPlayingRootMotion);
			mono_add_internal_call("UnrealEngine.ACharacter::OnRep_RootMotion",(const void*)OnRep_RootMotion);
			mono_add_internal_call("UnrealEngine.ACharacter::ClientCheatGhost",(const void*)ClientCheatGhost);
			mono_add_internal_call("UnrealEngine.ACharacter::ClientCheatFly",(const void*)ClientCheatFly);
			mono_add_internal_call("UnrealEngine.ACharacter::ClientCheatWalk",(const void*)ClientCheatWalk);
			mono_add_internal_call("UnrealEngine.ACharacter::UnCrouch",(const void*)UnCrouch);
			mono_add_internal_call("UnrealEngine.ACharacter::Crouch",(const void*)Crouch);
			mono_add_internal_call("UnrealEngine.ACharacter::LaunchCharacter",(const void*)LaunchCharacter);
			mono_add_internal_call("UnrealEngine.ACharacter::GetCurrentMontage",(const void*)GetCurrentMontage);
			mono_add_internal_call("UnrealEngine.ACharacter::StopAnimMontage",(const void*)StopAnimMontage);
			mono_add_internal_call("UnrealEngine.ACharacter::PlayAnimMontage",(const void*)PlayAnimMontage);
			mono_add_internal_call("UnrealEngine.ACharacter::IsJumpProvidingForce",(const void*)IsJumpProvidingForce);
			mono_add_internal_call("UnrealEngine.ACharacter::CanJump",(const void*)CanJump);
			mono_add_internal_call("UnrealEngine.ACharacter::StopJumping",(const void*)StopJumping);
			mono_add_internal_call("UnrealEngine.ACharacter::Jump",(const void*)Jump);
			mono_add_internal_call("UnrealEngine.ACharacter::OnRep_IsCrouched",(const void*)OnRep_IsCrouched);
			mono_add_internal_call("UnrealEngine.ACharacter::SetReplicateMovement",(const void*)SetReplicateMovement);
			mono_add_internal_call("UnrealEngine.ACharacter::OnRep_ReplicatedBasedMovement",(const void*)OnRep_ReplicatedBasedMovement);
			mono_add_internal_call("UnrealEngine.ACharacter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
