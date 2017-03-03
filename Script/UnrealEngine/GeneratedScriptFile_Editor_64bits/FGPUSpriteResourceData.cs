#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>The source data for runtime resources.</summary>
	[StructLayout(LayoutKind.Explicit,Size=352)]
	public partial struct FGPUSpriteResourceData
	{
		/// <summary>Quantized color samples.</summary>
		public TStructArray<FColor> QuantizedColorSamples
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FColor>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		/// <summary>Quantized samples for misc curve attributes to be evaluated at runtime.</summary>
		public TStructArray<FColor> QuantizedMiscSamples
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FColor>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		/// <summary>Quantized samples for simulation attributes.</summary>
		public TStructArray<FColor> QuantizedSimulationAttrSamples
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FColor>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+32, false);}}}
			
		}
		/// <summary>Scale and bias to be applied to the color of sprites.</summary>
		[FieldOffset(48)]
		public FVector4 ColorScale;
		[FieldOffset(64)]
		public FVector4 ColorBias;
		/// <summary>Scale and bias to be applied to the misc curve.</summary>
		[FieldOffset(80)]
		public FVector4 MiscScale;
		[FieldOffset(96)]
		public FVector4 MiscBias;
		/// <summary>Scale and bias to be applied to the simulation attribute curves.</summary>
		[FieldOffset(112)]
		public FVector4 SimulationAttrCurveScale;
		[FieldOffset(128)]
		public FVector4 SimulationAttrCurveBias;
		/// <summary>Size of subimages. X:SubImageCountH Y:SubImageCountV Z:1/SubImageCountH W:1/SubImageCountV</summary>
		[FieldOffset(144)]
		public FVector4 SubImageSize;
		/// <summary>SizeBySpeed parameters. XY=SpeedScale ZW=MaxSpeedScale.</summary>
		[FieldOffset(160)]
		public FVector4 SizeBySpeed;
		/// <summary>Constant acceleration to apply to particles.</summary>
		[FieldOffset(176)]
		public FVector ConstantAcceleration;
		/// <summary>Offset at which to orbit.</summary>
		[FieldOffset(188)]
		public FVector OrbitOffsetBase;
		[FieldOffset(200)]
		public FVector OrbitOffsetRange;
		/// <summary>Frequency at which the particle orbits around each axis.</summary>
		[FieldOffset(212)]
		public FVector OrbitFrequencyBase;
		[FieldOffset(224)]
		public FVector OrbitFrequencyRange;
		/// <summary>Phase offset of orbit around each axis.</summary>
		[FieldOffset(236)]
		public FVector OrbitPhaseBase;
		[FieldOffset(248)]
		public FVector OrbitPhaseRange;
		/// <summary>Scale to apply to global vector fields.</summary>
		[FieldOffset(260)]
		public float GlobalVectorFieldScale;
		/// <summary>Tightness override value for the global vector fields.</summary>
		[FieldOffset(264)]
		public float GlobalVectorFieldTightness;
		/// <summary>Scale to apply to per-particle vector field scale.</summary>
		[FieldOffset(268)]
		public float PerParticleVectorFieldScale;
		/// <summary>Bias to apply to per-particle vector field scale.</summary>
		[FieldOffset(272)]
		public float PerParticleVectorFieldBias;
		/// <summary>Scale to apply to per-particle drag coefficient.</summary>
		[FieldOffset(276)]
		public float DragCoefficientScale;
		/// <summary>Bias to apply to per-particle drag coefficient.</summary>
		[FieldOffset(280)]
		public float DragCoefficientBias;
		/// <summary>Scale to apply to per-particle damping factor.</summary>
		[FieldOffset(284)]
		public float ResilienceScale;
		/// <summary>Bias to apply to per-particle damping factor.</summary>
		[FieldOffset(288)]
		public float ResilienceBias;
		/// <summary>Scale to apply to per-particle size for collision.</summary>
		[FieldOffset(292)]
		public float CollisionRadiusScale;
		/// <summary>Bias to apply to per-particle size for collision.</summary>
		[FieldOffset(296)]
		public float CollisionRadiusBias;
		/// <summary>Bias applied to relative time upon collision.</summary>
		[FieldOffset(300)]
		public float CollisionTimeBias;
		/// <summary>Control on reflection's random distribution spread.</summary>
		[FieldOffset(304)]
		public float CollisionRandomSpread;
		/// <summary>Control on reflection's random distribution when colliding. (1=uniform distribution)</summary>
		[FieldOffset(308)]
		public float CollisionRandomDistribution;
		/// <summary>One minus the coefficient of friction applied to particles upon collision.</summary>
		[FieldOffset(312)]
		public float OneMinusFriction;
		/// <summary>Scale to apply to per-particle rotation rate.</summary>
		[FieldOffset(316)]
		public float RotationRateScale;
		/// <summary>How much to stretch sprites based on camera motion blur.</summary>
		[FieldOffset(320)]
		public float CameraMotionBlurAmount;
		/// <summary>Screen alignment for particles.</summary>
		[FieldOffset(324)]
		public EParticleScreenAlignment ScreenAlignment;
		/// <summary>The method for locking the particles to a particular axis.</summary>
		[FieldOffset(325)]
		public EParticleAxisLock LockAxisFlag;
		/// <summary>Pivot offset in UV space for placing the verts of each particle.</summary>
		[FieldOffset(328)]
		public FVector2D PivotOffset;
		/// <summary>If true, removes the HMD view roll (e.g. in VR)</summary>
		public bool bRemoveHMDRoll
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 336, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 336, 1, 0, 1, 1); } }}
			
		}
		/// <summary>The distance at which PSA_FacingCameraDistanceBlend    is fully PSA_Square</summary>
		[FieldOffset(340)]
		public float MinFacingCameraBlendDistance;
		/// <summary>The distance at which PSA_FacingCameraDistanceBlend    is fully PSA_FacingCameraPosition</summary>
		[FieldOffset(344)]
		public float MaxFacingCameraBlendDistance;
		
	}
	
}
#endif
#endif
