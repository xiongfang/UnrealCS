#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=352)]
	public partial struct FGPUSpriteResourceData
	{
		public TStructArray<FColor> QuantizedColorSamples
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FColor>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		public TStructArray<FColor> QuantizedMiscSamples
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FColor>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		public TStructArray<FColor> QuantizedSimulationAttrSamples
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FColor>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+32, false);}}}
			
		}
		[FieldOffset(48)]
		public FVector4 ColorScale;
		[FieldOffset(64)]
		public FVector4 ColorBias;
		[FieldOffset(80)]
		public FVector4 MiscScale;
		[FieldOffset(96)]
		public FVector4 MiscBias;
		[FieldOffset(112)]
		public FVector4 SimulationAttrCurveScale;
		[FieldOffset(128)]
		public FVector4 SimulationAttrCurveBias;
		[FieldOffset(144)]
		public FVector4 SubImageSize;
		[FieldOffset(160)]
		public FVector4 SizeBySpeed;
		[FieldOffset(176)]
		public FVector ConstantAcceleration;
		[FieldOffset(188)]
		public FVector OrbitOffsetBase;
		[FieldOffset(200)]
		public FVector OrbitOffsetRange;
		[FieldOffset(212)]
		public FVector OrbitFrequencyBase;
		[FieldOffset(224)]
		public FVector OrbitFrequencyRange;
		[FieldOffset(236)]
		public FVector OrbitPhaseBase;
		[FieldOffset(248)]
		public FVector OrbitPhaseRange;
		[FieldOffset(260)]
		public float GlobalVectorFieldScale;
		[FieldOffset(264)]
		public float GlobalVectorFieldTightness;
		[FieldOffset(268)]
		public float PerParticleVectorFieldScale;
		[FieldOffset(272)]
		public float PerParticleVectorFieldBias;
		[FieldOffset(276)]
		public float DragCoefficientScale;
		[FieldOffset(280)]
		public float DragCoefficientBias;
		[FieldOffset(284)]
		public float ResilienceScale;
		[FieldOffset(288)]
		public float ResilienceBias;
		[FieldOffset(292)]
		public float CollisionRadiusScale;
		[FieldOffset(296)]
		public float CollisionRadiusBias;
		[FieldOffset(300)]
		public float CollisionTimeBias;
		[FieldOffset(304)]
		public float CollisionRandomSpread;
		[FieldOffset(308)]
		public float CollisionRandomDistribution;
		[FieldOffset(312)]
		public float OneMinusFriction;
		[FieldOffset(316)]
		public float RotationRateScale;
		[FieldOffset(320)]
		public float CameraMotionBlurAmount;
		[FieldOffset(324)]
		public EParticleScreenAlignment ScreenAlignment;
		[FieldOffset(325)]
		public EParticleAxisLock LockAxisFlag;
		[FieldOffset(328)]
		public FVector2D PivotOffset;
		public bool bRemoveHMDRoll
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 336, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 336, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(340)]
		public float MinFacingCameraBlendDistance;
		[FieldOffset(344)]
		public float MaxFacingCameraBlendDistance;
		
	}
	
}
#endif
#endif
