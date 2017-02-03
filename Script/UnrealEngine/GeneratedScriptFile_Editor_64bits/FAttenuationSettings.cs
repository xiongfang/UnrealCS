#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>The settings for attenuating.</summary>
	[StructLayout(LayoutKind.Explicit,Size=248)]
	public partial struct FAttenuationSettings
	{
		/// <summary>Enable attenuation via volume.</summary>
		public bool bAttenuate
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Enable the source to be positioned in 3D.</summary>
		public bool bSpatialize
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 2, 2); } }}
			
		}
		/// <summary>Enable attenuation via low pass filter.</summary>
		public bool bAttenuateWithLPF
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 4, 4); } }}
			
		}
		/// <summary>Whether or not listener-focus calculations are enabled for this attenuation.</summary>
		public bool bEnableListenerFocus
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 8, 8); } }}
			
		}
		/// <summary>Whether or not to enable line-of-sight occlusion checking for the sound that plays in this audio component.</summary>
		public bool bEnableOcclusion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 16, 16); } }}
			
		}
		/// <summary>Whether or not to enable complex geometry occlusion checks.</summary>
		public bool bUseComplexCollisionForOcclusion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 32, 32); } }}
			
		}
		/// <summary>The type of volume versus distance algorithm to use for the attenuation model.</summary>
		[FieldOffset(4)]
		public ESoundDistanceModel DistanceAlgorithm;
		[FieldOffset(8)]
		public FRuntimeFloatCurve CustomAttenuationCurve;
		[FieldOffset(136)]
		public ESoundDistanceCalc DistanceType;
		/// <summary>The shape of the attenuation volume.</summary>
		[FieldOffset(137)]
		public EAttenuationShape AttenuationShape;
		/// <summary>The volume at maximum distance in deciBels.</summary>
		[FieldOffset(140)]
		public float dBAttenuationAtMax;
		/// <summary>At what distance we start treating the sound source as spatialized</summary>
		[FieldOffset(144)]
		public float OmniRadius;
		/// <summary>The distance between left and right stereo channels when stereo assets spatialized.</summary>
		[FieldOffset(148)]
		public float StereoSpread;
		/// <summary>Which spatialization algorithm to use if spatializing mono sources.</summary>
		[FieldOffset(152)]
		public ESoundSpatializationAlgorithm SpatializationAlgorithm;
		[FieldOffset(156)]
		public float RadiusMin;
		[FieldOffset(160)]
		public float RadiusMax;
		/// <summary>
		/// The dimensions to use for the attenuation shape. Interpretation of the values differ per shape.
		///          Sphere  - X is Sphere Radius. Y and Z are unused
		///          Capsule - X is Capsule Half Height, Y is Capsule Radius, Z is unused
		///          Box     - X, Y, and Z are the Box's dimensions
		///          Cone    - X is Cone Radius, Y is Cone Angle, Z is Cone Falloff Angle
		/// </summary>
		[FieldOffset(164)]
		public FVector AttenuationShapeExtents;
		/// <summary>The distance back from the sound's origin to begin the cone when using the cone attenuation shape.</summary>
		[FieldOffset(176)]
		public float ConeOffset;
		/// <summary>The distance over which falloff occurs.</summary>
		[FieldOffset(180)]
		public float FalloffDistance;
		/// <summary>The range at which to start applying a low pass filter.</summary>
		[FieldOffset(184)]
		public float LPFRadiusMin;
		/// <summary>The range at which to apply the maximum amount of low pass filter.</summary>
		[FieldOffset(188)]
		public float LPFRadiusMax;
		/// <summary>The Frequency in hertz at which to set the LPF when the sound is at LPFRadiusMin. (defaults to bypass)</summary>
		[FieldOffset(192)]
		public float LPFFrequencyAtMin;
		/// <summary>The Frequency in hertz at which to set the LPF when the sound is at LPFRadiusMax.</summary>
		[FieldOffset(196)]
		public float LPFFrequencyAtMax;
		/// <summary>Azimuth angle (in degrees) relative to the listener forward vector which defines the focus region of sounds. Sounds playing at an angle less than this will be in focus.</summary>
		[FieldOffset(200)]
		public float FocusAzimuth;
		/// <summary>Azimuth angle (in degrees) relative to the listener forward vector which defines the non-focus region of sounds. Sounds playing at an angle greater than this will be out of focus.</summary>
		[FieldOffset(204)]
		public float NonFocusAzimuth;
		/// <summary>Amount to scale the distance calculation of sounds that are in-focus. Can be used to make in-focus sounds appear to be closer or further away than they actually are.</summary>
		[FieldOffset(208)]
		public float FocusDistanceScale;
		/// <summary>Amount to scale the distance calculation of sounds that are not in-focus. Can be used to make in-focus sounds appear to be closer or further away than they actually are.</summary>
		[FieldOffset(212)]
		public float NonFocusDistanceScale;
		/// <summary>Amount to scale the priority of sounds that are in focus. Can be used to boost the priority of sounds that are in focus.</summary>
		[FieldOffset(216)]
		public float FocusPriorityScale;
		/// <summary>Amount to scale the priority of sounds that are not in-focus. Can be used to reduce the priority of sounds that are not in focus.</summary>
		[FieldOffset(220)]
		public float NonFocusPriorityScale;
		/// <summary>Amount to attenuate sounds that are in focus. Can be overridden at the sound-level.</summary>
		[FieldOffset(224)]
		public float FocusVolumeAttenuation;
		/// <summary>Amount to attenuate sounds that are not in focus. Can be overridden at the sound-level.</summary>
		[FieldOffset(228)]
		public float NonFocusVolumeAttenuation;
		/// <summary>Which trace channel to use for audio occlusion checks.</summary>
		[FieldOffset(232)]
		public ECollisionChannel OcclusionTraceChannel;
		/// <summary>The low pass filter frequency (in hertz) to apply if the sound playing in this audio component is occluded. This will override the frequency set in LowPassFilterFrequency. A frequency of 0.0 is the device sample rate and will bypass the filter.</summary>
		[FieldOffset(236)]
		public float OcclusionLowPassFilterFrequency;
		/// <summary>The amount of volume attenuation to apply to sounds which are occluded.</summary>
		[FieldOffset(240)]
		public float OcclusionVolumeAttenuation;
		/// <summary>The amount of time in seconds to interpolate to the target OcclusionLowPassFilterFrequency when a sound is occluded.</summary>
		[FieldOffset(244)]
		public float OcclusionInterpolationTime;
		
	}
	
}
#endif
#endif
