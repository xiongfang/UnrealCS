#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Characters are Pawns that have a mesh, collision, and built-in movement logic.
	/// They are responsible for all physical interaction between the player or AI and the world, and also implement basic networking and input models.
	/// They are designed for a vertically-oriented player representation that can walk, jump, fly, and swim through the world using CharacterMovementComponent.
	/// @see APawn, UCharacterMovementComponent
	/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Framework/Pawn/Character/
	/// </summary>
	public partial class ACharacter
	{
		static readonly int Mesh__Offset;
		/// <summary>The main skeletal mesh associated with this Character (optional sub-object).</summary>
		public USkeletalMeshComponent Mesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Mesh__Offset); if (v == IntPtr.Zero)return null; USkeletalMeshComponent retValue = new USkeletalMeshComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Mesh__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Mesh__Offset, value._this.Get()); }
			
		}
		
		static readonly int ArrowComponent__Offset;
		public UArrowComponent ArrowComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ArrowComponent__Offset); if (v == IntPtr.Zero)return null; UArrowComponent retValue = new UArrowComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CharacterMovement__Offset;
		/// <summary>Movement component used for movement logic in various movement modes (walking, falling, etc), containing relevant settings and functions to control movement.</summary>
		public UCharacterMovementComponent CharacterMovement
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CharacterMovement__Offset); if (v == IntPtr.Zero)return null; UCharacterMovementComponent retValue = new UCharacterMovementComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + CharacterMovement__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + CharacterMovement__Offset, value._this.Get()); }
			
		}
		
		static readonly int CapsuleComponent__Offset;
		/// <summary>The CapsuleComponent being used for movement collision (by CharacterMovement). Always treated as being vertically aligned in simple collision check functions.</summary>
		public UCapsuleComponent CapsuleComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CapsuleComponent__Offset); if (v == IntPtr.Zero)return null; UCapsuleComponent retValue = new UCapsuleComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + CapsuleComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + CapsuleComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int BasedMovement__Offset;
		/// <summary>Info about our current movement base (object we are standing on).</summary>
		public FBasedMovementInfo BasedMovement
		{
			get{ CheckIsValid();return (FBasedMovementInfo)Marshal.PtrToStructure(_this.Get()+BasedMovement__Offset, typeof(FBasedMovementInfo));}
			
		}
		
		static readonly int ReplicatedBasedMovement__Offset;
		/// <summary>Replicated version of relative movement. Read-only on simulated proxies!</summary>
		public FBasedMovementInfo ReplicatedBasedMovement
		{
			get{ CheckIsValid();return (FBasedMovementInfo)Marshal.PtrToStructure(_this.Get()+ReplicatedBasedMovement__Offset, typeof(FBasedMovementInfo));}
			
		}
		
		static readonly int AnimRootMotionTranslationScale__Offset;
		/// <summary>Scale to apply to root motion translation on this Character</summary>
		public float AnimRootMotionTranslationScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AnimRootMotionTranslationScale__Offset, typeof(float));}
			
		}
		
		static readonly int BaseTranslationOffset__Offset;
		/// <summary>Saved translation offset of mesh.</summary>
		public FVector BaseTranslationOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+BaseTranslationOffset__Offset, typeof(FVector));}
			
		}
		
		static readonly int BaseRotationOffset__Offset;
		/// <summary>Saved rotation offset of mesh.</summary>
		public FQuat BaseRotationOffset
		{
			get{ CheckIsValid();return (FQuat)Marshal.PtrToStructure(_this.Get()+BaseRotationOffset__Offset, typeof(FQuat));}
			
		}
		
		static readonly int ReplicatedServerLastTransformUpdateTimeStamp__Offset;
		/// <summary>CharacterMovement ServerLastTransformUpdateTimeStamp value, replicated to simulated proxies.</summary>
		public float ReplicatedServerLastTransformUpdateTimeStamp
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ReplicatedServerLastTransformUpdateTimeStamp__Offset, typeof(float));}
			
		}
		
		static readonly int ReplicatedMovementMode__Offset;
		/// <summary>CharacterMovement MovementMode (and custom mode) replicated for simulated proxies. Use CharacterMovementComponent::UnpackNetworkMovementMode() to translate it.</summary>
		public byte ReplicatedMovementMode
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+ReplicatedMovementMode__Offset, typeof(byte));}
			
		}
		
		static readonly int bInBaseReplication__Offset;
		/// <summary>Flag that we are receiving replication of the based movement.</summary>
		public bool bInBaseReplication
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInBaseReplication__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int CrouchedEyeHeight__Offset;
		/// <summary>Default crouched eye height</summary>
		public float CrouchedEyeHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CrouchedEyeHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CrouchedEyeHeight__Offset, false);}
			
		}
		
		static readonly int bIsCrouched__Offset;
		/// <summary>Set by character movement to specify that this Character is currently crouched.</summary>
		public bool bIsCrouched
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsCrouched__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bPressedJump__Offset;
		/// <summary>When true, player wants to jump</summary>
		public bool bPressedJump
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPressedJump__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bClientUpdating__Offset;
		/// <summary>When true, applying updates to network client (replaying saved moves for a locally controlled character)</summary>
		public bool bClientUpdating
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClientUpdating__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bClientWasFalling__Offset;
		/// <summary>True if Pawn was initially falling when started to replay network moves.</summary>
		public bool bClientWasFalling
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClientWasFalling__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bClientResimulateRootMotion__Offset;
		/// <summary>If server disagrees with root motion track position, client has to resimulate root motion from last AckedMove.</summary>
		public bool bClientResimulateRootMotion
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClientResimulateRootMotion__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bClientResimulateRootMotionSources__Offset;
		/// <summary>If server disagrees with root motion state, client has to resimulate root motion from last AckedMove.</summary>
		public bool bClientResimulateRootMotionSources
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClientResimulateRootMotionSources__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bSimGravityDisabled__Offset;
		/// <summary>Disable simulated gravity (set when character encroaches geometry on client, to keep him from falling through floors)</summary>
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
		/// <summary>Disable root motion on the server. When receiving a DualServerMove, where the first move is not root motion and the second is.</summary>
		public bool bServerMoveIgnoreRootMotion
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bServerMoveIgnoreRootMotion__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int JumpKeyHoldTime__Offset;
		/// <summary>
		/// Jump key Held Time.
		/// This is the time that the player has held the jump key, in seconds.
		/// </summary>
		public float JumpKeyHoldTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+JumpKeyHoldTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+JumpKeyHoldTime__Offset, false);}
			
		}
		
		static readonly int JumpMaxHoldTime__Offset;
		/// <summary>
		/// The max time the jump key can be held.
		/// Note that if StopJumping() is not called before the max jump hold time is reached,
		/// then the character will carry on receiving vertical velocity. Therefore it is usually
		/// best to call StopJumping() when jump input has ceased (such as a button up event).
		/// </summary>
		public float JumpMaxHoldTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+JumpMaxHoldTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+JumpMaxHoldTime__Offset, false);}
			
		}
		
		static readonly int JumpMaxCount__Offset;
		/// <summary>
		/// The max number of jumps the character can perform.
		/// Note that if JumpMaxHoldTime is non zero and StopJumping is not called, the player
		/// may be able to perform and unlimited number of jumps. Therefore it is usually
		/// best to call StopJumping() when jump input has ceased (such as a button up event).
		/// </summary>
		public int JumpMaxCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+JumpMaxCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+JumpMaxCount__Offset, false);}
			
		}
		
		static readonly int JumpCurrentCount__Offset;
		/// <summary>
		/// Tracks the current number of jumps performed.
		/// This is incremented in CheckJumpInput, used in CanJump_Implementation, and reset in OnMovementModeChanged.
		/// When providing overrides for these methods, it's recommended to either manually
		/// increment / reset this value, or call the Super:: method.
		/// </summary>
		public int JumpCurrentCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+JumpCurrentCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+JumpCurrentCount__Offset, false);}
			
		}
		
		static readonly int bWasJumping__Offset;
		/// <summary>Tracks whether or not the character was already jumping last frame.</summary>
		public bool bWasJumping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWasJumping__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bWasJumping__Offset, 1,0,2,2);}
			
		}
		
		static readonly int OnReachedJumpApex__Offset;
		/// <summary>Broadcast when Character's jump reaches its apex. Needs CharacterMovement->bNotifyApex = true</summary>
		public FMulticastScriptDelegate OnReachedJumpApex
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnReachedJumpApex__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnReachedJumpApex__Offset, false);}
			
		}
		
		static readonly int MovementModeChangedDelegate__Offset;
		/// <summary>Multicast delegate for MovementMode changing.</summary>
		public FMulticastScriptDelegate MovementModeChangedDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+MovementModeChangedDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MovementModeChangedDelegate__Offset, false);}
			
		}
		
		static readonly int OnCharacterMovementUpdated__Offset;
		/// <summary>
		/// Event triggered at the end of a CharacterMovementComponent movement update.
		/// This is the preferred event to use rather than the Tick event when performing custom updates to CharacterMovement properties based on the current state.
		/// This is mainly due to the nature of network updates, where client corrections in position from the server can cause multiple iterations of a movement update,
		/// which allows this event to update as well, while a Tick event would not.
		/// @param       DeltaSeconds            Delta time in seconds for this update
		/// @param       InitialLocation         Location at the start of the update. May be different than the current location if movement occurred.
		/// @param       InitialVelocity         Velocity at the start of the update. May be different than the current velocity.
		/// </summary>
		public FMulticastScriptDelegate OnCharacterMovementUpdated
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnCharacterMovementUpdated__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnCharacterMovementUpdated__Offset, false);}
			
		}
		
		static readonly int SavedRootMotion__Offset;
		/// <summary>
		/// For LocallyControlled Autonomous clients.
		/// During a PerformMovement() after root motion is prepared, we save it off into this and
		/// then record it into our SavedMoves.
		/// During SavedMove playback we use it as our "Previous Move" SavedRootMotion which includes
		/// last received root motion from the Server
		/// </summary>
		public FRootMotionSourceGroup SavedRootMotion
		{
			get{ CheckIsValid();return (FRootMotionSourceGroup)Marshal.PtrToStructure(_this.Get()+SavedRootMotion__Offset, typeof(FRootMotionSourceGroup));}
			
		}
		
		static readonly int ClientRootMotionParams__Offset;
		/// <summary>For LocallyControlled Autonomous clients. Saved root motion data to be used by SavedMoves.</summary>
		public FRootMotionMovementParams ClientRootMotionParams
		{
			get{ CheckIsValid();return (FRootMotionMovementParams)Marshal.PtrToStructure(_this.Get()+ClientRootMotionParams__Offset, typeof(FRootMotionMovementParams));}
			
		}
		
		static readonly int RootMotionRepMoves__Offset;
		/// <summary>Array of previously received root motion moves from the server.</summary>
		public TStructArray<FSimulatedRootMotionReplicatedMove> RootMotionRepMoves
		{
			get{ CheckIsValid();return new TStructArray<FSimulatedRootMotionReplicatedMove>((FScriptArray)Marshal.PtrToStructure(_this.Get()+RootMotionRepMoves__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+RootMotionRepMoves__Offset, false);}
			
		}
		
		static readonly int RepRootMotion__Offset;
		/// <summary>Replicated Root Motion montage</summary>
		public FRepRootMotionMontage RepRootMotion
		{
			get{ CheckIsValid();return (FRepRootMotionMontage)Marshal.PtrToStructure(_this.Get()+RepRootMotion__Offset, typeof(FRepRootMotionMontage));}
			
		}
		
		static ACharacter()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Character");
			Mesh__Offset=GetPropertyOffset(NativeClassPtr,"Mesh");
			ArrowComponent__Offset=GetPropertyOffset(NativeClassPtr,"ArrowComponent");
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
