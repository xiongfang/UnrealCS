#pragma once

namespace UnrealEngine
{
	class _USceneComponent
	{
		static void K2_SetWorldLocationAndRotation(USceneComponent* _this,FVector* NewLocation,FRotator* NewRotation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_SetWorldLocationAndRotation(*NewLocation,*NewRotation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void SetAbsolute(USceneComponent* _this,int32 bNewAbsoluteLocation,int32 bNewAbsoluteRotation,int32 bNewAbsoluteScale)
		{
			_this->SetAbsolute(bNewAbsoluteLocation>0?true:false,bNewAbsoluteRotation>0?true:false,bNewAbsoluteScale>0?true:false);
			
		}
		static void K2_SetRelativeLocationAndRotation(USceneComponent* _this,FVector* NewLocation,FRotator* NewRotation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_SetRelativeLocationAndRotation(*NewLocation,*NewRotation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static APhysicsVolume* GetPhysicsVolume(USceneComponent* _this)
		{
			APhysicsVolume* ___ret = _this->GetPhysicsVolume();
			return ___ret;
			
		}
		static void SetHiddenInGame(USceneComponent* _this,int32 NewHidden,int32 bPropagateToChildren)
		{
			_this->SetHiddenInGame(NewHidden>0?true:false,bPropagateToChildren>0?true:false);
			
		}
		static void ToggleVisibility(USceneComponent* _this,int32 bPropagateToChildren)
		{
			_this->ToggleVisibility(bPropagateToChildren>0?true:false);
			
		}
		static void SetVisibility(USceneComponent* _this,int32 bNewVisibility,int32 bPropagateToChildren)
		{
			_this->SetVisibility(bNewVisibility>0?true:false,bPropagateToChildren>0?true:false);
			
		}
		static int32 IsVisible(USceneComponent* _this)
		{
			bool ___ret = _this->IsVisible();
			return ___ret?1:0;
			
		}
		static FVector GetComponentVelocity(USceneComponent* _this)
		{
			FVector ___ret = _this->GetComponentVelocity();
			return ___ret;
			
		}
		static int32 DoesSocketExist(USceneComponent* _this,MonoString* InSocketName)
		{
			FName InSocketName_temp=MonoStringToFName(InSocketName);
			bool ___ret = _this->DoesSocketExist(InSocketName_temp);
			return ___ret?1:0;
			
		}
		static FRotator GetSocketRotation(USceneComponent* _this,MonoString* InSocketName)
		{
			FName InSocketName_temp=MonoStringToFName(InSocketName);
			FRotator ___ret = _this->GetSocketRotation(InSocketName_temp);
			return ___ret;
			
		}
		static FVector GetSocketLocation(USceneComponent* _this,MonoString* InSocketName)
		{
			FName InSocketName_temp=MonoStringToFName(InSocketName);
			FVector ___ret = _this->GetSocketLocation(InSocketName_temp);
			return ___ret;
			
		}
		static FTransform GetSocketTransform(USceneComponent* _this,MonoString* InSocketName,int32 TransformSpace)
		{
			FName InSocketName_temp=MonoStringToFName(InSocketName);
			FTransform ___ret = _this->GetSocketTransform(InSocketName_temp,(TEnumAsByte<ERelativeTransformSpace>)TransformSpace);
			return ___ret;
			
		}
		static MonoArray* GetAllSocketNames(USceneComponent* _this)
		{
			TArray<FName> ___ret = _this->GetAllSocketNames();
			return TArrayToMonoArray(___ret,"UnrealEngine.FName,UnrealEngine");
			
		}
		static void DetachFromParent(USceneComponent* _this,int32 bMaintainWorldPosition,int32 bCallModify)
		{
			_this->DetachFromParent(bMaintainWorldPosition>0?true:false,bCallModify>0?true:false);
			
		}
		static int32 K2_AttachTo(USceneComponent* _this,USceneComponent* InParent,MonoString* InSocketName,int32 AttachType,int32 bWeldSimulatedBodies)
		{
			FName InSocketName_temp=MonoStringToFName(InSocketName);
			bool ___ret = _this->K2_AttachTo(InParent,InSocketName_temp,(TEnumAsByte<EAttachLocation::Type>)AttachType,bWeldSimulatedBodies>0?true:false);
			return ___ret?1:0;
			
		}
		static void GetChildrenComponents(USceneComponent* _this,int32 bIncludeAllDescendants,MonoArray** Children)
		{
			TArray<USceneComponent*> Children_temp;
			_this->GetChildrenComponents(bIncludeAllDescendants>0?true:false,Children_temp);
			*Children=TArrayToMonoArray(Children_temp,"System.IntPtr,mscorlib");
			
		}
		static USceneComponent* GetChildComponent(USceneComponent* _this,int32 ChildIndex)
		{
			USceneComponent* ___ret = _this->GetChildComponent(ChildIndex);
			return ___ret;
			
		}
		static int32 GetNumChildrenComponents(USceneComponent* _this)
		{
			int32 ___ret = _this->GetNumChildrenComponents();
			return ___ret;
			
		}
		static void GetParentComponents(USceneComponent* _this,MonoArray** Parents)
		{
			TArray<USceneComponent*> Parents_temp;
			_this->GetParentComponents(Parents_temp);
			*Parents=TArrayToMonoArray(Parents_temp,"System.IntPtr,mscorlib");
			
		}
		static MonoString* GetAttachSocketName(USceneComponent* _this)
		{
			FName ___ret = _this->GetAttachSocketName();
			return FNameToMonoString(___ret);
			
		}
		static USceneComponent* GetAttachParent(USceneComponent* _this)
		{
			USceneComponent* ___ret = _this->GetAttachParent();
			return ___ret;
			
		}
		static int32 IsAnySimulatingPhysics(USceneComponent* _this)
		{
			bool ___ret = _this->IsAnySimulatingPhysics();
			return ___ret?1:0;
			
		}
		static int32 IsSimulatingPhysics(USceneComponent* _this,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			bool ___ret = _this->IsSimulatingPhysics(BoneName_temp);
			return ___ret?1:0;
			
		}
		static FVector GetRightVector(USceneComponent* _this)
		{
			FVector ___ret = _this->GetRightVector();
			return ___ret;
			
		}
		static FVector GetUpVector(USceneComponent* _this)
		{
			FVector ___ret = _this->GetUpVector();
			return ___ret;
			
		}
		static FVector GetForwardVector(USceneComponent* _this)
		{
			FVector ___ret = _this->GetForwardVector();
			return ___ret;
			
		}
		static FTransform K2_GetComponentToWorld(USceneComponent* _this)
		{
			FTransform ___ret = _this->K2_GetComponentToWorld();
			return ___ret;
			
		}
		static FVector K2_GetComponentScale(USceneComponent* _this)
		{
			FVector ___ret = _this->K2_GetComponentScale();
			return ___ret;
			
		}
		static FRotator K2_GetComponentRotation(USceneComponent* _this)
		{
			FRotator ___ret = _this->K2_GetComponentRotation();
			return ___ret;
			
		}
		static FVector K2_GetComponentLocation(USceneComponent* _this)
		{
			FVector ___ret = _this->K2_GetComponentLocation();
			return ___ret;
			
		}
		static void K2_AddWorldTransform(USceneComponent* _this,FTransform* DeltaTransform,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_AddWorldTransform(*DeltaTransform,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void K2_AddWorldRotation(USceneComponent* _this,FRotator* DeltaRotation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_AddWorldRotation(*DeltaRotation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void K2_AddWorldOffset(USceneComponent* _this,FVector* DeltaLocation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_AddWorldOffset(*DeltaLocation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void K2_SetWorldTransform(USceneComponent* _this,FTransform* NewTransform,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_SetWorldTransform(*NewTransform,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void SetWorldScale3D(USceneComponent* _this,FVector* NewScale)
		{
			_this->SetWorldScale3D(*NewScale);
			
		}
		static void K2_SetWorldRotation(USceneComponent* _this,FRotator* NewRotation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_SetWorldRotation(*NewRotation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void K2_SetWorldLocation(USceneComponent* _this,FVector* NewLocation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_SetWorldLocation(*NewLocation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void K2_AddLocalTransform(USceneComponent* _this,FTransform* DeltaTransform,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_AddLocalTransform(*DeltaTransform,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void K2_AddLocalRotation(USceneComponent* _this,FRotator* DeltaRotation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_AddLocalRotation(*DeltaRotation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void K2_AddLocalOffset(USceneComponent* _this,FVector* DeltaLocation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_AddLocalOffset(*DeltaLocation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void K2_AddRelativeRotation(USceneComponent* _this,FRotator* DeltaRotation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_AddRelativeRotation(*DeltaRotation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void K2_AddRelativeLocation(USceneComponent* _this,FVector* DeltaLocation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_AddRelativeLocation(*DeltaLocation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void SetRelativeScale3D(USceneComponent* _this,FVector* NewScale3D)
		{
			_this->SetRelativeScale3D(*NewScale3D);
			
		}
		static void ResetRelativeTransform(USceneComponent* _this)
		{
			_this->ResetRelativeTransform();
			
		}
		static FTransform GetRelativeTransform(USceneComponent* _this)
		{
			FTransform ___ret = _this->GetRelativeTransform();
			return ___ret;
			
		}
		static void K2_SetRelativeTransform(USceneComponent* _this,FTransform* NewTransform,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_SetRelativeTransform(*NewTransform,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void K2_SetRelativeRotation(USceneComponent* _this,FRotator* NewRotation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_SetRelativeRotation(*NewRotation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void K2_SetRelativeLocation(USceneComponent* _this,FVector* NewLocation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_SetRelativeLocation(*NewLocation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static UClass* StaticClass(){return USceneComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_SetWorldLocationAndRotation",(const void*)K2_SetWorldLocationAndRotation);
			mono_add_internal_call("UnrealEngine.USceneComponent::SetAbsolute",(const void*)SetAbsolute);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_SetRelativeLocationAndRotation",(const void*)K2_SetRelativeLocationAndRotation);
			mono_add_internal_call("UnrealEngine.USceneComponent::GetPhysicsVolume",(const void*)GetPhysicsVolume);
			mono_add_internal_call("UnrealEngine.USceneComponent::SetHiddenInGame",(const void*)SetHiddenInGame);
			mono_add_internal_call("UnrealEngine.USceneComponent::ToggleVisibility",(const void*)ToggleVisibility);
			mono_add_internal_call("UnrealEngine.USceneComponent::SetVisibility",(const void*)SetVisibility);
			mono_add_internal_call("UnrealEngine.USceneComponent::IsVisible",(const void*)IsVisible);
			mono_add_internal_call("UnrealEngine.USceneComponent::GetComponentVelocity",(const void*)GetComponentVelocity);
			mono_add_internal_call("UnrealEngine.USceneComponent::DoesSocketExist",(const void*)DoesSocketExist);
			mono_add_internal_call("UnrealEngine.USceneComponent::GetSocketRotation",(const void*)GetSocketRotation);
			mono_add_internal_call("UnrealEngine.USceneComponent::GetSocketLocation",(const void*)GetSocketLocation);
			mono_add_internal_call("UnrealEngine.USceneComponent::GetSocketTransform",(const void*)GetSocketTransform);
			mono_add_internal_call("UnrealEngine.USceneComponent::GetAllSocketNames",(const void*)GetAllSocketNames);
			mono_add_internal_call("UnrealEngine.USceneComponent::DetachFromParent",(const void*)DetachFromParent);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_AttachTo",(const void*)K2_AttachTo);
			mono_add_internal_call("UnrealEngine.USceneComponent::GetChildrenComponents",(const void*)GetChildrenComponents);
			mono_add_internal_call("UnrealEngine.USceneComponent::GetChildComponent",(const void*)GetChildComponent);
			mono_add_internal_call("UnrealEngine.USceneComponent::GetNumChildrenComponents",(const void*)GetNumChildrenComponents);
			mono_add_internal_call("UnrealEngine.USceneComponent::GetParentComponents",(const void*)GetParentComponents);
			mono_add_internal_call("UnrealEngine.USceneComponent::GetAttachSocketName",(const void*)GetAttachSocketName);
			mono_add_internal_call("UnrealEngine.USceneComponent::GetAttachParent",(const void*)GetAttachParent);
			mono_add_internal_call("UnrealEngine.USceneComponent::IsAnySimulatingPhysics",(const void*)IsAnySimulatingPhysics);
			mono_add_internal_call("UnrealEngine.USceneComponent::IsSimulatingPhysics",(const void*)IsSimulatingPhysics);
			mono_add_internal_call("UnrealEngine.USceneComponent::GetRightVector",(const void*)GetRightVector);
			mono_add_internal_call("UnrealEngine.USceneComponent::GetUpVector",(const void*)GetUpVector);
			mono_add_internal_call("UnrealEngine.USceneComponent::GetForwardVector",(const void*)GetForwardVector);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_GetComponentToWorld",(const void*)K2_GetComponentToWorld);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_GetComponentScale",(const void*)K2_GetComponentScale);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_GetComponentRotation",(const void*)K2_GetComponentRotation);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_GetComponentLocation",(const void*)K2_GetComponentLocation);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_AddWorldTransform",(const void*)K2_AddWorldTransform);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_AddWorldRotation",(const void*)K2_AddWorldRotation);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_AddWorldOffset",(const void*)K2_AddWorldOffset);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_SetWorldTransform",(const void*)K2_SetWorldTransform);
			mono_add_internal_call("UnrealEngine.USceneComponent::SetWorldScale3D",(const void*)SetWorldScale3D);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_SetWorldRotation",(const void*)K2_SetWorldRotation);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_SetWorldLocation",(const void*)K2_SetWorldLocation);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_AddLocalTransform",(const void*)K2_AddLocalTransform);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_AddLocalRotation",(const void*)K2_AddLocalRotation);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_AddLocalOffset",(const void*)K2_AddLocalOffset);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_AddRelativeRotation",(const void*)K2_AddRelativeRotation);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_AddRelativeLocation",(const void*)K2_AddRelativeLocation);
			mono_add_internal_call("UnrealEngine.USceneComponent::SetRelativeScale3D",(const void*)SetRelativeScale3D);
			mono_add_internal_call("UnrealEngine.USceneComponent::ResetRelativeTransform",(const void*)ResetRelativeTransform);
			mono_add_internal_call("UnrealEngine.USceneComponent::GetRelativeTransform",(const void*)GetRelativeTransform);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_SetRelativeTransform",(const void*)K2_SetRelativeTransform);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_SetRelativeRotation",(const void*)K2_SetRelativeRotation);
			mono_add_internal_call("UnrealEngine.USceneComponent::K2_SetRelativeLocation",(const void*)K2_SetRelativeLocation);
			mono_add_internal_call("UnrealEngine.USceneComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
