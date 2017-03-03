#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=280)]
	public partial struct FSoundAttenuationSettings
	{
		public bool bAttenuate
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 168, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 168, 1, 0, 1, 1); } }}
			
		}
		public bool bSpatialize
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 168, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 168, 1, 0, 2, 2); } }}
			
		}
		public bool bAttenuateWithLPF
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 168, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 168, 1, 0, 4, 4); } }}
			
		}
		public bool bEnableListenerFocus
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 168, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 168, 1, 0, 8, 8); } }}
			
		}
		public bool bEnableOcclusion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 168, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 168, 1, 0, 16, 16); } }}
			
		}
		public bool bUseComplexCollisionForOcclusion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 168, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 168, 1, 0, 32, 32); } }}
			
		}
		[FieldOffset(172)]
		public ESoundDistanceCalc DistanceType;
		[FieldOffset(176)]
		public float OmniRadius;
		[FieldOffset(180)]
		public float StereoSpread;
		[FieldOffset(184)]
		public ESoundSpatializationAlgorithm SpatializationAlgorithm;
		[FieldOffset(188)]
		public float RadiusMin;
		[FieldOffset(192)]
		public float RadiusMax;
		[FieldOffset(196)]
		public float LPFRadiusMin;
		[FieldOffset(200)]
		public float LPFRadiusMax;
		[FieldOffset(204)]
		public float LPFFrequencyAtMin;
		[FieldOffset(208)]
		public float LPFFrequencyAtMax;
		[FieldOffset(212)]
		public float FocusAzimuth;
		[FieldOffset(216)]
		public float NonFocusAzimuth;
		[FieldOffset(220)]
		public float FocusDistanceScale;
		[FieldOffset(224)]
		public float NonFocusDistanceScale;
		[FieldOffset(228)]
		public float FocusPriorityScale;
		[FieldOffset(232)]
		public float NonFocusPriorityScale;
		[FieldOffset(236)]
		public float FocusVolumeAttenuation;
		[FieldOffset(240)]
		public float NonFocusVolumeAttenuation;
		[FieldOffset(244)]
		public ECollisionChannel OcclusionTraceChannel;
		[FieldOffset(248)]
		public float OcclusionLowPassFilterFrequency;
		[FieldOffset(252)]
		public float OcclusionVolumeAttenuation;
		[FieldOffset(256)]
		public float OcclusionInterpolationTime;
		[FieldOffset(260)]
		public float ReverbWetLevelMin;
		[FieldOffset(264)]
		public float ReverbWetLevelMax;
		[FieldOffset(268)]
		public float ReverbDistanceMin;
		[FieldOffset(272)]
		public float ReverbDistanceMax;
		[FieldOffset(16)]
		public FRuntimeFloatCurve CustomAttenuationCurve;
		[FieldOffset(136)]
		public EAttenuationShape AttenuationShape;
		[FieldOffset(140)]
		public float dBAttenuationAtMax;
		[FieldOffset(144)]
		public FVector AttenuationShapeExtents;
		[FieldOffset(156)]
		public float ConeOffset;
		[FieldOffset(160)]
		public float FalloffDistance;
		
	}
	
}
#endif
#endif
