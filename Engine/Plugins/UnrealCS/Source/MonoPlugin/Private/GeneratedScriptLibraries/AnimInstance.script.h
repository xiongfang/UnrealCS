#pragma once

namespace UnrealEngine
{
	class _UAnimInstance
	{
		static FMarkerSyncAnimPosition GetSyncGroupPosition(UAnimInstance* _this,MonoString* InSyncGroupName)
		{
			FName InSyncGroupName_temp=MonoStringToFName(InSyncGroupName);
			FMarkerSyncAnimPosition ___ret = _this->GetSyncGroupPosition(InSyncGroupName_temp);
			return ___ret;
			
		}
		static int32 IsSyncGroupBetweenMarkers(UAnimInstance* _this,MonoString* InSyncGroupName,MonoString* PreviousMarker,MonoString* NextMarker,int32 bRespectMarkerOrder)
		{
			FName InSyncGroupName_temp=MonoStringToFName(InSyncGroupName);
			FName PreviousMarker_temp=MonoStringToFName(PreviousMarker);
			FName NextMarker_temp=MonoStringToFName(NextMarker);
			bool ___ret = _this->IsSyncGroupBetweenMarkers(InSyncGroupName_temp,PreviousMarker_temp,NextMarker_temp,bRespectMarkerOrder>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 HasMarkerBeenHitThisFrame(UAnimInstance* _this,MonoString* SyncGroup,MonoString* MarkerName)
		{
			FName SyncGroup_temp=MonoStringToFName(SyncGroup);
			FName MarkerName_temp=MonoStringToFName(MarkerName);
			bool ___ret = _this->HasMarkerBeenHitThisFrame(SyncGroup_temp,MarkerName_temp);
			return ___ret?1:0;
			
		}
		static int32 GetTimeToClosestMarker(UAnimInstance* _this,MonoString* SyncGroup,MonoString* MarkerName,float* OutMarkerTime)
		{
			FName SyncGroup_temp=MonoStringToFName(SyncGroup);
			FName MarkerName_temp=MonoStringToFName(MarkerName);
			bool ___ret = _this->GetTimeToClosestMarker(SyncGroup_temp,MarkerName_temp,*OutMarkerTime);
			return ___ret?1:0;
			
		}
		static float CalculateDirection(UAnimInstance* _this,FVector* Velocity,FRotator* BaseRotation)
		{
			float ___ret = _this->CalculateDirection(*Velocity,*BaseRotation);
			return ___ret;
			
		}
		static void ClearMorphTargets(UAnimInstance* _this)
		{
			_this->ClearMorphTargets();
			
		}
		static void SetMorphTarget(UAnimInstance* _this,MonoString* MorphTargetName,float Value)
		{
			FName MorphTargetName_temp=MonoStringToFName(MorphTargetName);
			_this->SetMorphTarget(MorphTargetName_temp,Value);
			
		}
		static MonoString* GetCurrentStateName(UAnimInstance* _this,int32 MachineIndex)
		{
			FName ___ret = _this->GetCurrentStateName(MachineIndex);
			return FNameToMonoString(___ret);
			
		}
		static float GetCurrentStateElapsedTime(UAnimInstance* _this,int32 MachineIndex)
		{
			float ___ret = _this->GetCurrentStateElapsedTime(MachineIndex);
			return ___ret;
			
		}
		static float GetStateWeight(UAnimInstance* _this,int32 MachineIndex,int32 StateIndex)
		{
			float ___ret = _this->GetStateWeight(MachineIndex,StateIndex);
			return ___ret;
			
		}
		static float GetAnimAssetPlayerTimeFromEndFraction(UAnimInstance* _this,UAnimationAsset* AnimAsset,float CurrentTime)
		{
			float ___ret = _this->GetAnimAssetPlayerTimeFromEndFraction(AnimAsset,CurrentTime);
			return ___ret;
			
		}
		static float GetAnimAssetPlayerTimeFromEnd(UAnimInstance* _this,UAnimationAsset* AnimAsset,float CurrentTime)
		{
			float ___ret = _this->GetAnimAssetPlayerTimeFromEnd(AnimAsset,CurrentTime);
			return ___ret;
			
		}
		static float GetAnimAssetPlayerTimeFraction(UAnimInstance* _this,UAnimationAsset* AnimAsset,float CurrentTime)
		{
			float ___ret = _this->GetAnimAssetPlayerTimeFraction(AnimAsset,CurrentTime);
			return ___ret;
			
		}
		static float GetAnimAssetPlayerLength(UAnimInstance* _this,UAnimationAsset* AnimAsset)
		{
			float ___ret = _this->GetAnimAssetPlayerLength(AnimAsset);
			return ___ret;
			
		}
		static float GetCurveValue(UAnimInstance* _this,MonoString* CurveName)
		{
			FName CurveName_temp=MonoStringToFName(CurveName);
			float ___ret = _this->GetCurveValue(CurveName_temp);
			return ___ret;
			
		}
		static float GetRelevantAnimTimeFraction(UAnimInstance* _this,int32 MachineIndex,int32 StateIndex)
		{
			float ___ret = _this->GetRelevantAnimTimeFraction(MachineIndex,StateIndex);
			return ___ret;
			
		}
		static float GetRelevantAnimTime(UAnimInstance* _this,int32 MachineIndex,int32 StateIndex)
		{
			float ___ret = _this->GetRelevantAnimTime(MachineIndex,StateIndex);
			return ___ret;
			
		}
		static float GetRelevantAnimLength(UAnimInstance* _this,int32 MachineIndex,int32 StateIndex)
		{
			float ___ret = _this->GetRelevantAnimLength(MachineIndex,StateIndex);
			return ___ret;
			
		}
		static float GetRelevantAnimTimeRemainingFraction(UAnimInstance* _this,int32 MachineIndex,int32 StateIndex)
		{
			float ___ret = _this->GetRelevantAnimTimeRemainingFraction(MachineIndex,StateIndex);
			return ___ret;
			
		}
		static float GetRelevantAnimTimeRemaining(UAnimInstance* _this,int32 MachineIndex,int32 StateIndex)
		{
			float ___ret = _this->GetRelevantAnimTimeRemaining(MachineIndex,StateIndex);
			return ___ret;
			
		}
		static float GetInstanceTransitionTimeElapsedFraction(UAnimInstance* _this,int32 MachineIndex,int32 TransitionIndex)
		{
			float ___ret = _this->GetInstanceTransitionTimeElapsedFraction(MachineIndex,TransitionIndex);
			return ___ret;
			
		}
		static float GetInstanceTransitionTimeElapsed(UAnimInstance* _this,int32 MachineIndex,int32 TransitionIndex)
		{
			float ___ret = _this->GetInstanceTransitionTimeElapsed(MachineIndex,TransitionIndex);
			return ___ret;
			
		}
		static float GetInstanceTransitionCrossfadeDuration(UAnimInstance* _this,int32 MachineIndex,int32 TransitionIndex)
		{
			float ___ret = _this->GetInstanceTransitionCrossfadeDuration(MachineIndex,TransitionIndex);
			return ___ret;
			
		}
		static float GetInstanceCurrentStateElapsedTime(UAnimInstance* _this,int32 MachineIndex)
		{
			float ___ret = _this->GetInstanceCurrentStateElapsedTime(MachineIndex);
			return ___ret;
			
		}
		static float GetInstanceStateWeight(UAnimInstance* _this,int32 MachineIndex,int32 StateIndex)
		{
			float ___ret = _this->GetInstanceStateWeight(MachineIndex,StateIndex);
			return ___ret;
			
		}
		static float GetInstanceMachineWeight(UAnimInstance* _this,int32 MachineIndex)
		{
			float ___ret = _this->GetInstanceMachineWeight(MachineIndex);
			return ___ret;
			
		}
		static float GetInstanceAssetPlayerTimeFromEndFraction(UAnimInstance* _this,int32 AssetPlayerIndex)
		{
			float ___ret = _this->GetInstanceAssetPlayerTimeFromEndFraction(AssetPlayerIndex);
			return ___ret;
			
		}
		static float GetInstanceAssetPlayerTimeFromEnd(UAnimInstance* _this,int32 AssetPlayerIndex)
		{
			float ___ret = _this->GetInstanceAssetPlayerTimeFromEnd(AssetPlayerIndex);
			return ___ret;
			
		}
		static float GetInstanceAssetPlayerTimeFraction(UAnimInstance* _this,int32 AssetPlayerIndex)
		{
			float ___ret = _this->GetInstanceAssetPlayerTimeFraction(AssetPlayerIndex);
			return ___ret;
			
		}
		static float GetInstanceAssetPlayerTime(UAnimInstance* _this,int32 AssetPlayerIndex)
		{
			float ___ret = _this->GetInstanceAssetPlayerTime(AssetPlayerIndex);
			return ___ret;
			
		}
		static float GetInstanceAssetPlayerLength(UAnimInstance* _this,int32 AssetPlayerIndex)
		{
			float ___ret = _this->GetInstanceAssetPlayerLength(AssetPlayerIndex);
			return ___ret;
			
		}
		static void SetRootMotionMode(UAnimInstance* _this,int32 Value)
		{
			_this->SetRootMotionMode((TEnumAsByte<ERootMotionMode::Type>)Value);
			
		}
		static UAnimMontage* GetCurrentActiveMontage(UAnimInstance* _this)
		{
			UAnimMontage* ___ret = _this->GetCurrentActiveMontage();
			return ___ret;
			
		}
		static int32 IsAnyMontagePlaying(UAnimInstance* _this)
		{
			bool ___ret = _this->IsAnyMontagePlaying();
			return ___ret?1:0;
			
		}
		static float Montage_GetPlayRate(UAnimInstance* _this,UAnimMontage* Montage)
		{
			float ___ret = _this->Montage_GetPlayRate(Montage);
			return ___ret;
			
		}
		static float Montage_GetBlendTime(UAnimInstance* _this,UAnimMontage* Montage)
		{
			float ___ret = _this->Montage_GetBlendTime(Montage);
			return ___ret;
			
		}
		static int32 Montage_GetIsStopped(UAnimInstance* _this,UAnimMontage* Montage)
		{
			bool ___ret = _this->Montage_GetIsStopped(Montage);
			return ___ret?1:0;
			
		}
		static void Montage_SetPosition(UAnimInstance* _this,UAnimMontage* Montage,float NewPosition)
		{
			_this->Montage_SetPosition(Montage,NewPosition);
			
		}
		static float Montage_GetPosition(UAnimInstance* _this,UAnimMontage* Montage)
		{
			float ___ret = _this->Montage_GetPosition(Montage);
			return ___ret;
			
		}
		static MonoString* Montage_GetCurrentSection(UAnimInstance* _this,UAnimMontage* Montage)
		{
			FName ___ret = _this->Montage_GetCurrentSection(Montage);
			return FNameToMonoString(___ret);
			
		}
		static int32 Montage_IsPlaying(UAnimInstance* _this,UAnimMontage* Montage)
		{
			bool ___ret = _this->Montage_IsPlaying(Montage);
			return ___ret?1:0;
			
		}
		static int32 Montage_IsActive(UAnimInstance* _this,UAnimMontage* Montage)
		{
			bool ___ret = _this->Montage_IsActive(Montage);
			return ___ret?1:0;
			
		}
		static void Montage_SetPlayRate(UAnimInstance* _this,UAnimMontage* Montage,float NewPlayRate)
		{
			_this->Montage_SetPlayRate(Montage,NewPlayRate);
			
		}
		static void Montage_SetNextSection(UAnimInstance* _this,MonoString* SectionNameToChange,MonoString* NextSection,UAnimMontage* Montage)
		{
			FName SectionNameToChange_temp=MonoStringToFName(SectionNameToChange);
			FName NextSection_temp=MonoStringToFName(NextSection);
			_this->Montage_SetNextSection(SectionNameToChange_temp,NextSection_temp,Montage);
			
		}
		static void Montage_JumpToSectionsEnd(UAnimInstance* _this,MonoString* SectionName,UAnimMontage* Montage)
		{
			FName SectionName_temp=MonoStringToFName(SectionName);
			_this->Montage_JumpToSectionsEnd(SectionName_temp,Montage);
			
		}
		static void Montage_JumpToSection(UAnimInstance* _this,MonoString* SectionName,UAnimMontage* Montage)
		{
			FName SectionName_temp=MonoStringToFName(SectionName);
			_this->Montage_JumpToSection(SectionName_temp,Montage);
			
		}
		static void Montage_Resume(UAnimInstance* _this,UAnimMontage* Montage)
		{
			_this->Montage_Resume(Montage);
			
		}
		static void Montage_Pause(UAnimInstance* _this,UAnimMontage* Montage)
		{
			_this->Montage_Pause(Montage);
			
		}
		static void Montage_Stop(UAnimInstance* _this,float InBlendOutTime,UAnimMontage* Montage)
		{
			_this->Montage_Stop(InBlendOutTime,Montage);
			
		}
		static int32 IsPlayingSlotAnimation(UAnimInstance* _this,UAnimSequenceBase* Asset,MonoString* SlotNodeName)
		{
			FName SlotNodeName_temp=MonoStringToFName(SlotNodeName);
			bool ___ret = _this->IsPlayingSlotAnimation(Asset,SlotNodeName_temp);
			return ___ret?1:0;
			
		}
		static void StopSlotAnimation(UAnimInstance* _this,float InBlendOutTime,MonoString* SlotNodeName)
		{
			FName SlotNodeName_temp=MonoStringToFName(SlotNodeName);
			_this->StopSlotAnimation(InBlendOutTime,SlotNodeName_temp);
			
		}
		static UAnimMontage* PlaySlotAnimationAsDynamicMontage(UAnimInstance* _this,UAnimSequenceBase* Asset,MonoString* SlotNodeName,float BlendInTime,float BlendOutTime,float InPlayRate,int32 LoopCount,float BlendOutTriggerTime,float InTimeToStartMontageAt)
		{
			FName SlotNodeName_temp=MonoStringToFName(SlotNodeName);
			UAnimMontage* ___ret = _this->PlaySlotAnimationAsDynamicMontage(Asset,SlotNodeName_temp,BlendInTime,BlendOutTime,InPlayRate,LoopCount,BlendOutTriggerTime,InTimeToStartMontageAt);
			return ___ret;
			
		}
		static float PlaySlotAnimation(UAnimInstance* _this,UAnimSequenceBase* Asset,MonoString* SlotNodeName,float BlendInTime,float BlendOutTime,float InPlayRate,int32 LoopCount)
		{
			FName SlotNodeName_temp=MonoStringToFName(SlotNodeName);
			float ___ret = _this->PlaySlotAnimation(Asset,SlotNodeName_temp,BlendInTime,BlendOutTime,InPlayRate,LoopCount);
			return ___ret;
			
		}
		static USkeletalMeshComponent* GetOwningComponent(UAnimInstance* _this)
		{
			USkeletalMeshComponent* ___ret = _this->GetOwningComponent();
			return ___ret;
			
		}
		static AActor* GetOwningActor(UAnimInstance* _this)
		{
			AActor* ___ret = _this->GetOwningActor();
			return ___ret;
			
		}
		static void SnapshotPose(UAnimInstance* _this,FPoseSnapshot* Snapshot)
		{
			_this->SnapshotPose(*Snapshot);
			
		}
		static void SavePoseSnapshot(UAnimInstance* _this,MonoString* SnapshotName)
		{
			FName SnapshotName_temp=MonoStringToFName(SnapshotName);
			_this->SavePoseSnapshot(SnapshotName_temp);
			
		}
		static APawn* TryGetPawnOwner(UAnimInstance* _this)
		{
			APawn* ___ret = _this->TryGetPawnOwner();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UAnimInstance::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetSyncGroupPosition",(const void*)GetSyncGroupPosition);
			mono_add_internal_call("UnrealEngine.UAnimInstance::IsSyncGroupBetweenMarkers",(const void*)IsSyncGroupBetweenMarkers);
			mono_add_internal_call("UnrealEngine.UAnimInstance::HasMarkerBeenHitThisFrame",(const void*)HasMarkerBeenHitThisFrame);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetTimeToClosestMarker",(const void*)GetTimeToClosestMarker);
			mono_add_internal_call("UnrealEngine.UAnimInstance::CalculateDirection",(const void*)CalculateDirection);
			mono_add_internal_call("UnrealEngine.UAnimInstance::ClearMorphTargets",(const void*)ClearMorphTargets);
			mono_add_internal_call("UnrealEngine.UAnimInstance::SetMorphTarget",(const void*)SetMorphTarget);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetCurrentStateName",(const void*)GetCurrentStateName);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetCurrentStateElapsedTime",(const void*)GetCurrentStateElapsedTime);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetStateWeight",(const void*)GetStateWeight);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetAnimAssetPlayerTimeFromEndFraction",(const void*)GetAnimAssetPlayerTimeFromEndFraction);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetAnimAssetPlayerTimeFromEnd",(const void*)GetAnimAssetPlayerTimeFromEnd);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetAnimAssetPlayerTimeFraction",(const void*)GetAnimAssetPlayerTimeFraction);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetAnimAssetPlayerLength",(const void*)GetAnimAssetPlayerLength);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetCurveValue",(const void*)GetCurveValue);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetRelevantAnimTimeFraction",(const void*)GetRelevantAnimTimeFraction);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetRelevantAnimTime",(const void*)GetRelevantAnimTime);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetRelevantAnimLength",(const void*)GetRelevantAnimLength);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetRelevantAnimTimeRemainingFraction",(const void*)GetRelevantAnimTimeRemainingFraction);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetRelevantAnimTimeRemaining",(const void*)GetRelevantAnimTimeRemaining);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetInstanceTransitionTimeElapsedFraction",(const void*)GetInstanceTransitionTimeElapsedFraction);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetInstanceTransitionTimeElapsed",(const void*)GetInstanceTransitionTimeElapsed);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetInstanceTransitionCrossfadeDuration",(const void*)GetInstanceTransitionCrossfadeDuration);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetInstanceCurrentStateElapsedTime",(const void*)GetInstanceCurrentStateElapsedTime);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetInstanceStateWeight",(const void*)GetInstanceStateWeight);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetInstanceMachineWeight",(const void*)GetInstanceMachineWeight);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetInstanceAssetPlayerTimeFromEndFraction",(const void*)GetInstanceAssetPlayerTimeFromEndFraction);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetInstanceAssetPlayerTimeFromEnd",(const void*)GetInstanceAssetPlayerTimeFromEnd);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetInstanceAssetPlayerTimeFraction",(const void*)GetInstanceAssetPlayerTimeFraction);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetInstanceAssetPlayerTime",(const void*)GetInstanceAssetPlayerTime);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetInstanceAssetPlayerLength",(const void*)GetInstanceAssetPlayerLength);
			mono_add_internal_call("UnrealEngine.UAnimInstance::SetRootMotionMode",(const void*)SetRootMotionMode);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetCurrentActiveMontage",(const void*)GetCurrentActiveMontage);
			mono_add_internal_call("UnrealEngine.UAnimInstance::IsAnyMontagePlaying",(const void*)IsAnyMontagePlaying);
			mono_add_internal_call("UnrealEngine.UAnimInstance::Montage_GetPlayRate",(const void*)Montage_GetPlayRate);
			mono_add_internal_call("UnrealEngine.UAnimInstance::Montage_GetBlendTime",(const void*)Montage_GetBlendTime);
			mono_add_internal_call("UnrealEngine.UAnimInstance::Montage_GetIsStopped",(const void*)Montage_GetIsStopped);
			mono_add_internal_call("UnrealEngine.UAnimInstance::Montage_SetPosition",(const void*)Montage_SetPosition);
			mono_add_internal_call("UnrealEngine.UAnimInstance::Montage_GetPosition",(const void*)Montage_GetPosition);
			mono_add_internal_call("UnrealEngine.UAnimInstance::Montage_GetCurrentSection",(const void*)Montage_GetCurrentSection);
			mono_add_internal_call("UnrealEngine.UAnimInstance::Montage_IsPlaying",(const void*)Montage_IsPlaying);
			mono_add_internal_call("UnrealEngine.UAnimInstance::Montage_IsActive",(const void*)Montage_IsActive);
			mono_add_internal_call("UnrealEngine.UAnimInstance::Montage_SetPlayRate",(const void*)Montage_SetPlayRate);
			mono_add_internal_call("UnrealEngine.UAnimInstance::Montage_SetNextSection",(const void*)Montage_SetNextSection);
			mono_add_internal_call("UnrealEngine.UAnimInstance::Montage_JumpToSectionsEnd",(const void*)Montage_JumpToSectionsEnd);
			mono_add_internal_call("UnrealEngine.UAnimInstance::Montage_JumpToSection",(const void*)Montage_JumpToSection);
			mono_add_internal_call("UnrealEngine.UAnimInstance::Montage_Resume",(const void*)Montage_Resume);
			mono_add_internal_call("UnrealEngine.UAnimInstance::Montage_Pause",(const void*)Montage_Pause);
			mono_add_internal_call("UnrealEngine.UAnimInstance::Montage_Stop",(const void*)Montage_Stop);
			mono_add_internal_call("UnrealEngine.UAnimInstance::IsPlayingSlotAnimation",(const void*)IsPlayingSlotAnimation);
			mono_add_internal_call("UnrealEngine.UAnimInstance::StopSlotAnimation",(const void*)StopSlotAnimation);
			mono_add_internal_call("UnrealEngine.UAnimInstance::PlaySlotAnimationAsDynamicMontage",(const void*)PlaySlotAnimationAsDynamicMontage);
			mono_add_internal_call("UnrealEngine.UAnimInstance::PlaySlotAnimation",(const void*)PlaySlotAnimation);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetOwningComponent",(const void*)GetOwningComponent);
			mono_add_internal_call("UnrealEngine.UAnimInstance::GetOwningActor",(const void*)GetOwningActor);
			mono_add_internal_call("UnrealEngine.UAnimInstance::SnapshotPose",(const void*)SnapshotPose);
			mono_add_internal_call("UnrealEngine.UAnimInstance::SavePoseSnapshot",(const void*)SavePoseSnapshot);
			mono_add_internal_call("UnrealEngine.UAnimInstance::TryGetPawnOwner",(const void*)TryGetPawnOwner);
			mono_add_internal_call("UnrealEngine.UAnimInstance::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
