#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=208)]
	public partial struct FAttenuationSettings
	{
		public bool bAttenuate
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 1); } }}
			
		}
		public bool bSpatialize
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 2, 2); } }}
			
		}
		public bool bAttenuateWithLPF
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 4, 4); } }}
			
		}
		public bool bEnableListenerFocus
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 8, 8); } }}
			
		}
		public bool bEnableOcclusion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 16, 16); } }}
			
		}
		public bool bUseComplexCollisionForOcclusion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 32, 32); } }}
			
		}
		[FieldOffset(4)]
		public ESoundDistanceModel DistanceAlgorithm;
		[FieldOffset(8)]
		public FRuntimeFloatCurve CustomAttenuationCurve;
		[FieldOffset(96)]
		public ESoundDistanceCalc DistanceType;
		[FieldOffset(97)]
		public EAttenuationShape AttenuationShape;
		[FieldOffset(100)]
		public float dBAttenuationAtMax;
		[FieldOffset(104)]
		public float OmniRadius;
		[FieldOffset(108)]
		public float StereoSpread;
		[FieldOffset(112)]
		public ESoundSpatializationAlgorithm SpatializationAlgorithm;
		[FieldOffset(116)]
		public float RadiusMin;
		[FieldOffset(120)]
		public float RadiusMax;
		[FieldOffset(124)]
		public FVector AttenuationShapeExtents;
		[FieldOffset(136)]
		public float ConeOffset;
		[FieldOffset(140)]
		public float FalloffDistance;
		[FieldOffset(144)]
		public float LPFRadiusMin;
		[FieldOffset(148)]
		public float LPFRadiusMax;
		[FieldOffset(152)]
		public float LPFFrequencyAtMin;
		[FieldOffset(156)]
		public float LPFFrequencyAtMax;
		[FieldOffset(160)]
		public float FocusAzimuth;
		[FieldOffset(164)]
		public float NonFocusAzimuth;
		[FieldOffset(168)]
		public float FocusDistanceScale;
		[FieldOffset(172)]
		public float NonFocusDistanceScale;
		[FieldOffset(176)]
		public float FocusPriorityScale;
		[FieldOffset(180)]
		public float NonFocusPriorityScale;
		[FieldOffset(184)]
		public float FocusVolumeAttenuation;
		[FieldOffset(188)]
		public float NonFocusVolumeAttenuation;
		[FieldOffset(192)]
		public ECollisionChannel OcclusionTraceChannel;
		[FieldOffset(196)]
		public float OcclusionLowPassFilterFrequency;
		[FieldOffset(200)]
		public float OcclusionVolumeAttenuation;
		[FieldOffset(204)]
		public float OcclusionInterpolationTime;
		
	}
	
}
#endif
#endif
