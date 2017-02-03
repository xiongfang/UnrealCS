#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=204)]
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
		[FieldOffset(1)]
		public ESoundDistanceModel DistanceAlgorithm;
		[FieldOffset(4)]
		public FRuntimeFloatCurve CustomAttenuationCurve;
		[FieldOffset(92)]
		public ESoundDistanceCalc DistanceType;
		[FieldOffset(93)]
		public EAttenuationShape AttenuationShape;
		[FieldOffset(96)]
		public float dBAttenuationAtMax;
		[FieldOffset(100)]
		public float OmniRadius;
		[FieldOffset(104)]
		public float StereoSpread;
		[FieldOffset(108)]
		public ESoundSpatializationAlgorithm SpatializationAlgorithm;
		[FieldOffset(112)]
		public float RadiusMin;
		[FieldOffset(116)]
		public float RadiusMax;
		[FieldOffset(120)]
		public FVector AttenuationShapeExtents;
		[FieldOffset(132)]
		public float ConeOffset;
		[FieldOffset(136)]
		public float FalloffDistance;
		[FieldOffset(140)]
		public float LPFRadiusMin;
		[FieldOffset(144)]
		public float LPFRadiusMax;
		[FieldOffset(148)]
		public float LPFFrequencyAtMin;
		[FieldOffset(152)]
		public float LPFFrequencyAtMax;
		[FieldOffset(156)]
		public float FocusAzimuth;
		[FieldOffset(160)]
		public float NonFocusAzimuth;
		[FieldOffset(164)]
		public float FocusDistanceScale;
		[FieldOffset(168)]
		public float NonFocusDistanceScale;
		[FieldOffset(172)]
		public float FocusPriorityScale;
		[FieldOffset(176)]
		public float NonFocusPriorityScale;
		[FieldOffset(180)]
		public float FocusVolumeAttenuation;
		[FieldOffset(184)]
		public float NonFocusVolumeAttenuation;
		[FieldOffset(188)]
		public ECollisionChannel OcclusionTraceChannel;
		[FieldOffset(192)]
		public float OcclusionLowPassFilterFrequency;
		[FieldOffset(196)]
		public float OcclusionVolumeAttenuation;
		[FieldOffset(200)]
		public float OcclusionInterpolationTime;
		
	}
	
}
#endif
#endif
