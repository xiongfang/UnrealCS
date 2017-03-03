#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>The data needed by the runtime to simulate sprites.</summary>
	[StructLayout(LayoutKind.Explicit,Size=704)]
	public partial struct FGPUSpriteEmitterInfo
	{
		/// <summary>The required module. Needed for now, but should be divorced from the runtime.</summary>
		/// <summary>The spawn module. Needed for now, but should be divorced from the runtime.</summary>
		/// <summary>The spawn-per-unit module.</summary>
		/// <summary>List of spawn modules that must be evaluated at runtime.</summary>
		public TObjectArray<UParticleModule> SpawnModules
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<UParticleModule>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+24, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+24, false);}}}
			
		}
		/// <summary>Local vector field info.</summary>
		[FieldOffset(48)]
		public FGPUSpriteLocalVectorFieldInfo LocalVectorField;
		/// <summary>Per-particle vector field scale.</summary>
		[FieldOffset(160)]
		public FFloatDistribution VectorFieldScale;
		/// <summary>Per-particle drag coefficient.</summary>
		[FieldOffset(200)]
		public FFloatDistribution DragCoefficient;
		/// <summary>Point attractor strength over time.</summary>
		[FieldOffset(240)]
		public FFloatDistribution PointAttractorStrength;
		/// <summary>Damping factor applied to particle collisions.</summary>
		[FieldOffset(280)]
		public FFloatDistribution Resilience;
		/// <summary>Constant acceleration to apply to particles.</summary>
		[FieldOffset(320)]
		public FVector ConstantAcceleration;
		/// <summary>Point attractor position.</summary>
		[FieldOffset(332)]
		public FVector PointAttractorPosition;
		/// <summary>Point attractor radius, squared.</summary>
		[FieldOffset(344)]
		public float PointAttractorRadiusSq;
		/// <summary>Amount by which to offset particles when they are spawned.</summary>
		[FieldOffset(348)]
		public FVector OrbitOffsetBase;
		[FieldOffset(360)]
		public FVector OrbitOffsetRange;
		/// <summary>One over the maximum size of a sprite particle.</summary>
		[FieldOffset(372)]
		public FVector2D InvMaxSize;
		/// <summary>The inverse scale to apply to rotation rate.</summary>
		[FieldOffset(380)]
		public float InvRotationRateScale;
		/// <summary>The maximum lifetime of particles in this emitter.</summary>
		[FieldOffset(384)]
		public float MaxLifetime;
		/// <summary>The maximum number of particles expected for this emitter.</summary>
		[FieldOffset(388)]
		public int MaxParticleCount;
		/// <summary>The method for aligning the particle based on the camera.</summary>
		[FieldOffset(392)]
		public EParticleScreenAlignment ScreenAlignment;
		/// <summary>The method for locking the particles to a particular axis.</summary>
		[FieldOffset(393)]
		public EParticleAxisLock LockAxisFlag;
		/// <summary>If true, collisions are enabled for this emitter.</summary>
		public bool bEnableCollision
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 396, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 396, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(400)]
		public EParticleCollisionMode CollisionMode;
		/// <summary>If true, removes the HMD view roll (e.g. in VR)</summary>
		public bool bRemoveHMDRoll
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 404, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 404, 1, 0, 1, 1); } }}
			
		}
		/// <summary>The distance at which PSA_FacingCameraDistanceBlend    is fully PSA_Square</summary>
		[FieldOffset(408)]
		public float MinFacingCameraBlendDistance;
		/// <summary>The distance at which PSA_FacingCameraDistanceBlend    is fully PSA_FacingCameraPosition</summary>
		[FieldOffset(412)]
		public float MaxFacingCameraBlendDistance;
		/// <summary>Dynamic color scale from the ColorOverLife module.</summary>
		[FieldOffset(416)]
		public FRawDistributionVector DynamicColor;
		/// <summary>Dynamic alpha scale from the ColorOverLife module.</summary>
		[FieldOffset(496)]
		public FRawDistributionFloat DynamicAlpha;
		/// <summary>Dynamic color scale from the ColorScaleOverLife module.</summary>
		[FieldOffset(552)]
		public FRawDistributionVector DynamicColorScale;
		/// <summary>Dynamic alpha scale from the ColorScaleOverLife module.</summary>
		[FieldOffset(632)]
		public FRawDistributionFloat DynamicAlphaScale;
		
	}
	
}
#endif
#endif
