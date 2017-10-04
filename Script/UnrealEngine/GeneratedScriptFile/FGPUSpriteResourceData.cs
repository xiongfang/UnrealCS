using System;
namespace UnrealEngine
{
	/// <summary>The source data for runtime resources.</summary>
	public partial struct FGPUSpriteResourceData
	{
		/// <summary>Scale and bias to be applied to the color of sprites.</summary>
		public FVector4 ColorScale;
		public FVector4 ColorBias;
		/// <summary>Scale and bias to be applied to the misc curve.</summary>
		public FVector4 MiscScale;
		public FVector4 MiscBias;
		/// <summary>Scale and bias to be applied to the simulation attribute curves.</summary>
		public FVector4 SimulationAttrCurveScale;
		public FVector4 SimulationAttrCurveBias;
		/// <summary>Size of subimages. X:SubImageCountH Y:SubImageCountV Z:1/SubImageCountH W:1/SubImageCountV</summary>
		public FVector4 SubImageSize;
		/// <summary>SizeBySpeed parameters. XY=SpeedScale ZW=MaxSpeedScale.</summary>
		public FVector4 SizeBySpeed;
		/// <summary>Constant acceleration to apply to particles.</summary>
		public FVector ConstantAcceleration;
		/// <summary>Offset at which to orbit.</summary>
		public FVector OrbitOffsetBase;
		public FVector OrbitOffsetRange;
		/// <summary>Frequency at which the particle orbits around each axis.</summary>
		public FVector OrbitFrequencyBase;
		public FVector OrbitFrequencyRange;
		/// <summary>Phase offset of orbit around each axis.</summary>
		public FVector OrbitPhaseBase;
		public FVector OrbitPhaseRange;
		/// <summary>Scale to apply to global vector fields.</summary>
		public float GlobalVectorFieldScale;
		/// <summary>Tightness override value for the global vector fields.</summary>
		public float GlobalVectorFieldTightness;
		/// <summary>Scale to apply to per-particle vector field scale.</summary>
		public float PerParticleVectorFieldScale;
		/// <summary>Bias to apply to per-particle vector field scale.</summary>
		public float PerParticleVectorFieldBias;
		/// <summary>Scale to apply to per-particle drag coefficient.</summary>
		public float DragCoefficientScale;
		/// <summary>Bias to apply to per-particle drag coefficient.</summary>
		public float DragCoefficientBias;
		/// <summary>Scale to apply to per-particle damping factor.</summary>
		public float ResilienceScale;
		/// <summary>Bias to apply to per-particle damping factor.</summary>
		public float ResilienceBias;
		/// <summary>Scale to apply to per-particle size for collision.</summary>
		public float CollisionRadiusScale;
		/// <summary>Bias to apply to per-particle size for collision.</summary>
		public float CollisionRadiusBias;
		/// <summary>Bias applied to relative time upon collision.</summary>
		public float CollisionTimeBias;
		/// <summary>Control on reflection's random distribution spread.</summary>
		public float CollisionRandomSpread;
		/// <summary>Control on reflection's random distribution when colliding. (1=uniform distribution)</summary>
		public float CollisionRandomDistribution;
		/// <summary>One minus the coefficient of friction applied to particles upon collision.</summary>
		public float OneMinusFriction;
		/// <summary>Scale to apply to per-particle rotation rate.</summary>
		public float RotationRateScale;
		/// <summary>How much to stretch sprites based on camera motion blur.</summary>
		public float CameraMotionBlurAmount;
		/// <summary>Screen alignment for particles.</summary>
		public EParticleScreenAlignment ScreenAlignment;
		/// <summary>The method for locking the particles to a particular axis.</summary>
		public EParticleAxisLock LockAxisFlag;
		/// <summary>Pivot offset in UV space for placing the verts of each particle.</summary>
		public FVector2D PivotOffset;
		/// <summary>If true, removes the HMD view roll (e.g. in VR)</summary>
		public bool bRemoveHMDRoll;
		/// <summary>The distance at which PSA_FacingCameraDistanceBlend    is fully PSA_Square</summary>
		public float MinFacingCameraBlendDistance;
		/// <summary>The distance at which PSA_FacingCameraDistanceBlend    is fully PSA_FacingCameraPosition</summary>
		public float MaxFacingCameraBlendDistance;
		
	}
	
}
