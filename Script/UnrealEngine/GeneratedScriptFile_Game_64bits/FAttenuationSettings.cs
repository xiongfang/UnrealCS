#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=248)]
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
		[FieldOffset(136)]
		public ESoundDistanceCalc DistanceType;
		[FieldOffset(137)]
		public EAttenuationShape AttenuationShape;
		[FieldOffset(140)]
		public float dBAttenuationAtMax;
		[FieldOffset(144)]
		public float OmniRadius;
		[FieldOffset(148)]
		public float StereoSpread;
		[FieldOffset(152)]
		public ESoundSpatializationAlgorithm SpatializationAlgorithm;
		[FieldOffset(156)]
		public float RadiusMin;
		[FieldOffset(160)]
		public float RadiusMax;
		[FieldOffset(164)]
		public FVector AttenuationShapeExtents;
		[FieldOffset(176)]
		public float ConeOffset;
		[FieldOffset(180)]
		public float FalloffDistance;
		[FieldOffset(184)]
		public float LPFRadiusMin;
		[FieldOffset(188)]
		public float LPFRadiusMax;
		[FieldOffset(192)]
		public float LPFFrequencyAtMin;
		[FieldOffset(196)]
		public float LPFFrequencyAtMax;
		[FieldOffset(200)]
		public float FocusAzimuth;
		[FieldOffset(204)]
		public float NonFocusAzimuth;
		[FieldOffset(208)]
		public float FocusDistanceScale;
		[FieldOffset(212)]
		public float NonFocusDistanceScale;
		[FieldOffset(216)]
		public float FocusPriorityScale;
		[FieldOffset(220)]
		public float NonFocusPriorityScale;
		[FieldOffset(224)]
		public float FocusVolumeAttenuation;
		[FieldOffset(228)]
		public float NonFocusVolumeAttenuation;
		[FieldOffset(232)]
		public ECollisionChannel OcclusionTraceChannel;
		[FieldOffset(236)]
		public float OcclusionLowPassFilterFrequency;
		[FieldOffset(240)]
		public float OcclusionVolumeAttenuation;
		[FieldOffset(244)]
		public float OcclusionInterpolationTime;
		
	}
	
}
#endif
#endif
