#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UProjectileMovementComponent
	{
		static readonly int InitialSpeed__Offset;
		public float InitialSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InitialSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InitialSpeed__Offset, false);}
			
		}
		
		static readonly int MaxSpeed__Offset;
		public float MaxSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSpeed__Offset, false);}
			
		}
		
		static readonly int bRotationFollowsVelocity__Offset;
		public bool bRotationFollowsVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRotationFollowsVelocity__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRotationFollowsVelocity__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bShouldBounce__Offset;
		public bool bShouldBounce
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldBounce__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShouldBounce__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bInitialVelocityInLocalSpace__Offset;
		public bool bInitialVelocityInLocalSpace
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInitialVelocityInLocalSpace__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInitialVelocityInLocalSpace__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bForceSubStepping__Offset;
		public bool bForceSubStepping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceSubStepping__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForceSubStepping__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bIsHomingProjectile__Offset;
		public bool bIsHomingProjectile
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsHomingProjectile__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsHomingProjectile__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bBounceAngleAffectsFriction__Offset;
		public bool bBounceAngleAffectsFriction
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bBounceAngleAffectsFriction__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bBounceAngleAffectsFriction__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bIsSliding__Offset;
		public bool bIsSliding
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsSliding__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsSliding__Offset, 1,0,64,64);}
			
		}
		
		static readonly int PreviousHitTime__Offset;
		public float PreviousHitTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PreviousHitTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PreviousHitTime__Offset, false);}
			
		}
		
		static readonly int PreviousHitNormal__Offset;
		public FVector PreviousHitNormal
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PreviousHitNormal__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PreviousHitNormal__Offset, false);}
			
		}
		
		static readonly int ProjectileGravityScale__Offset;
		public float ProjectileGravityScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ProjectileGravityScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ProjectileGravityScale__Offset, false);}
			
		}
		
		static readonly int Buoyancy__Offset;
		public float Buoyancy
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Buoyancy__Offset, typeof(float));}
			
		}
		
		static readonly int Bounciness__Offset;
		public float Bounciness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Bounciness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Bounciness__Offset, false);}
			
		}
		
		static readonly int Friction__Offset;
		public float Friction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Friction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Friction__Offset, false);}
			
		}
		
		static readonly int BounceVelocityStopSimulatingThreshold__Offset;
		public float BounceVelocityStopSimulatingThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BounceVelocityStopSimulatingThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BounceVelocityStopSimulatingThreshold__Offset, false);}
			
		}
		
		static readonly int OnProjectileBounce__Offset;
		public FMulticastScriptDelegate OnProjectileBounce
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnProjectileBounce__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnProjectileBounce__Offset, false);}
			
		}
		
		static readonly int OnProjectileStop__Offset;
		public FMulticastScriptDelegate OnProjectileStop
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnProjectileStop__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnProjectileStop__Offset, false);}
			
		}
		
		static readonly int HomingAccelerationMagnitude__Offset;
		public float HomingAccelerationMagnitude
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+HomingAccelerationMagnitude__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HomingAccelerationMagnitude__Offset, false);}
			
		}
		
		static readonly int MaxSimulationTimeStep__Offset;
		public float MaxSimulationTimeStep
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxSimulationTimeStep__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSimulationTimeStep__Offset, false);}
			
		}
		
		static readonly int MaxSimulationIterations__Offset;
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
