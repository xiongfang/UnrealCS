#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleCollision
	{
		static readonly int DampingFactor__Offset;
		/// <summary>
		/// How much to `slow' the velocity of the particle after a collision.
		/// Value is obtained using the EmitterTime at particle spawn.
		/// </summary>
		public FRawDistributionVector DampingFactor
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+DampingFactor__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DampingFactor__Offset, false);}
			
		}
		
		static readonly int DampingFactorRotation__Offset;
		/// <summary>
		/// How much to `slow' the rotation of the particle after a collision.
		/// Value is obtained using the EmitterTime at particle spawn.
		/// </summary>
		public FRawDistributionVector DampingFactorRotation
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+DampingFactorRotation__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DampingFactorRotation__Offset, false);}
			
		}
		
		static readonly int MaxCollisions__Offset;
		/// <summary>
		/// The maximum number of collisions a particle can have.
		/// Value is obtained using the EmitterTime at particle spawn.
		/// </summary>
		public FRawDistributionFloat MaxCollisions
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+MaxCollisions__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxCollisions__Offset, false);}
			
		}
		
		static readonly int CollisionCompletionOption__Offset;
		/// <summary>
		/// What to do once a particles MaxCollisions is reached.
		/// One of the following:
		/// EPCC_Kill
		///         Kill the particle when MaxCollisions is reached
		/// EPCC_Freeze
		///         Freeze in place, NO MORE UPDATES
		/// EPCC_HaltCollisions,
		///         Stop collision checks, keep updating everything
		/// EPCC_FreezeTranslation,
		///         Stop translations, keep updating everything else
		/// EPCC_FreezeRotation,
		///         Stop rotations, keep updating everything else
		/// EPCC_FreezeMovement
		///         Stop all movement, keep updating
		/// </summary>
		public EParticleCollisionComplete CollisionCompletionOption
		{
			get{ CheckIsValid();return (EParticleCollisionComplete)Marshal.PtrToStructure(_this.Get()+CollisionCompletionOption__Offset, typeof(EParticleCollisionComplete));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CollisionCompletionOption__Offset, false);}
			
		}
		
		static readonly int CollisionTypes__Offset;
		/// <summary>Which ObjectTypes to collide with</summary>
		public TStructArray<EObjectTypeQuery> CollisionTypes
		{
			get{ CheckIsValid();return new TStructArray<EObjectTypeQuery>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CollisionTypes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CollisionTypes__Offset, false);}
			
		}
		
		static readonly int bApplyPhysics__Offset;
		/// <summary>
		/// If true, physic will be applied between a particle and the
		/// object it collides with.
		/// This is one-way - particle --> object. The particle does
		/// not have physics applied to it - it just generates an
		/// impulse applied to the object it collides with.
		/// NOTE: having this on prevents the code from running off the game thread.
		/// </summary>
		public bool bApplyPhysics
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bApplyPhysics__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bApplyPhysics__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bIgnoreTriggerVolumes__Offset;
		/// <summary>
		/// Any trigger volumes that are hit will be ignored. NOTE: This can be turned off if the TrigerVolume physics object type is not in the CollisionTypes array.
		/// Turning this off is strongly recommended as having it on prevents the code from running off the game thread.
		/// </summary>
		public bool bIgnoreTriggerVolumes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreTriggerVolumes__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreTriggerVolumes__Offset, 1,0,2,2);}
			
		}
		
		static readonly int ParticleMass__Offset;
		/// <summary>
		/// The mass of the particle - for use when bApplyPhysics is true.
		/// Value is obtained using the EmitterTime at particle spawn.
		/// </summary>
		public FRawDistributionFloat ParticleMass
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+ParticleMass__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ParticleMass__Offset, false);}
			
		}
		
		static readonly int DirScalar__Offset;
		/// <summary>
		/// The directional scalar value - used to scale the bounds to
		/// 'assist' in avoiding inter-penetration or large gaps.
		/// </summary>
		public float DirScalar
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DirScalar__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DirScalar__Offset, false);}
			
		}
		
		static readonly int bPawnsDoNotDecrementCount__Offset;
		/// <summary>
		/// If true, then collisions with Pawns will still react, but
		/// the UsedMaxCollisions count will not be decremented.
		/// (ie., They don't 'count' as collisions)
		/// NOTE: Having this on prevents the code from running in parallel.
		/// </summary>
		public bool bPawnsDoNotDecrementCount
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPawnsDoNotDecrementCount__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPawnsDoNotDecrementCount__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOnlyVerticalNormalsDecrementCount__Offset;
		/// <summary>
		/// If true, then collisions that do not have a vertical hit
		/// normal will still react, but UsedMaxCollisions count will
		/// not be decremented. (ie., They don't 'count' as collisions)
		/// Useful for having particles come to rest on floors.
		/// </summary>
		public bool bOnlyVerticalNormalsDecrementCount
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOnlyVerticalNormalsDecrementCount__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOnlyVerticalNormalsDecrementCount__Offset, 1,0,2,2);}
			
		}
		
		static readonly int VerticalFudgeFactor__Offset;
		/// <summary>
		/// The fudge factor to use to determine vertical.
		/// True vertical will have a Hit.Normal.Z == 1.0
		/// This will allow for Z components in the range of
		/// [1.0-VerticalFudgeFactor..1.0]
		/// to count as vertical collisions.
		/// </summary>
		public float VerticalFudgeFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VerticalFudgeFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VerticalFudgeFactor__Offset, false);}
			
		}
		
		static readonly int DelayAmount__Offset;
		/// <summary>
		/// How long to delay before checking a particle for collisions.
		/// Value is retrieved using the EmitterTime.
		/// During update, the particle flag IgnoreCollisions will be
		/// set until the particle RelativeTime has surpassed the
		/// DelayAmount.
		/// </summary>
		public FRawDistributionFloat DelayAmount
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+DelayAmount__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DelayAmount__Offset, false);}
			
		}
		
		static readonly int bDropDetail__Offset;
		/// <summary>If true, when the World->bDropDetail flag is set, the module will be ignored.</summary>
		public bool bDropDetail
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDropDetail__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDropDetail__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bCollideOnlyIfVisible__Offset;
		/// <summary>If true, Particle collision only if particle system is currently being rendered.</summary>
		public bool bCollideOnlyIfVisible
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCollideOnlyIfVisible__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCollideOnlyIfVisible__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bIgnoreSourceActor__Offset;
		/// <summary>
		/// If true, then the source actor is ignored in collision checks.
		/// Defaults to true.
		/// </summary>
		public bool bIgnoreSourceActor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreSourceActor__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreSourceActor__Offset, 1,0,4,4);}
			
		}
		
		static readonly int MaxCollisionDistance__Offset;
		/// <summary>Max distance at which particle collision will occur.</summary>
		public float MaxCollisionDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxCollisionDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxCollisionDistance__Offset, false);}
			
		}
		
		static UParticleModuleCollision()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleCollision");
			DampingFactor__Offset=GetPropertyOffset(NativeClassPtr,"DampingFactor");
			DampingFactorRotation__Offset=GetPropertyOffset(NativeClassPtr,"DampingFactorRotation");
			MaxCollisions__Offset=GetPropertyOffset(NativeClassPtr,"MaxCollisions");
			CollisionCompletionOption__Offset=GetPropertyOffset(NativeClassPtr,"CollisionCompletionOption");
			CollisionTypes__Offset=GetPropertyOffset(NativeClassPtr,"CollisionTypes");
			bApplyPhysics__Offset=GetPropertyOffset(NativeClassPtr,"bApplyPhysics");
			bIgnoreTriggerVolumes__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreTriggerVolumes");
			ParticleMass__Offset=GetPropertyOffset(NativeClassPtr,"ParticleMass");
			DirScalar__Offset=GetPropertyOffset(NativeClassPtr,"DirScalar");
			bPawnsDoNotDecrementCount__Offset=GetPropertyOffset(NativeClassPtr,"bPawnsDoNotDecrementCount");
			bOnlyVerticalNormalsDecrementCount__Offset=GetPropertyOffset(NativeClassPtr,"bOnlyVerticalNormalsDecrementCount");
			VerticalFudgeFactor__Offset=GetPropertyOffset(NativeClassPtr,"VerticalFudgeFactor");
			DelayAmount__Offset=GetPropertyOffset(NativeClassPtr,"DelayAmount");
			bDropDetail__Offset=GetPropertyOffset(NativeClassPtr,"bDropDetail");
			bCollideOnlyIfVisible__Offset=GetPropertyOffset(NativeClassPtr,"bCollideOnlyIfVisible");
			bIgnoreSourceActor__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreSourceActor");
			MaxCollisionDistance__Offset=GetPropertyOffset(NativeClassPtr,"MaxCollisionDistance");
			
		}
		
	}
	
}
#endif
#endif
