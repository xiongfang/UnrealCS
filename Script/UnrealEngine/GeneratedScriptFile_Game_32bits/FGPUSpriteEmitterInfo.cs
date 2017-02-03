#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=576)]
	public partial struct FGPUSpriteEmitterInfo
	{
		public TObjectArray<UParticleModule> SpawnModules
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<UParticleModule>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+12, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+12, false);}}}
			
		}
		[FieldOffset(32)]
		public FGPUSpriteLocalVectorFieldInfo LocalVectorField;
		[FieldOffset(144)]
		public FFloatDistribution VectorFieldScale;
		[FieldOffset(172)]
		public FFloatDistribution DragCoefficient;
		[FieldOffset(200)]
		public FFloatDistribution PointAttractorStrength;
		[FieldOffset(228)]
		public FFloatDistribution Resilience;
		[FieldOffset(256)]
		public FVector ConstantAcceleration;
		[FieldOffset(268)]
		public FVector PointAttractorPosition;
		[FieldOffset(280)]
		public float PointAttractorRadiusSq;
		[FieldOffset(284)]
		public FVector OrbitOffsetBase;
		[FieldOffset(296)]
		public FVector OrbitOffsetRange;
		[FieldOffset(308)]
		public FVector2D InvMaxSize;
		[FieldOffset(316)]
		public float InvRotationRateScale;
		[FieldOffset(320)]
		public float MaxLifetime;
		[FieldOffset(324)]
		public int MaxParticleCount;
		[FieldOffset(328)]
		public EParticleScreenAlignment ScreenAlignment;
		[FieldOffset(329)]
		public EParticleAxisLock LockAxisFlag;
		public bool bEnableCollision
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 332, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 332, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(336)]
		public EParticleCollisionMode CollisionMode;
		public bool bRemoveHMDRoll
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 340, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 340, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(344)]
		public float MinFacingCameraBlendDistance;
		[FieldOffset(348)]
		public float MaxFacingCameraBlendDistance;
		[FieldOffset(352)]
		public FRawDistributionVector DynamicColor;
		[FieldOffset(416)]
		public FRawDistributionFloat DynamicAlpha;
		[FieldOffset(456)]
		public FRawDistributionVector DynamicColorScale;
		[FieldOffset(520)]
		public FRawDistributionFloat DynamicAlphaScale;
		
	}
	
}
#endif
#endif
