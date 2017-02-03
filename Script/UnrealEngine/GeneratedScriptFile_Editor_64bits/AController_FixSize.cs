#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Controllers are non-physical actors that can possess a Pawn to control
	/// its actions.  PlayerControllers are used by human players to control pawns, while
	/// AIControllers implement the artificial intelligence for the pawns they control.
	/// Controllers take control of a pawn using their Possess() method, and relinquish
	/// control of the pawn by calling UnPossess().
	/// Controllers receive notifications for many of the events occurring for the Pawn they
	/// are controlling.  This gives the controller the opportunity to implement the behavior
	/// in response to this event, intercepting the event and superseding the Pawn's default
	/// behavior.
	/// ControlRotation (accessed via GetControlRotation()), determines the viewing/aiming
	/// direction of the controlled Pawn and is affected by input such as from a mouse or gamepad.
	/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Framework/Controller/
	/// </summary>
	public partial class AController
	{
		static readonly int Pawn__Offset;
		/// <summary>Pawn currently being controlled by this controller.  Use Pawn.Possess() to take control of a pawn</summary>
		public APawn Pawn
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Pawn__Offset); if (v == IntPtr.Zero)return null; APawn retValue = new APawn(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Character__Offset;
		/// <summary>Character currently being controlled by this controller.  Value is same as Pawn if the controlled pawn is a character, otherwise NULL</summary>
		public ACharacter Character
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Character__Offset); if (v == IntPtr.Zero)return null; ACharacter retValue = new ACharacter(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PlayerState__Offset;
		/// <summary>PlayerState containing replicated information about the player using this controller (only exists for players, not NPCs).</summary>
		public APlayerState PlayerState
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlayerState__Offset); if (v == IntPtr.Zero)return null; APlayerState retValue = new APlayerState(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int TransformComponent__Offset;
		public USceneComponent TransformComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TransformComponent__Offset); if (v == IntPtr.Zero)return null; USceneComponent retValue = new USceneComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ControlRotation__Offset;
		/// <summary>The control rotation of the Controller. See GetControlRotation.</summary>
		public FRotator ControlRotation
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+ControlRotation__Offset, typeof(FRotator));}
			
		}
		
		static readonly int bAttachToPawn__Offset;
		/// <summary>
		/// If true, the controller location will match the possessed Pawn's location. If false, it will not be updated. Rotation will match ControlRotation in either case.
		/// Since a Controller's location is normally inaccessible, this is intended mainly for purposes of being able to attach
		/// an Actor that follows the possessed Pawn location, but that still has the full aim rotation (since a Pawn might
		/// update only some components of the rotation).
		/// </summary>
		public bool bAttachToPawn
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAttachToPawn__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAttachToPawn__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bIsPlayerController__Offset;
		/// <summary>Whether this controller is a PlayerController.</summary>
		public bool bIsPlayerController
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsPlayerController__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int StateName__Offset;
		/// <summary>CONTROLLER STATE PROPERTIES</summary>
		public FName StateName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+StateName__Offset, typeof(FName));}
			
		}
		
		static readonly int OnInstigatedAnyDamage__Offset;
		/// <summary>Called when the controller has instigated damage in any way</summary>
		public FMulticastScriptDelegate OnInstigatedAnyDamage
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnInstigatedAnyDamage__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnInstigatedAnyDamage__Offset, false);}
			
		}
		
		static AController()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Controller");
			Pawn__Offset=GetPropertyOffset(NativeClassPtr,"Pawn");
			Character__Offset=GetPropertyOffset(NativeClassPtr,"Character");
			PlayerState__Offset=GetPropertyOffset(NativeClassPtr,"PlayerState");
			TransformComponent__Offset=GetPropertyOffset(NativeClassPtr,"TransformComponent");
			ControlRotation__Offset=GetPropertyOffset(NativeClassPtr,"ControlRotation");
			bAttachToPawn__Offset=GetPropertyOffset(NativeClassPtr,"bAttachToPawn");
			bIsPlayerController__Offset=GetPropertyOffset(NativeClassPtr,"bIsPlayerController");
			StateName__Offset=GetPropertyOffset(NativeClassPtr,"StateName");
			OnInstigatedAnyDamage__Offset=GetPropertyOffset(NativeClassPtr,"OnInstigatedAnyDamage");
			
		}
		
	}
	
}
#endif
#endif
