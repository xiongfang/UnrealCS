using System;
namespace UnrealEngine
{
	public partial class UMovementComponent:UActorComponent
	{
		/// <summary>Snap the updated component to the plane constraint, if enabled.</summary>
		public extern virtual void SnapUpdatedComponentToPlane();
		/// <summary>Constrain a normal vector (of unit length) to the plane constraint, if enabled.</summary>
		public extern virtual FVector ConstrainNormalToPlane(FVector Normal);
		/// <summary>Constrain a position vector to the plane constraint, if enabled.</summary>
		public extern virtual FVector ConstrainLocationToPlane(FVector Location);
		/// <summary>
		/// Constrain a direction vector to the plane constraint, if enabled.
		/// @see SetPlaneConstraint
		/// </summary>
		public extern virtual FVector ConstrainDirectionToPlane(FVector Direction);
		/// <summary>
		/// Get the plane constraint origin. This defines the behavior of snapping a position to the plane, such as by SnapUpdatedComponentToPlane().
		/// @return The origin of the plane that constrains movement, if the plane constraint is enabled.
		/// </summary>
		public extern FVector GetPlaneConstraintOrigin();
		/// <summary>@return The normal of the plane that constrains movement, enforced if the plane constraint is enabled.</summary>
		public extern FVector GetPlaneConstraintNormal();
		/// <summary>Sets whether or not the plane constraint is enabled.</summary>
		public extern virtual void SetPlaneConstraintEnabled(bool bEnabled);
		/// <summary>Sets the origin of the plane that constrains movement, enforced if the plane constraint is enabled.</summary>
		public extern virtual void SetPlaneConstraintOrigin(FVector PlaneOrigin);
		/// <summary>Uses the Forward and Up vectors to compute the plane that constrains movement, enforced if the plane constraint is enabled.</summary>
		public extern virtual void SetPlaneConstraintFromVectors(FVector Forward,FVector Up);
		/// <summary>
		/// Sets the normal of the plane that constrains movement, enforced if the plane constraint is enabled.
		/// Changing the normal automatically sets PlaneConstraintAxisSetting to "Custom".
		/// @param PlaneNormal   The normal of the plane. If non-zero in length, it will be normalized.
		/// </summary>
		public extern virtual void SetPlaneConstraintNormal(FVector PlaneNormal);
		/// <summary>
		/// Moves our UpdatedComponent by the given Delta, and sets rotation to NewRotation.
		/// Respects the plane constraint, if enabled.
		/// @return True if some movement occurred, false if no movement occurred. Result of any impact will be stored in OutHit.
		/// </summary>
		public extern bool K2_MoveUpdatedComponent(FVector Delta,FRotator NewRotation,out FHitResult OutHit,bool bSweep=true,bool bTeleport=false);
		/// <summary>Assign the component we move and update.</summary>
		public extern virtual void SetUpdatedComponent(USceneComponent NewUpdatedComponent);
		/// <summary>Delegate when PhysicsVolume of UpdatedComponent has been changed *</summary>
		public extern virtual void PhysicsVolumeChanged(APhysicsVolume NewVolume);
		/// <summary>@return PhysicsVolume this MovementComponent is using, or the world's default physics volume if none. *</summary>
		public extern virtual APhysicsVolume GetPhysicsVolume();
		/// <summary>Stops movement immediately (zeroes velocity, usually zeros acceleration for components with acceleration).</summary>
		public extern virtual void StopMovementImmediately();
		/// <summary>
		/// Returns true if the current velocity is exceeding the given max speed (usually the result of GetMaxSpeed()), within a small error tolerance.
		/// Note that under normal circumstances updates cause by acceleration will not cause this to be true, however external forces or changes in the max speed limit
		/// can cause the max speed to be violated.
		/// </summary>
		public extern virtual bool IsExceedingMaxSpeed(float MaxSpeed);
		/// <summary>@return the result of GetMaxSpeed() * GetMaxSpeedModifier().</summary>
		public extern virtual float K2_GetModifiedMaxSpeed();
		/// <summary>@return Maximum speed of component in current movement mode.</summary>
		public extern virtual float GetMaxSpeed();
		/// <summary>@return gravity that affects this component</summary>
		public extern virtual float GetGravityZ();
		/// <summary>
		/// The component we move and update.
		/// If this is null at startup and bAutoRegisterUpdatedComponent is true, the owning Actor's root component will automatically be set as our UpdatedComponent at startup.
		/// @see bAutoRegisterUpdatedComponent, SetUpdatedComponent(), UpdatedPrimitive
		/// </summary>
		public USceneComponent UpdatedComponent;
		
		/// <summary>UpdatedComponent, cast as a UPrimitiveComponent. May be invalid if UpdatedComponent was null or not a UPrimitiveComponent.</summary>
		public UPrimitiveComponent UpdatedPrimitive;
		
		/// <summary>Current velocity of updated component.</summary>
		public FVector Velocity;
		
		/// <summary>
		/// If true, movement will be constrained to a plane.
		/// @see PlaneConstraintNormal, PlaneConstraintOrigin, PlaneConstraintAxisSetting
		/// </summary>
		public bool bConstrainToPlane;
		
		/// <summary>If true and plane constraints are enabled, then the updated component will be snapped to the plane when first attached.</summary>
		public bool bSnapToPlaneAtStart;
		
		/// <summary>
		/// The normal or axis of the plane that constrains movement, if bConstrainToPlane is enabled.
		/// If for example you wanted to constrain movement to the X-Z plane (so that Y cannot change), the normal would be set to X=0 Y=1 Z=0.
		/// This is recalculated whenever PlaneConstraintAxisSetting changes. It is normalized once the component is registered with the game world.
		/// @see bConstrainToPlane, SetPlaneConstraintNormal(), SetPlaneConstraintFromVectors()
		/// </summary>
		public FVector PlaneConstraintNormal;
		
		/// <summary>
		/// The origin of the plane that constrains movement, if plane constraint is enabled.
		/// This defines the behavior of snapping a position to the plane, such as by SnapUpdatedComponentToPlane().
		/// @see bConstrainToPlane, SetPlaneConstraintOrigin().
		/// </summary>
		public FVector PlaneConstraintOrigin;
		
		/// <summary>If true, skips TickComponent() if UpdatedComponent was not recently rendered.</summary>
		public bool bUpdateOnlyIfRendered;
		
		/// <summary>
		/// If true, whenever the updated component is changed, this component will enable or disable its tick dependent on whether it has something to update.
		/// This will NOT enable tick at startup if bAutoActivate is false, because presumably you have a good reason for not wanting it to start ticking initially.
		/// </summary>
		public bool bAutoUpdateTickRegistration;
		
		/// <summary>
		/// If true, after registration we will add a tick dependency to tick before our owner (if we can both tick).
		/// This is important when our tick causes an update in the owner's position, so that when the owner ticks it uses the most recent position without lag.
		/// Disabling this can improve performance if both objects tick but the order of ticks doesn't matter.
		/// </summary>
		public bool bTickBeforeOwner;
		
		/// <summary>If true, registers the owner's Root component as the UpdatedComponent if there is not one currently assigned.</summary>
		public bool bAutoRegisterUpdatedComponent;
		
		
	}
	
}
