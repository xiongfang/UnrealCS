#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=232)]
	public partial struct FSoundAttenuationSettings
	{
		public bool bAttenuate
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 124, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 124, 1, 0, 1, 1); } }}
			
		}
		public bool bSpatialize
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 124, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 124, 1, 0, 2, 2); } }}
			
		}
		public bool bAttenuateWithLPF
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 124, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 124, 1, 0, 4, 4); } }}
			
		}
		public bool bEnableListenerFocus
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 124, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 124, 1, 0, 8, 8); } }}
			
		}
		public bool bEnableOcclusion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 124, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 124, 1, 0, 16, 16); } }}
			
		}
		public bool bUseComplexCollisionForOcclusion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 124, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 124, 1, 0, 32, 32); } }}
			
		}
		[FieldOffset(128)]
		public ESoundDistanceCalc DistanceType;
		[FieldOffset(132)]
		public float OmniRadius;
		[FieldOffset(136)]
		public float StereoSpread;
		[FieldOffset(140)]
		public ESoundSpatializationAlgorithm SpatializationAlgorithm;
		[FieldOffset(144)]
		public float RadiusMin;
		[FieldOffset(148)]
		public float RadiusMax;
		[FieldOffset(152)]
		public float LPFRadiusMin;
		[FieldOffset(156)]
		public float LPFRadiusMax;
		[FieldOffset(160)]
		public float LPFFrequencyAtMin;
		[FieldOffset(164)]
		public float LPFFrequencyAtMax;
		[FieldOffset(168)]
		public float FocusAzimuth;
		[FieldOffset(172)]
		public float NonFocusAzimuth;
		[FieldOffset(176)]
		public float FocusDistanceScale;
		[FieldOffset(180)]
		public float NonFocusDistanceScale;
		[FieldOffset(184)]
		public float FocusPriorityScale;
		[FieldOffset(188)]
		public float NonFocusPriorityScale;
		[FieldOffset(192)]
		public float FocusVolumeAttenuation;
		[FieldOffset(196)]
		public float NonFocusVolumeAttenuation;
		[FieldOffset(200)]
		public ECollisionChannel OcclusionTraceChannel;
		[FieldOffset(204)]
		public float OcclusionLowPassFilterFrequency;
		[FieldOffset(208)]
		public float OcclusionVolumeAttenuation;
		[FieldOffset(212)]
		public float OcclusionInterpolationTime;
		[FieldOffset(216)]
		public float ReverbWetLevelMin;
		[FieldOffset(220)]
		public float ReverbWetLevelMax;
		[FieldOffset(224)]
		public float ReverbDistanceMin;
		[FieldOffset(228)]
		public float ReverbDistanceMax;
		[FieldOffset(8)]
		public FRuntimeFloatCurve CustomAttenuationCurve;
		[FieldOffset(96)]
		public EAttenuationShape AttenuationShape;
		[FieldOffset(100)]
		public float dBAttenuationAtMax;
		[FieldOffset(104)]
		public FVector AttenuationShapeExtents;
		[FieldOffset(116)]
		public float ConeOffset;
		[FieldOffset(120)]
		public float FalloffDistance;
		
	}
	
}
#endif
#endif
