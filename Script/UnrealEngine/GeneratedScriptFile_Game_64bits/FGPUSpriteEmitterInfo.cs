#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=704)]
	public partial struct FGPUSpriteEmitterInfo
	{
		public TObjectArray<UParticleModule> SpawnModules
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<UParticleModule>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+24, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+24, false);}}}
			
		}
		[FieldOffset(48)]
		public FGPUSpriteLocalVectorFieldInfo LocalVectorField;
		[FieldOffset(160)]
		public FFloatDistribution VectorFieldScale;
		[FieldOffset(200)]
		public FFloatDistribution DragCoefficient;
		[FieldOffset(240)]
		public FFloatDistribution PointAttractorStrength;
		[FieldOffset(280)]
		public FFloatDistribution Resilience;
		[FieldOffset(320)]
		public FVector ConstantAcceleration;
		[FieldOffset(332)]
		public FVector PointAttractorPosition;
		[FieldOffset(344)]
		public float PointAttractorRadiusSq;
		[FieldOffset(348)]
		public FVector OrbitOffsetBase;
		[FieldOffset(360)]
		public FVector OrbitOffsetRange;
		[FieldOffset(372)]
		public FVector2D InvMaxSize;
		[FieldOffset(380)]
		public float InvRotationRateScale;
		[FieldOffset(384)]
		public float MaxLifetime;
		[FieldOffset(388)]
		public int MaxParticleCount;
		[FieldOffset(392)]
		public EParticleScreenAlignment ScreenAlignment;
		[FieldOffset(393)]
		public EParticleAxisLock LockAxisFlag;
		public bool bEnableCollision
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 396, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 396, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(400)]
		public EParticleCollisionMode CollisionMode;
		public bool bRemoveHMDRoll
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 404, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 404, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(408)]
		public float MinFacingCameraBlendDistance;
		[FieldOffset(412)]
		public float MaxFacingCameraBlendDistance;
		[FieldOffset(416)]
		public FRawDistributionVector DynamicColor;
		[FieldOffset(496)]
		public FRawDistributionFloat DynamicAlpha;
		[FieldOffset(552)]
		public FRawDistributionVector DynamicColorScale;
		[FieldOffset(632)]
		public FRawDistributionFloat DynamicAlphaScale;
		
	}
	
}
#endif
#endif
