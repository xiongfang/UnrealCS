using System;
namespace UnrealEngine
{
	/// <summary>The data needed by the runtime to simulate sprites.</summary>
	public partial struct FGPUSpriteEmitterInfo
	{
		/// <summary>The required module. Needed for now, but should be divorced from the runtime.</summary>
		public UParticleModuleRequired RequiredModule;
		/// <summary>The spawn module. Needed for now, but should be divorced from the runtime.</summary>
		public UParticleModuleSpawn SpawnModule;
		/// <summary>The spawn-per-unit module.</summary>
		public UParticleModuleSpawnPerUnit SpawnPerUnitModule;
		/// <summary>Local vector field info.</summary>
		public FGPUSpriteLocalVectorFieldInfo LocalVectorField;
		/// <summary>Per-particle vector field scale.</summary>
		public FFloatDistribution VectorFieldScale;
		/// <summary>Per-particle drag coefficient.</summary>
		public FFloatDistribution DragCoefficient;
		/// <summary>Point attractor strength over time.</summary>
		public FFloatDistribution PointAttractorStrength;
		/// <summary>Damping factor applied to particle collisions.</summary>
		public FFloatDistribution Resilience;
		/// <summary>Constant acceleration to apply to particles.</summary>
		public FVector ConstantAcceleration;
		/// <summary>Point attractor position.</summary>
		public FVector PointAttractorPosition;
		/// <summary>Point attractor radius, squared.</summary>
		public float PointAttractorRadiusSq;
		/// <summary>Amount by which to offset particles when they are spawned.</summary>
		public FVector OrbitOffsetBase;
		public FVector OrbitOffsetRange;
		/// <summary>One over the maximum size of a sprite particle.</summary>
		public FVector2D InvMaxSize;
		/// <summary>The inverse scale to apply to rotation rate.</summary>
		public float InvRotationRateScale;
		/// <summary>The maximum lifetime of particles in this emitter.</summary>
		public float MaxLifetime;
		/// <summary>The maximum number of particles expected for this emitter.</summary>
		public int MaxParticleCount;
		/// <summary>The method for aligning the particle based on the camera.</summary>
		public EParticleScreenAlignment ScreenAlignment;
		/// <summary>The method for locking the particles to a particular axis.</summary>
		public EParticleAxisLock LockAxisFlag;
		/// <summary>If true, collisions are enabled for this emitter.</summary>
		public bool bEnableCollision;
		public EParticleCollisionMode CollisionMode;
		/// <summary>If true, removes the HMD view roll (e.g. in VR)</summary>
		public bool bRemoveHMDRoll;
		/// <summary>The distance at which PSA_FacingCameraDistanceBlend    is fully PSA_Square</summary>
		public float MinFacingCameraBlendDistance;
		/// <summary>The distance at which PSA_FacingCameraDistanceBlend    is fully PSA_FacingCameraPosition</summary>
		public float MaxFacingCameraBlendDistance;
		/// <summary>Dynamic color scale from the ColorOverLife module.</summary>
		public FRawDistributionVector DynamicColor;
		/// <summary>Dynamic alpha scale from the ColorOverLife module.</summary>
		public FRawDistributionFloat DynamicAlpha;
		/// <summary>Dynamic color scale from the ColorScaleOverLife module.</summary>
		public FRawDistributionVector DynamicColorScale;
		/// <summary>Dynamic alpha scale from the ColorScaleOverLife module.</summary>
		public FRawDistributionFloat DynamicAlphaScale;
		
	}
	
}
