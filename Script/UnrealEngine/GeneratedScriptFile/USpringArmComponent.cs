using System;
namespace UnrealEngine
{
	public partial class USpringArmComponent:USceneComponent
	{
		/// <summary>Natural length of the spring arm when there are no collisions</summary>
		public float TargetArmLength;
		
		/// <summary>offset at end of spring arm; use this instead of the relative offset of the attached component to ensure the line trace works as desired</summary>
		public FVector SocketOffset;
		
		/// <summary>Offset at start of spring, applied in world space. Use this if you want a world-space offset from the parent component instead of the usual relative-space offset.</summary>
		public FVector TargetOffset;
		
		/// <summary>How big should the query probe sphere be (in unreal units)</summary>
		public float ProbeSize;
		
		/// <summary>Collision channel of the query probe (defaults to ECC_Camera)</summary>
		public ECollisionChannel ProbeChannel;
		
		/// <summary>If true, do a collision test using ProbeChannel and ProbeSize to prevent camera clipping into level.</summary>
		public bool bDoCollisionTest;
		
		/// <summary>
		/// If this component is placed on a pawn, should it use the view/control rotation of the pawn where possible?
		/// @see APawn::GetViewRotation()
		/// </summary>
		public bool bUsePawnControlRotation;
		
		/// <summary>Should we inherit pitch from parent component. Does nothing if using Absolute Rotation.</summary>
		public bool bInheritPitch;
		
		/// <summary>Should we inherit yaw from parent component. Does nothing if using Absolute Rotation.</summary>
		public bool bInheritYaw;
		
		/// <summary>Should we inherit roll from parent component. Does nothing if using Absolute Rotation.</summary>
		public bool bInheritRoll;
		
		/// <summary>
		/// If true, camera lags behind target position to smooth its movement.
		/// @see CameraLagSpeed
		/// </summary>
		public bool bEnableCameraLag;
		
		/// <summary>
		/// If true, camera lags behind target rotation to smooth its movement.
		/// @see CameraRotationLagSpeed
		/// </summary>
		public bool bEnableCameraRotationLag;
		
		/// <summary>
		/// If bUseCameraLagSubstepping is true, sub-step camera damping so that it handles fluctuating frame rates well (though this comes at a cost).
		/// @see CameraLagMaxTimeStep
		/// </summary>
		public bool bUseCameraLagSubstepping;
		
		/// <summary>
		/// If true and camera location lag is enabled, draws markers at the camera target (in green) and the lagged position (in yellow).
		/// A line is drawn between the two locations, in green normally but in red if the distance to the lag target has been clamped (by CameraLagMaxDistance).
		/// </summary>
		public bool bDrawDebugLagMarkers;
		
		/// <summary>If bEnableCameraLag is true, controls how quickly camera reaches target position. Low values are slower (more lag), high values are faster (less lag), while zero is instant (no lag).</summary>
		public float CameraLagSpeed;
		
		/// <summary>If bEnableCameraRotationLag is true, controls how quickly camera reaches target position. Low values are slower (more lag), high values are faster (less lag), while zero is instant (no lag).</summary>
		public float CameraRotationLagSpeed;
		
		/// <summary>Max time step used when sub-stepping camera lag.</summary>
		public float CameraLagMaxTimeStep;
		
		/// <summary>Max distance the camera target may lag behind the current location. If set to zero, no max distance is enforced.</summary>
		public float CameraLagMaxDistance;
		
		
	}
	
}
