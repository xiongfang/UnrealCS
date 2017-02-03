#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// ProjectileMovementComponent updates the position of another component during its tick.
	/// Behavior such as bouncing after impacts and homing toward a target are supported.
	/// Normally the root component of the owning actor is moved, however another component may be selected (see SetUpdatedComponent()).
	/// If the updated component is simulating physics, only the initial launch parameters (when initial velocity is non-zero)
	/// will affect the projectile, and the physics sim will take over from there.
	/// @see UMovementComponent
	/// </summary>
	public partial class UProjectileMovementComponent
	{
		static readonly int InitialSpeed__Offset;
		/// <summary>Initial speed of projectile. If greater than zero, this will override the initial Velocity value and instead treat Velocity as a direction.</summary>
		public float InitialSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InitialSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InitialSpeed__Offset, false);}
			
		}
		
		static readonly int MaxSpeed__Offset;
		/// <summary>Limit on speed of projectile (0 means no limit).</summary>
		public float MaxSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSpeed__Offset, false);}
			
		}
		
		static readonly int bRotationFollowsVelocity__Offset;
		/// <summary>If true, this projectile will have its rotation updated each frame to match the direction of its velocity.</summary>
		public bool bRotationFollowsVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRotationFollowsVelocity__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRotationFollowsVelocity__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bShouldBounce__Offset;
		/// <summary>If true, simple bounces will be simulated. Set this to false to stop simulating on contact.</summary>
		public bool bShouldBounce
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldBounce__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShouldBounce__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bInitialVelocityInLocalSpace__Offset;
		/// <summary>
		/// If true, the initial Velocity is interpreted as being in local space upon startup.
		/// @see SetVelocityInLocalSpace()
		/// </summary>
		public bool bInitialVelocityInLocalSpace
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInitialVelocityInLocalSpace__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInitialVelocityInLocalSpace__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bForceSubStepping__Offset;
		/// <summary>
		/// If true, forces sub-stepping to break up movement into discrete smaller steps to improve accuracy of the trajectory.
		/// Objects that move in a straight line typically do *not* need to set this, as movement always uses continuous collision detection (sweeps) so collision is not missed.
		/// Sub-stepping is automatically enabled when under the effects of gravity or when homing towards a target.
		/// @see MaxSimulationTimeStep, MaxSimulationIterations
		/// </summary>
		public bool bForceSubStepping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceSubStepping__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForceSubStepping__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bIsHomingProjectile__Offset;
		/// <summary>
		/// If true, we will accelerate toward our homing target. HomingTargetComponent must be set after the projectile is spawned.
		/// @see HomingTargetComponent, HomingAccelerationMagnitude
		/// </summary>
		public bool bIsHomingProjectile
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsHomingProjectile__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsHomingProjectile__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bBounceAngleAffectsFriction__Offset;
		/// <summary>
		/// Controls the effects of friction on velocity parallel to the impact surface when bouncing.
		/// If true, friction will be modified based on the angle of impact, making friction higher for perpendicular impacts and lower for glancing impacts.
		/// If false, a bounce will retain a proportion of tangential velocity equal to (1.0 - Friction), acting as a "horizontal restitution".
		/// </summary>
		public bool bBounceAngleAffectsFriction
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bBounceAngleAffectsFriction__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bBounceAngleAffectsFriction__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bIsSliding__Offset;
		/// <summary>If true, projectile is sliding / rolling along a surface.</summary>
		public bool bIsSliding
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsSliding__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsSliding__Offset, 1,0,64,64);}
			
		}
		
		static readonly int PreviousHitTime__Offset;
		/// <summary>Saved HitResult Time (0 to 1) from previous simulation step. Equal to 1.0 when there was no impact.</summary>
		public float PreviousHitTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PreviousHitTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PreviousHitTime__Offset, false);}
			
		}
		
		static readonly int PreviousHitNormal__Offset;
		/// <summary>Saved HitResult Normal from previous simulation step that resulted in an impact. If PreviousHitTime is 1.0, then the hit was not in the last step.</summary>
		public FVector PreviousHitNormal
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PreviousHitNormal__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PreviousHitNormal__Offset, false);}
			
		}
		
		static readonly int ProjectileGravityScale__Offset;
		/// <summary>Custom gravity scale for this projectile. Set to 0 for no gravity.</summary>
		public float ProjectileGravityScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ProjectileGravityScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ProjectileGravityScale__Offset, false);}
			
		}
		
		static readonly int Buoyancy__Offset;
		/// <summary>Buoyancy of UpdatedComponent in fluid. 0.0=sinks as fast as in air, 1.0=neutral buoyancy</summary>
		public float Buoyancy
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Buoyancy__Offset, typeof(float));}
			
		}
		
		static readonly int Bounciness__Offset;
		/// <summary>
		/// Percentage of velocity maintained after the bounce in the direction of the normal of impact (coefficient of restitution).
		/// 1.0 = no velocity lost, 0.0 = no bounce. Ignored if bShouldBounce is false.
		/// </summary>
		public float Bounciness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Bounciness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Bounciness__Offset, false);}
			
		}
		
		static readonly int Friction__Offset;
		/// <summary>
		/// Coefficient of friction, affecting the resistance to sliding along a surface.
		/// Normal range is [0,1] : 0.0 = no friction, 1.0+ = very high friction.
		/// Also affects the percentage of velocity maintained after the bounce in the direction tangent to the normal of impact.
		/// Ignored if bShouldBounce is false.
		/// @see bBounceAngleAffectsFriction
		/// </summary>
		public float Friction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Friction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Friction__Offset, false);}
			
		}
		
		static readonly int BounceVelocityStopSimulatingThreshold__Offset;
		/// <summary>
		/// If velocity is below this threshold after a bounce, stops simulating and triggers the OnProjectileStop event.
		/// Ignored if bShouldBounce is false, in which case the projectile stops simulating on the first impact.
		/// @see StopSimulating(), OnProjectileStop
		/// </summary>
		public float BounceVelocityStopSimulatingThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BounceVelocityStopSimulatingThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BounceVelocityStopSimulatingThreshold__Offset, false);}
			
		}
		
		static readonly int OnProjectileBounce__Offset;
		/// <summary>Called when projectile impacts something and bounces are enabled.</summary>
		public FMulticastScriptDelegate OnProjectileBounce
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnProjectileBounce__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnProjectileBounce__Offset, false);}
			
		}
		
		static readonly int OnProjectileStop__Offset;
		/// <summary>Called when projectile has come to a stop (velocity is below simulation threshold, bounces are disabled, or it is forcibly stopped).</summary>
		public FMulticastScriptDelegate OnProjectileStop
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnProjectileStop__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnProjectileStop__Offset, false);}
			
		}
		
		static readonly int HomingAccelerationMagnitude__Offset;
		/// <summary>The magnitude of our acceleration towards the homing target. Overall velocity magnitude will still be limited by MaxSpeed.</summary>
		public float HomingAccelerationMagnitude
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+HomingAccelerationMagnitude__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HomingAccelerationMagnitude__Offset, false);}
			
		}
		
		static readonly int MaxSimulationTimeStep__Offset;
		/// <summary>
		/// Max time delta for each discrete simulation step.
		/// Lowering this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance.
		/// WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
		/// @see MaxSimulationIterations, bForceSubStepping
		/// </summary>
		public float MaxSimulationTimeStep
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxSimulationTimeStep__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSimulationTimeStep__Offset, false);}
			
		}
		
		static readonly int MaxSimulationIterations__Offset;
		/// <summary>
		/// Max number of iterations used for each discrete simulation step.
		/// Increasing this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance.
		/// WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
		/// @see MaxSimulationTimeStep, bForceSubStepping
		/// </summary>
		public int MaxSimulationIterations
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxSimulationIterations__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSimulationIterations__Offset, false);}
			
		}
		
		static UProjectileMovementComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ProjectileMovementComponent");
			InitialSpeed__Offset=GetPropertyOffset(NativeClassPtr,"InitialSpeed");
			MaxSpeed__Offset=GetPropertyOffset(NativeClassPtr,"MaxSpeed");
			bRotationFollowsVelocity__Offset=GetPropertyOffset(NativeClassPtr,"bRotationFollowsVelocity");
			bShouldBounce__Offset=GetPropertyOffset(NativeClassPtr,"bShouldBounce");
			bInitialVelocityInLocalSpace__Offset=GetPropertyOffset(NativeClassPtr,"bInitialVelocityInLocalSpace");
			bForceSubStepping__Offset=GetPropertyOffset(NativeClassPtr,"bForceSubStepping");
			bIsHomingProjectile__Offset=GetPropertyOffset(NativeClassPtr,"bIsHomingProjectile");
			bBounceAngleAffectsFriction__Offset=GetPropertyOffset(NativeClassPtr,"bBounceAngleAffectsFriction");
			bIsSliding__Offset=GetPropertyOffset(NativeClassPtr,"bIsSliding");
			PreviousHitTime__Offset=GetPropertyOffset(NativeClassPtr,"PreviousHitTime");
			PreviousHitNormal__Offset=GetPropertyOffset(NativeClassPtr,"PreviousHitNormal");
			ProjectileGravityScale__Offset=GetPropertyOffset(NativeClassPtr,"ProjectileGravityScale");
			Buoyancy__Offset=GetPropertyOffset(NativeClassPtr,"Buoyancy");
			Bounciness__Offset=GetPropertyOffset(NativeClassPtr,"Bounciness");
			Friction__Offset=GetPropertyOffset(NativeClassPtr,"Friction");
			BounceVelocityStopSimulatingThreshold__Offset=GetPropertyOffset(NativeClassPtr,"BounceVelocityStopSimulatingThreshold");
			OnProjectileBounce__Offset=GetPropertyOffset(NativeClassPtr,"OnProjectileBounce");
			OnProjectileStop__Offset=GetPropertyOffset(NativeClassPtr,"OnProjectileStop");
			HomingAccelerationMagnitude__Offset=GetPropertyOffset(NativeClassPtr,"HomingAccelerationMagnitude");
			MaxSimulationTimeStep__Offset=GetPropertyOffset(NativeClassPtr,"MaxSimulationTimeStep");
			MaxSimulationIterations__Offset=GetPropertyOffset(NativeClassPtr,"MaxSimulationIterations");
			
		}
		
	}
	
}
#endif
#endif
