using System;
namespace UnrealEngine
{
	/// <summary>The struct for defining the properties used when determining attenuation for a force feedback effect</summary>
	public partial struct FForceFeedbackAttenuationSettings
	{
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
