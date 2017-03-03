#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Pawn is the base class of all actors that can be possessed by players or AI.
	/// They are the physical representations of players and creatures in a level.
	/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Framework/Pawn/
	/// </summary>
	public partial class APawn
	{
		static readonly int bUseControllerRotationPitch__Offset;
		/// <summary>If true, this Pawn's pitch will be updated to match the Controller's ControlRotation pitch, if controlled by a PlayerController.</summary>
		public bool bUseControllerRotationPitch
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseControllerRotationPitch__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseControllerRotationPitch__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bUseControllerRotationYaw__Offset;
		/// <summary>If true, this Pawn's yaw will be updated to match the Controller's ControlRotation yaw, if controlled by a PlayerController.</summary>
		public bool bUseControllerRotationYaw
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseControllerRotationYaw__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseControllerRotationYaw__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bUseControllerRotationRoll__Offset;
		/// <summary>If true, this Pawn's roll will be updated to match the Controller's ControlRotation roll, if controlled by a PlayerController.</summary>
		public bool bUseControllerRotationRoll
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseControllerRotationRoll__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseControllerRotationRoll__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bCanAffectNavigationGeneration__Offset;
		/// <summary>
		/// If set to false (default) given pawn instance will never affect navigation generation.
		///     Setting it to true will result in using regular AActor's navigation relevancy
		///     calculation to check if this pawn instance should affect navigation generation
		///     Use SetCanAffectNavigationGeneration to change this value at runtime.
		///     Note that modifying this value at runtime will result in any navigation change only if runtime navigation generation is enabled.
		/// </summary>
		public bool bCanAffectNavigationGeneration
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanAffectNavigationGeneration__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCanAffectNavigationGeneration__Offset, 1,0,8,8);}
			
		}
		
		static readonly int BaseEyeHeight__Offset;
		/// <summary>Base eye height above collision center.</summary>
		public float BaseEyeHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BaseEyeHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BaseEyeHeight__Offset, false);}
			
		}
		
		static readonly int AutoPossessPlayer__Offset;
		/// <summary>
		/// Determines which PlayerController, if any, should automatically possess the pawn when the level starts or when the pawn is spawned.
		/// @see AutoPossessAI
		/// </summary>
		public EAutoReceiveInput AutoPossessPlayer
		{
			get{ CheckIsValid();return (EAutoReceiveInput)Marshal.PtrToStructure(_this.Get()+AutoPossessPlayer__Offset, typeof(EAutoReceiveInput));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AutoPossessPlayer__Offset, false);}
			
		}
		
		static readonly int AIControllerClass__Offset;
		/// <summary>Default class to use when pawn is controlled by AI.</summary>
		public TSubclassOf<AController>  AIControllerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AIControllerClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + AIControllerClass__Offset, value); }
			
		}
		
		static readonly int PlayerState__Offset;
		/// <summary>If Pawn is possessed by a player, points to his playerstate.  Needed for network play as controllers are not replicated to clients.</summary>
		public APlayerState PlayerState
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlayerState__Offset); if (v == IntPtr.Zero)return null; APlayerState retValue = new APlayerState(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int RemoteViewPitch__Offset;
		/// <summary>Replicated so we can see where remote clients are looking.</summary>
		public byte RemoteViewPitch
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+RemoteViewPitch__Offset, typeof(byte));}
			
		}
		
		static readonly int LastHitBy__Offset;
		/// <summary>Controller of the last Actor that caused us damage.</summary>
		public AController LastHitBy
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LastHitBy__Offset); if (v == IntPtr.Zero)return null; AController retValue = new AController(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Controller__Offset;
		/// <summary>Controller currently possessing this Actor</summary>
		public AController Controller
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Controller__Offset); if (v == IntPtr.Zero)return null; AController retValue = new AController(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ControlInputVector__Offset;
		/// <summary>
		/// Accumulated control input vector, stored in world space. This is the pending input, which is cleared (zeroed) once consumed.
		/// @see GetPendingMovementInputVector(), AddMovementInput()
		/// </summary>
		public FVector ControlInputVector
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+ControlInputVector__Offset, typeof(FVector));}
			
		}
		
		static readonly int LastControlInputVector__Offset;
		/// <summary>
		/// The last control input vector that was processed by ConsumeMovementInputVector().
		/// @see GetLastMovementInputVector()
		/// </summary>
		public FVector LastControlInputVector
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LastControlInputVector__Offset, typeof(FVector));}
			
		}
		
		static APawn()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Pawn");
			bUseControllerRotationPitch__Offset=GetPropertyOffset(NativeClassPtr,"bUseControllerRotationPitch");
			bUseControllerRotationYaw__Offset=GetPropertyOffset(NativeClassPtr,"bUseControllerRotationYaw");
			bUseControllerRotationRoll__Offset=GetPropertyOffset(NativeClassPtr,"bUseControllerRotationRoll");
			bCanAffectNavigationGeneration__Offset=GetPropertyOffset(NativeClassPtr,"bCanAffectNavigationGeneration");
			BaseEyeHeight__Offset=GetPropertyOffset(NativeClassPtr,"BaseEyeHeight");
			AutoPossessPlayer__Offset=GetPropertyOffset(NativeClassPtr,"AutoPossessPlayer");
			AIControllerClass__Offset=GetPropertyOffset(NativeClassPtr,"AIControllerClass");
			PlayerState__Offset=GetPropertyOffset(NativeClassPtr,"PlayerState");
			RemoteViewPitch__Offset=GetPropertyOffset(NativeClassPtr,"RemoteViewPitch");
			LastHitBy__Offset=GetPropertyOffset(NativeClassPtr,"LastHitBy");
			Controller__Offset=GetPropertyOffset(NativeClassPtr,"Controller");
			ControlInputVector__Offset=GetPropertyOffset(NativeClassPtr,"ControlInputVector");
			LastControlInputVector__Offset=GetPropertyOffset(NativeClassPtr,"LastControlInputVector");
			
		}
		
	}
	
}
#endif
#endif
