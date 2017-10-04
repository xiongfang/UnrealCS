using System;
namespace UnrealEngine
{
	/// <summary>The settings for attenuating.</summary>
	public partial struct FSoundAttenuationSettings
	{
		/// <summary>Enable attenuation via volume.</summary>
		public bool bAttenuate;
		/// <summary>Enable the source to be positioned in 3D.</summary>
		public bool bSpatialize;
		/// <summary>Enable attenuation via low pass filter.</summary>
		public bool bAttenuateWithLPF;
		/// <summary>Whether or not listener-focus calculations are enabled for this attenuation.</summary>
		public bool bEnableListenerFocus;
		/// <summary>Whether or not to enable line-of-sight occlusion checking for the sound that plays in this audio component.</summary>
		public bool bEnableOcclusion;
		/// <summary>Whether or not to enable complex geometry occlusion checks.</summary>
		public bool bUseComplexCollisionForOcclusion;
		public ESoundDistanceCalc DistanceType;
		/// <summary>At what distance we start treating the sound source as spatialized</summary>
		public float OmniRadius;
		/// <summary>The distance between left and right stereo channels when stereo assets spatialized.</summary>
		public float StereoSpread;
		/// <summary>Which spatialization algorithm to use if spatializing mono sources.</summary>
		public ESoundSpatializationAlgorithm SpatializationAlgorithm;
		public float RadiusMin;
		public float RadiusMax;
		/// <summary>The range at which to start applying a low pass filter.</summary>
		public float LPFRadiusMin;
		/// <summary>The range at which to apply the maximum amount of low pass filter.</summary>
		public float LPFRadiusMax;
		/// <summary>The Frequency in hertz at which to set the LPF when the sound is at LPFRadiusMin. (defaults to bypass)</summary>
		public float LPFFrequencyAtMin;
		/// <summary>The Frequency in hertz at which to set the LPF when the sound is at LPFRadiusMax.</summary>
		public float LPFFrequencyAtMax;
		/// <summary>Azimuth angle (in degrees) relative to the listener forward vector which defines the focus region of sounds. Sounds playing at an angle less than this will be in focus.</summary>
		public float FocusAzimuth;
		/// <summary>Azimuth angle (in degrees) relative to the listener forward vector which defines the non-focus region of sounds. Sounds playing at an angle greater than this will be out of focus.</summary>
		public float NonFocusAzimuth;
		/// <summary>Amount to scale the distance calculation of sounds that are in-focus. Can be used to make in-focus sounds appear to be closer or further away than they actually are.</summary>
		public float FocusDistanceScale;
		/// <summary>Amount to scale the distance calculation of sounds that are not in-focus. Can be used to make in-focus sounds appear to be closer or further away than they actually are.</summary>
		public float NonFocusDistanceScale;
		/// <summary>Amount to scale the priority of sounds that are in focus. Can be used to boost the priority of sounds that are in focus.</summary>
		public float FocusPriorityScale;
		/// <summary>Amount to scale the priority of sounds that are not in-focus. Can be used to reduce the priority of sounds that are not in focus.</summary>
		public float NonFocusPriorityScale;
		/// <summary>Amount to attenuate sounds that are in focus. Can be overridden at the sound-level.</summary>
		public float FocusVolumeAttenuation;
		/// <summary>Amount to attenuate sounds that are not in focus. Can be overridden at the sound-level.</summary>
		public float NonFocusVolumeAttenuation;
		/// <summary>Which trace channel to use for audio occlusion checks.</summary>
		public ECollisionChannel OcclusionTraceChannel;
		/// <summary>The low pass filter frequency (in hertz) to apply if the sound playing in this audio component is occluded. This will override the frequency set in LowPassFilterFrequency. A frequency of 0.0 is the device sample rate and will bypass the filter.</summary>
		public float OcclusionLowPassFilterFrequency;
		/// <summary>The amount of volume attenuation to apply to sounds which are occluded.</summary>
		public float OcclusionVolumeAttenuation;
		/// <summary>The amount of time in seconds to interpolate to the target OcclusionLowPassFilterFrequency when a sound is occluded.</summary>
		public float OcclusionInterpolationTime;
		/// <summary>The amount to send to master reverb when sound is ReverbDistanceMin from listener.</summary>
		public float ReverbWetLevelMin;
		/// <summary>The amount to send to master reverb when sound is at ReverbDistanceMax from listener.</summary>
		public float ReverbWetLevelMax;
		/// <summary>The distance which defines the amount of reverb wet level defined in ReverbWetLevelMin.</summary>
		public float ReverbDistanceMin;
		/// <summary>The distance which defines the amount of reverb wet level defined in ReverbDistanceMax.</summary>
		public float ReverbDistanceMax;
		public FRuntimeFloatCurve CustomAttenuationCurve;
		/// <summary>The shape of the attenuation volume.</summary>
		public EAttenuationShape AttenuationShape;
		/// <summary>The volume at maximum distance in deciBels.</summary>
		public float dBAttenuationAtMax;
		/// <summary>
		/// The dimensions to use for the attenuation shape. Interpretation of the values differ per shape.
		///          Sphere  - X is Sphere Radius. Y and Z are unused
		///          Capsule - X is Capsule Half Height, Y is Capsule Radius, Z is unused
		///          Box     - X, Y, and Z are the Box's dimensions
		///          Cone    - X is Cone Radius, Y is Cone Angle, Z is Cone Falloff Angle
		/// </summary>
		public FVector AttenuationShapeExtents;
		/// <summary>The distance back from the sound's origin to begin the cone when using the cone attenuation shape.</summary>
		public float ConeOffset;
		/// <summary>The distance over which falloff occurs.</summary>
		public float FalloffDistance;
		
	}
	
}
