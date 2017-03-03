#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USkeletalMeshComponent
	{
		static readonly int AnimationMode__Offset;
		public EAnimationMode AnimationMode
		{
			get{ CheckIsValid();return (EAnimationMode)Marshal.PtrToStructure(_this.Get()+AnimationMode__Offset, typeof(EAnimationMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AnimationMode__Offset, false);}
			
		}
		
		static readonly int AnimBlueprintGeneratedClass__Offset;
		public UClass AnimBlueprintGeneratedClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AnimBlueprintGeneratedClass__Offset); return v; }
			
		}
		
		static readonly int AnimClass__Offset;
		public TSubclassOf<UAnimInstance>  AnimClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AnimClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + AnimClass__Offset, value); }
			
		}
		
		static readonly int AnimScriptInstance__Offset;
		public UAnimInstance AnimScriptInstance
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AnimScriptInstance__Offset); if (v == IntPtr.Zero)return null; UAnimInstance retValue = new UAnimInstance(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SubInstances__Offset;
		public TObjectArray<UAnimInstance>  SubInstances
		{
					get{ CheckIsValid();return new TObjectArray<UAnimInstance>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SubInstances__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SubInstances__Offset, false);}
			
		}
		
		static readonly int PostProcessAnimInstance__Offset;
		public UAnimInstance PostProcessAnimInstance
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PostProcessAnimInstance__Offset); if (v == IntPtr.Zero)return null; UAnimInstance retValue = new UAnimInstance(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AnimationData__Offset;
		public FSingleAnimationPlayData AnimationData
		{
			get{ CheckIsValid();return (FSingleAnimationPlayData)Marshal.PtrToStructure(_this.Get()+AnimationData__Offset, typeof(FSingleAnimationPlayData));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AnimationData__Offset, false);}
			
		}
		
		static readonly int CachedBoneSpaceTransforms__Offset;
		public TStructArray<FTransform> CachedBoneSpaceTransforms
		{
			get{ CheckIsValid();return new TStructArray<FTransform>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CachedBoneSpaceTransforms__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CachedBoneSpaceTransforms__Offset, false);}
			
		}
		
		static readonly int CachedComponentSpaceTransforms__Offset;
		public TStructArray<FTransform> CachedComponentSpaceTransforms
		{
			get{ CheckIsValid();return new TStructArray<FTransform>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CachedComponentSpaceTransforms__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CachedComponentSpaceTransforms__Offset, false);}
			
		}
		
		static readonly int GlobalAnimRateScale__Offset;
		public float GlobalAnimRateScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+GlobalAnimRateScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GlobalAnimRateScale__Offset, false);}
			
		}
		
		static readonly int bHasValidBodies__Offset;
		public bool bHasValidBodies
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasValidBodies__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int KinematicBonesUpdateType__Offset;
		public EKinematicBonesUpdateToPhysics KinematicBonesUpdateType
		{
			get{ CheckIsValid();return (EKinematicBonesUpdateToPhysics)Marshal.PtrToStructure(_this.Get()+KinematicBonesUpdateType__Offset, typeof(EKinematicBonesUpdateToPhysics));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+KinematicBonesUpdateType__Offset, false);}
			
		}
		
		static readonly int PhysicsTransformUpdateMode__Offset;
		public EPhysicsTransformUpdateMode PhysicsTransformUpdateMode
		{
			get{ CheckIsValid();return (EPhysicsTransformUpdateMode)Marshal.PtrToStructure(_this.Get()+PhysicsTransformUpdateMode__Offset, typeof(EPhysicsTransformUpdateMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PhysicsTransformUpdateMode__Offset, false);}
			
		}
		
		static readonly int bBlendPhysics__Offset;
		public bool bBlendPhysics
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bBlendPhysics__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bEnablePhysicsOnDedicatedServer__Offset;
		public bool bEnablePhysicsOnDedicatedServer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnablePhysicsOnDedicatedServer__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnablePhysicsOnDedicatedServer__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bUpdateJointsFromAnimation__Offset;
		public bool bUpdateJointsFromAnimation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUpdateJointsFromAnimation__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUpdateJointsFromAnimation__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bDisableClothSimulation__Offset;
		public bool bDisableClothSimulation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableClothSimulation__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableClothSimulation__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bCollideWithEnvironment__Offset;
		public bool bCollideWithEnvironment
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCollideWithEnvironment__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCollideWithEnvironment__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bCollideWithAttachedChildren__Offset;
		public bool bCollideWithAttachedChildren
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCollideWithAttachedChildren__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCollideWithAttachedChildren__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bLocalSpaceSimulation__Offset;
		public bool bLocalSpaceSimulation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLocalSpaceSimulation__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLocalSpaceSimulation__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bClothMorphTarget__Offset;
		public bool bClothMorphTarget
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClothMorphTarget__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bClothMorphTarget__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bResetAfterTeleport__Offset;
		public bool bResetAfterTeleport
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bResetAfterTeleport__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bResetAfterTeleport__Offset, 1,0,1,1);}
			
		}
		
		static readonly int TeleportDistanceThreshold__Offset;
		public float TeleportDistanceThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TeleportDistanceThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TeleportDistanceThreshold__Offset, false);}
			
		}
		
		static readonly int TeleportRotationThreshold__Offset;
		public float TeleportRotationThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TeleportRotationThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TeleportRotationThreshold__Offset, false);}
			
		}
		
		static readonly int ClothBlendWeight__Offset;
		public float ClothBlendWeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ClothBlendWeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ClothBlendWeight__Offset, false);}
			
		}
		
		static readonly int RootBoneTranslation__Offset;
		public FVector RootBoneTranslation
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+RootBoneTranslation__Offset, typeof(FVector));}
			
		}
		
		static readonly int bNoSkeletonUpdate__Offset;
		public bool bNoSkeletonUpdate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNoSkeletonUpdate__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNoSkeletonUpdate__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bPauseAnims__Offset;
		public bool bPauseAnims
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPauseAnims__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPauseAnims__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bUseRefPoseOnInitAnim__Offset;
		public bool bUseRefPoseOnInitAnim
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseRefPoseOnInitAnim__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseRefPoseOnInitAnim__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bEnablePerPolyCollision__Offset;
		public bool bEnablePerPolyCollision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnablePerPolyCollision__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnablePerPolyCollision__Offset, 1,0,1,1);}
			
		}
		
		static readonly int BodySetup__Offset;
		public UBodySetup BodySetup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BodySetup__Offset); if (v == IntPtr.Zero)return null; UBodySetup retValue = new UBodySetup(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bOnlyAllowAutonomousTickPose__Offset;
		public bool bOnlyAllowAutonomousTickPose
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOnlyAllowAutonomousTickPose__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bIsAutonomousTickPose__Offset;
		public bool bIsAutonomousTickPose
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsAutonomousTickPose__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bForceRefpose__Offset;
		public bool bForceRefpose
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceRefpose__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bOldForceRefPose__Offset;
		public bool bOldForceRefPose
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOldForceRefPose__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bShowPrePhysBones__Offset;
		public bool bShowPrePhysBones
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowPrePhysBones__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bRequiredBonesUpToDate__Offset;
		public bool bRequiredBonesUpToDate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRequiredBonesUpToDate__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bAnimTreeInitialised__Offset;
		public bool bAnimTreeInitialised
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAnimTreeInitialised__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bIncludeComponentLocationIntoBounds__Offset;
		public bool bIncludeComponentLocationIntoBounds
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIncludeComponentLocationIntoBounds__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIncludeComponentLocationIntoBounds__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bEnableLineCheckWithBounds__Offset;
		public bool bEnableLineCheckWithBounds
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableLineCheckWithBounds__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int CachedAnimCurveUidVersion__Offset;
		public ushort CachedAnimCurveUidVersion
		{
			get{ CheckIsValid();return (ushort)Marshal.PtrToStructure(_this.Get()+CachedAnimCurveUidVersion__Offset, typeof(ushort));}
			
		}
		
		static readonly int LineCheckBoundsScale__Offset;
		public FVector LineCheckBoundsScale
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LineCheckBoundsScale__Offset, typeof(FVector));}
			
		}
		
		static readonly int OnConstraintBroken__Offset;
		public FMulticastScriptDelegate OnConstraintBroken
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnConstraintBroken__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnConstraintBroken__Offset, false);}
			
		}
		
		static readonly int SequenceToPlay__Offset;
		public UAnimSequence SequenceToPlay
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SequenceToPlay__Offset); if (v == IntPtr.Zero)return null; UAnimSequence retValue = new UAnimSequence(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AnimToPlay__Offset;
		public UAnimationAsset AnimToPlay
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AnimToPlay__Offset); if (v == IntPtr.Zero)return null; UAnimationAsset retValue = new UAnimationAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bDefaultLooping__Offset;
		public bool bDefaultLooping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultLooping__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bDefaultPlaying__Offset;
		public bool bDefaultPlaying
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultPlaying__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int DefaultPosition__Offset;
		public float DefaultPosition
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultPosition__Offset, typeof(float));}
			
		}
		
		static readonly int DefaultPlayRate__Offset;
		public float DefaultPlayRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultPlayRate__Offset, typeof(float));}
			
		}
		
		static readonly int LastPoseTickTime__Offset;
		public float LastPoseTickTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastPoseTickTime__Offset, typeof(float));}
			
		}
		
		static USkeletalMeshComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SkeletalMeshComponent");
			AnimationMode__Offset=GetPropertyOffset(NativeClassPtr,"AnimationMode");
			AnimBlueprintGeneratedClass__Offset=GetPropertyOffset(NativeClassPtr,"AnimBlueprintGeneratedClass");
			AnimClass__Offset=GetPropertyOffset(NativeClassPtr,"AnimClass");
			AnimScriptInstance__Offset=GetPropertyOffset(NativeClassPtr,"AnimScriptInstance");
			SubInstances__Offset=GetPropertyOffset(NativeClassPtr,"SubInstances");
			PostProcessAnimInstance__Offset=GetPropertyOffset(NativeClassPtr,"PostProcessAnimInstance");
			AnimationData__Offset=GetPropertyOffset(NativeClassPtr,"AnimationData");
			CachedBoneSpaceTransforms__Offset=GetPropertyOffset(NativeClassPtr,"CachedBoneSpaceTransforms");
			CachedComponentSpaceTransforms__Offset=GetPropertyOffset(NativeClassPtr,"CachedComponentSpaceTransforms");
			GlobalAnimRateScale__Offset=GetPropertyOffset(NativeClassPtr,"GlobalAnimRateScale");
			bHasValidBodies__Offset=GetPropertyOffset(NativeClassPtr,"bHasValidBodies");
			KinematicBonesUpdateType__Offset=GetPropertyOffset(NativeClassPtr,"KinematicBonesUpdateType");
			PhysicsTransformUpdateMode__Offset=GetPropertyOffset(NativeClassPtr,"PhysicsTransformUpdateMode");
			bBlendPhysics__Offset=GetPropertyOffset(NativeClassPtr,"bBlendPhysics");
			bEnablePhysicsOnDedicatedServer__Offset=GetPropertyOffset(NativeClassPtr,"bEnablePhysicsOnDedicatedServer");
			bUpdateJointsFromAnimation__Offset=GetPropertyOffset(NativeClassPtr,"bUpdateJointsFromAnimation");
			bDisableClothSimulation__Offset=GetPropertyOffset(NativeClassPtr,"bDisableClothSimulation");
			bCollideWithEnvironment__Offset=GetPropertyOffset(NativeClassPtr,"bCollideWithEnvironment");
			bCollideWithAttachedChildren__Offset=GetPropertyOffset(NativeClassPtr,"bCollideWithAttachedChildren");
			bLocalSpaceSimulation__Offset=GetPropertyOffset(NativeClassPtr,"bLocalSpaceSimulation");
			bClothMorphTarget__Offset=GetPropertyOffset(NativeClassPtr,"bClothMorphTarget");
			bResetAfterTeleport__Offset=GetPropertyOffset(NativeClassPtr,"bResetAfterTeleport");
			TeleportDistanceThreshold__Offset=GetPropertyOffset(NativeClassPtr,"TeleportDistanceThreshold");
			TeleportRotationThreshold__Offset=GetPropertyOffset(NativeClassPtr,"TeleportRotationThreshold");
			ClothBlendWeight__Offset=GetPropertyOffset(NativeClassPtr,"ClothBlendWeight");
			RootBoneTranslation__Offset=GetPropertyOffset(NativeClassPtr,"RootBoneTranslation");
			bNoSkeletonUpdate__Offset=GetPropertyOffset(NativeClassPtr,"bNoSkeletonUpdate");
			bPauseAnims__Offset=GetPropertyOffset(NativeClassPtr,"bPauseAnims");
			bUseRefPoseOnInitAnim__Offset=GetPropertyOffset(NativeClassPtr,"bUseRefPoseOnInitAnim");
			bEnablePerPolyCollision__Offset=GetPropertyOffset(NativeClassPtr,"bEnablePerPolyCollision");
			BodySetup__Offset=GetPropertyOffset(NativeClassPtr,"BodySetup");
			bOnlyAllowAutonomousTickPose__Offset=GetPropertyOffset(NativeClassPtr,"bOnlyAllowAutonomousTickPose");
			bIsAutonomousTickPose__Offset=GetPropertyOffset(NativeClassPtr,"bIsAutonomousTickPose");
			bForceRefpose__Offset=GetPropertyOffset(NativeClassPtr,"bForceRefpose");
			bOldForceRefPose__Offset=GetPropertyOffset(NativeClassPtr,"bOldForceRefPose");
			bShowPrePhysBones__Offset=GetPropertyOffset(NativeClassPtr,"bShowPrePhysBones");
			bRequiredBonesUpToDate__Offset=GetPropertyOffset(NativeClassPtr,"bRequiredBonesUpToDate");
			bAnimTreeInitialised__Offset=GetPropertyOffset(NativeClassPtr,"bAnimTreeInitialised");
			bIncludeComponentLocationIntoBounds__Offset=GetPropertyOffset(NativeClassPtr,"bIncludeComponentLocationIntoBounds");
			bEnableLineCheckWithBounds__Offset=GetPropertyOffset(NativeClassPtr,"bEnableLineCheckWithBounds");
			CachedAnimCurveUidVersion__Offset=GetPropertyOffset(NativeClassPtr,"CachedAnimCurveUidVersion");
			LineCheckBoundsScale__Offset=GetPropertyOffset(NativeClassPtr,"LineCheckBoundsScale");
			OnConstraintBroken__Offset=GetPropertyOffset(NativeClassPtr,"OnConstraintBroken");
			SequenceToPlay__Offset=GetPropertyOffset(NativeClassPtr,"SequenceToPlay");
			AnimToPlay__Offset=GetPropertyOffset(NativeClassPtr,"AnimToPlay");
			bDefaultLooping__Offset=GetPropertyOffset(NativeClassPtr,"bDefaultLooping");
			bDefaultPlaying__Offset=GetPropertyOffset(NativeClassPtr,"bDefaultPlaying");
			DefaultPosition__Offset=GetPropertyOffset(NativeClassPtr,"DefaultPosition");
			DefaultPlayRate__Offset=GetPropertyOffset(NativeClassPtr,"DefaultPlayRate");
			LastPoseTickTime__Offset=GetPropertyOffset(NativeClassPtr,"LastPoseTickTime");
			
		}
		
	}
	
}
#endif
#endif
