#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ACharacter
	{
		static readonly int Mesh__Offset;
		public USkeletalMeshComponent Mesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Mesh__Offset); if (v == IntPtr.Zero)return null; USkeletalMeshComponent retValue = new USkeletalMeshComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Mesh__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Mesh__Offset, value._this.Get()); }
			
		}
		
		static readonly int CharacterMovement__Offset;
		public UCharacterMovementComponent CharacterMovement
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CharacterMovement__Offset); if (v == IntPtr.Zero)return null; UCharacterMovementComponent retValue = new UCharacterMovementComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + CharacterMovement__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + CharacterMovement__Offset, value._this.Get()); }
			
		}
		
		static readonly int CapsuleComponent__Offset;
		public UCapsuleComponent CapsuleComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CapsuleComponent__Offset); if (v == IntPtr.Zero)return null; UCapsuleComponent retValue = new UCapsuleComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + CapsuleComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + CapsuleComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int BasedMovement__Offset;
		public FBasedMovementInfo BasedMovement
		{
			get{ CheckIsValid();return (FBasedMovementInfo)Marshal.PtrToStructure(_this.Get()+BasedMovement__Offset, typeof(FBasedMovementInfo));}
			
		}
		
		static readonly int ReplicatedBasedMovement__Offset;
		public FBasedMovementInfo ReplicatedBasedMovement
		{
			get{ CheckIsValid();return (FBasedMovementInfo)Marshal.PtrToStructure(_this.Get()+ReplicatedBasedMovement__Offset, typeof(FBasedMovementInfo));}
			
		}
		
		static readonly int AnimRootMotionTranslationScale__Offset;
		public float AnimRootMotionTranslationScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AnimRootMotionTranslationScale__Offset, typeof(float));}
			
		}
		
		static readonly int BaseTranslationOffset__Offset;
		public FVector BaseTranslationOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+BaseTranslationOffset__Offset, typeof(FVector));}
			
		}
		
		static readonly int BaseRotationOffset__Offset;
		public FQuat BaseRotationOffset
		{
			get{ CheckIsValid();return (FQuat)Marshal.PtrToStructure(_this.Get()+BaseRotationOffset__Offset, typeof(FQuat));}
			
		}
		
		static readonly int ReplicatedServerLastTransformUpdateTimeStamp__Offset;
		public float ReplicatedServerLastTransformUpdateTimeStamp
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ReplicatedServerLastTransformUpdateTimeStamp__Offset, typeof(float));}
			
		}
		
		static readonly int ReplicatedMovementMode__Offset;
		public byte ReplicatedMovementMode
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+ReplicatedMovementMode__Offset, typeof(byte));}
			
		}
		
		static readonly int bInBaseReplication__Offset;
		public bool bInBaseReplication
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInBaseReplication__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int CrouchedEyeHeight__Offset;
		public float CrouchedEyeHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CrouchedEyeHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CrouchedEyeHeight__Offset, false);}
			
		}
		
		static readonly int bIsCrouched__Offset;
		public bool bIsCrouched
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsCrouched__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bPressedJump__Offset;
		public bool bPressedJump
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPressedJump__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bClientUpdating__Offset;
		public bool bClientUpdating
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClientUpdating__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bClientWasFalling__Offset;
		public bool bClientWasFalling
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClientWasFalling__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bClientResimulateRootMotion__Offset;
		public bool bClientResimulateRootMotion
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClientResimulateRootMotion__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bClientResimulateRootMotionSources__Offset;
		public bool bClientResimulateRootMotionSources
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClientResimulateRootMotionSources__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bSimGravityDisabled__Offset;
		public bool bSimGravityDisabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSimGravityDisabled__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bClientCheckEncroachmentOnNetUpdate__Offset;
		public bool bClientCheckEncroachmentOnNetUpdate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClientCheckEncroachmentOnNetUpdate__Offset, 1, 0, 128, 128);}
			
		}
		
		static readonly int bServerMoveIgnoreRootMotion__Offset;
		public bool bServerMoveIgnoreRootMotion
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bServerMoveIgnoreRootMotion__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int JumpKeyHoldTime__Offset;
		public float JumpKeyHoldTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+JumpKeyHoldTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+JumpKeyHoldTime__Offset, false);}
			
		}
		
		static readonly int JumpMaxHoldTime__Offset;
		public float JumpMaxHoldTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+JumpMaxHoldTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+JumpMaxHoldTime__Offset, false);}
			
		}
		
		static readonly int JumpMaxCount__Offset;
		public int JumpMaxCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+JumpMaxCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+JumpMaxCount__Offset, false);}
			
		}
		
		static readonly int JumpCurrentCount__Offset;
		public int JumpCurrentCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+JumpCurrentCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+JumpCurrentCount__Offset, false);}
			
		}
		
		static readonly int bWasJumping__Offset;
		public bool bWasJumping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWasJumping__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bWasJumping__Offset, 1,0,2,2);}
			
		}
		
		static readonly int OnReachedJumpApex__Offset;
		public FMulticastScriptDelegate OnReachedJumpApex
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnReachedJumpApex__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnReachedJumpApex__Offset, false);}
			
		}
		
		static readonly int MovementModeChangedDelegate__Offset;
		public FMulticastScriptDelegate MovementModeChangedDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+MovementModeChangedDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MovementModeChangedDelegate__Offset, false);}
			
		}
		
		static readonly int OnCharacterMovementUpdated__Offset;
		public FMulticastScriptDelegate OnCharacterMovementUpdated
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnCharacterMovementUpdated__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnCharacterMovementUpdated__Offset, false);}
			
		}
		
		static readonly int SavedRootMotion__Offset;
		public FRootMotionSourceGroup SavedRootMotion
		{
			get{ CheckIsValid();return (FRootMotionSourceGroup)Marshal.PtrToStructure(_this.Get()+SavedRootMotion__Offset, typeof(FRootMotionSourceGroup));}
			
		}
		
		static readonly int ClientRootMotionParams__Offset;
		public FRootMotionMovementParams ClientRootMotionParams
		{
			get{ CheckIsValid();return (FRootMotionMovementParams)Marshal.PtrToStructure(_this.Get()+ClientRootMotionParams__Offset, typeof(FRootMotionMovementParams));}
			
		}
		
		static readonly int RootMotionRepMoves__Offset;
		public TStructArray<FSimulatedRootMotionReplicatedMove> RootMotionRepMoves
		{
			get{ CheckIsValid();return new TStructArray<FSimulatedRootMotionReplicatedMove>((FScriptArray)Marshal.PtrToStructure(_this.Get()+RootMotionRepMoves__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+RootMotionRepMoves__Offset, false);}
			
		}
		
		static readonly int RepRootMotion__Offset;
		public FRepRootMotionMontage RepRootMotion
		{
			get{ CheckIsValid();return (FRepRootMotionMontage)Marshal.PtrToStructure(_this.Get()+RepRootMotion__Offset, typeof(FRepRootMotionMontage));}
			
		}
		
		static ACharacter()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Character");
			Mesh__Offset=GetPropertyOffset(NativeClassPtr,"Mesh");
			CharacterMovement__Offset=GetPropertyOffset(NativeClassPtr,"CharacterMovement");
			CapsuleComponent__Offset=GetPropertyOffset(NativeClassPtr,"CapsuleComponent");
			BasedMovement__Offset=GetPropertyOffset(NativeClassPtr,"BasedMovement");
			ReplicatedBasedMovement__Offset=GetPropertyOffset(NativeClassPtr,"ReplicatedBasedMovement");
			AnimRootMotionTranslationScale__Offset=GetPropertyOffset(NativeClassPtr,"AnimRootMotionTranslationScale");
			BaseTranslationOffset__Offset=GetPropertyOffset(NativeClassPtr,"BaseTranslationOffset");
			BaseRotationOffset__Offset=GetPropertyOffset(NativeClassPtr,"BaseRotationOffset");
			ReplicatedServerLastTransformUpdateTimeStamp__Offset=GetPropertyOffset(NativeClassPtr,"ReplicatedServerLastTransformUpdateTimeStamp");
			ReplicatedMovementMode__Offset=GetPropertyOffset(NativeClassPtr,"ReplicatedMovementMode");
			bInBaseReplication__Offset=GetPropertyOffset(NativeClassPtr,"bInBaseReplication");
			CrouchedEyeHeight__Offset=GetPropertyOffset(NativeClassPtr,"CrouchedEyeHeight");
			bIsCrouched__Offset=GetPropertyOffset(NativeClassPtr,"bIsCrouched");
			bPressedJump__Offset=GetPropertyOffset(NativeClassPtr,"bPressedJump");
			bClientUpdating__Offset=GetPropertyOffset(NativeClassPtr,"bClientUpdating");
			bClientWasFalling__Offset=GetPropertyOffset(NativeClassPtr,"bClientWasFalling");
			bClientResimulateRootMotion__Offset=GetPropertyOffset(NativeClassPtr,"bClientResimulateRootMotion");
			bClientResimulateRootMotionSources__Offset=GetPropertyOffset(NativeClassPtr,"bClientResimulateRootMotionSources");
			bSimGravityDisabled__Offset=GetPropertyOffset(NativeClassPtr,"bSimGravityDisabled");
			bClientCheckEncroachmentOnNetUpdate__Offset=GetPropertyOffset(NativeClassPtr,"bClientCheckEncroachmentOnNetUpdate");
			bServerMoveIgnoreRootMotion__Offset=GetPropertyOffset(NativeClassPtr,"bServerMoveIgnoreRootMotion");
			JumpKeyHoldTime__Offset=GetPropertyOffset(NativeClassPtr,"JumpKeyHoldTime");
			JumpMaxHoldTime__Offset=GetPropertyOffset(NativeClassPtr,"JumpMaxHoldTime");
			JumpMaxCount__Offset=GetPropertyOffset(NativeClassPtr,"JumpMaxCount");
			JumpCurrentCount__Offset=GetPropertyOffset(NativeClassPtr,"JumpCurrentCount");
			bWasJumping__Offset=GetPropertyOffset(NativeClassPtr,"bWasJumping");
			OnReachedJumpApex__Offset=GetPropertyOffset(NativeClassPtr,"OnReachedJumpApex");
			MovementModeChangedDelegate__Offset=GetPropertyOffset(NativeClassPtr,"MovementModeChangedDelegate");
			OnCharacterMovementUpdated__Offset=GetPropertyOffset(NativeClassPtr,"OnCharacterMovementUpdated");
			SavedRootMotion__Offset=GetPropertyOffset(NativeClassPtr,"SavedRootMotion");
			ClientRootMotionParams__Offset=GetPropertyOffset(NativeClassPtr,"ClientRootMotionParams");
			RootMotionRepMoves__Offset=GetPropertyOffset(NativeClassPtr,"RootMotionRepMoves");
			RepRootMotion__Offset=GetPropertyOffset(NativeClassPtr,"RepRootMotion");
			
		}
		
	}
	
}
#endif
#endif
