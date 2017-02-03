#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// This component tries to maintain its children at a fixed distance from the parent,
	/// but will retract the children if there is a collision, and spring back when there is no collision.
	/// Example: Use as a 'camera boom' to keep the follow camera for a player from colliding into the world.
	/// </summary>
	public partial class USpringArmComponent
	{
		static readonly int TargetArmLength__Offset;
		/// <summary>Natural length of the spring arm when there are no collisions</summary>
		public float TargetArmLength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TargetArmLength__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TargetArmLength__Offset, false);}
			
		}
		
		static readonly int SocketOffset__Offset;
		/// <summary>offset at end of spring arm; use this instead of the relative offset of the attached component to ensure the line trace works as desired</summary>
		public FVector SocketOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+SocketOffset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SocketOffset__Offset, false);}
			
		}
		
		static readonly int TargetOffset__Offset;
		/// <summary>Offset at start of spring, applied in world space. Use this if you want a world-space offset from the parent component instead of the usual relative-space offset.</summary>
		public FVector TargetOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+TargetOffset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TargetOffset__Offset, false);}
			
		}
		
		static readonly int ProbeSize__Offset;
		/// <summary>How big should the query probe sphere be (in unreal units)</summary>
		public float ProbeSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ProbeSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ProbeSize__Offset, false);}
			
		}
		
		static readonly int ProbeChannel__Offset;
		/// <summary>Collision channel of the query probe (defaults to ECC_Camera)</summary>
		public ECollisionChannel ProbeChannel
		{
			get{ CheckIsValid();return (ECollisionChannel)Marshal.PtrToStructure(_this.Get()+ProbeChannel__Offset, typeof(ECollisionChannel));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ProbeChannel__Offset, false);}
			
		}
		
		static readonly int bDoCollisionTest__Offset;
		/// <summary>If true, do a collision test using ProbeChannel and ProbeSize to prevent camera clipping into level.</summary>
		public bool bDoCollisionTest
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDoCollisionTest__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDoCollisionTest__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bUsePawnControlRotation__Offset;
		/// <summary>
		/// If this component is placed on a pawn, should it use the view/control rotation of the pawn where possible?
		/// @see APawn::GetViewRotation()
		/// </summary>
		public bool bUsePawnControlRotation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsePawnControlRotation__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsePawnControlRotation__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bInheritPitch__Offset;
		/// <summary>Should we inherit pitch from parent component. Does nothing if using Absolute Rotation.</summary>
		public bool bInheritPitch
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInheritPitch__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInheritPitch__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bInheritYaw__Offset;
		/// <summary>Should we inherit yaw from parent component. Does nothing if using Absolute Rotation.</summary>
		public bool bInheritYaw
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInheritYaw__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInheritYaw__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bInheritRoll__Offset;
		/// <summary>Should we inherit roll from parent component. Does nothing if using Absolute Rotation.</summary>
		public bool bInheritRoll
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInheritRoll__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInheritRoll__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bEnableCameraLag__Offset;
		/// <summary>
		/// If true, camera lags behind target position to smooth its movement.
		/// @see CameraLagSpeed
		/// </summary>
		public bool bEnableCameraLag
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableCameraLag__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableCameraLag__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bEnableCameraRotationLag__Offset;
		/// <summary>
		/// If true, camera lags behind target rotation to smooth its movement.
		/// @see CameraRotationLagSpeed
		/// </summary>
		public bool bEnableCameraRotationLag
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableCameraRotationLag__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableCameraRotationLag__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bUseCameraLagSubstepping__Offset;
		/// <summary>
		/// If bUseCameraLagSubstepping is true, sub-step camera damping so that it handles fluctuating frame rates well (though this comes at a cost).
		/// @see CameraLagMaxTimeStep
		/// </summary>
		public bool bUseCameraLagSubstepping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseCameraLagSubstepping__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseCameraLagSubstepping__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bDrawDebugLagMarkers__Offset;
		/// <summary>
		/// If true and camera location lag is enabled, draws markers at the camera target (in green) and the lagged position (in yellow).
		/// A line is drawn between the two locations, in green normally but in red if the distance to the lag target has been clamped (by CameraLagMaxDistance).
		/// </summary>
		public bool bDrawDebugLagMarkers
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawDebugLagMarkers__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawDebugLagMarkers__Offset, 1,0,1,1);}
			
		}
		
		static readonly int CameraLagSpeed__Offset;
		/// <summary>If bEnableCameraLag is true, controls how quickly camera reaches target position. Low values are slower (more lag), high values are faster (less lag), while zero is instant (no lag).</summary>
		public float CameraLagSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CameraLagSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CameraLagSpeed__Offset, false);}
			
		}
		
		static readonly int CameraRotationLagSpeed__Offset;
		/// <summary>If bEnableCameraRotationLag is true, controls how quickly camera reaches target position. Low values are slower (more lag), high values are faster (less lag), while zero is instant (no lag).</summary>
		public float CameraRotationLagSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CameraRotationLagSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CameraRotationLagSpeed__Offset, false);}
			
		}
		
		static readonly int CameraLagMaxTimeStep__Offset;
		/// <summary>Max time step used when sub-stepping camera lag.</summary>
		public float CameraLagMaxTimeStep
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CameraLagMaxTimeStep__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CameraLagMaxTimeStep__Offset, false);}
			
		}
		
		static readonly int CameraLagMaxDistance__Offset;
		/// <summary>Max distance the camera target may lag behind the current location. If set to zero, no max distance is enforced.</summary>
		public float CameraLagMaxDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CameraLagMaxDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CameraLagMaxDistance__Offset, false);}
			
		}
		
		static USpringArmComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SpringArmComponent");
			TargetArmLength__Offset=GetPropertyOffset(NativeClassPtr,"TargetArmLength");
			SocketOffset__Offset=GetPropertyOffset(NativeClassPtr,"SocketOffset");
			TargetOffset__Offset=GetPropertyOffset(NativeClassPtr,"TargetOffset");
			ProbeSize__Offset=GetPropertyOffset(NativeClassPtr,"ProbeSize");
			ProbeChannel__Offset=GetPropertyOffset(NativeClassPtr,"ProbeChannel");
			bDoCollisionTest__Offset=GetPropertyOffset(NativeClassPtr,"bDoCollisionTest");
			bUsePawnControlRotation__Offset=GetPropertyOffset(NativeClassPtr,"bUsePawnControlRotation");
			bInheritPitch__Offset=GetPropertyOffset(NativeClassPtr,"bInheritPitch");
			bInheritYaw__Offset=GetPropertyOffset(NativeClassPtr,"bInheritYaw");
			bInheritRoll__Offset=GetPropertyOffset(NativeClassPtr,"bInheritRoll");
			bEnableCameraLag__Offset=GetPropertyOffset(NativeClassPtr,"bEnableCameraLag");
			bEnableCameraRotationLag__Offset=GetPropertyOffset(NativeClassPtr,"bEnableCameraRotationLag");
			bUseCameraLagSubstepping__Offset=GetPropertyOffset(NativeClassPtr,"bUseCameraLagSubstepping");
			bDrawDebugLagMarkers__Offset=GetPropertyOffset(NativeClassPtr,"bDrawDebugLagMarkers");
			CameraLagSpeed__Offset=GetPropertyOffset(NativeClassPtr,"CameraLagSpeed");
			CameraRotationLagSpeed__Offset=GetPropertyOffset(NativeClassPtr,"CameraRotationLagSpeed");
			CameraLagMaxTimeStep__Offset=GetPropertyOffset(NativeClassPtr,"CameraLagMaxTimeStep");
			CameraLagMaxDistance__Offset=GetPropertyOffset(NativeClassPtr,"CameraLagMaxDistance");
			
		}
		
	}
	
}
#endif
#endif
