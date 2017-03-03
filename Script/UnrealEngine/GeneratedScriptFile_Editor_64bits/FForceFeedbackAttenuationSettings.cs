#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>The struct for defining the properties used when determining attenuation for a force feedback effect</summary>
	[StructLayout(LayoutKind.Explicit,Size=168)]
	public partial struct FForceFeedbackAttenuationSettings
	{
		[FieldOffset(16)]
		public FRuntimeFloatCurve CustomAttenuationCurve;
		/// <summary>The shape of the attenuation volume.</summary>
		[FieldOffset(136)]
		public EAttenuationShape AttenuationShape;
		/// <summary>The volume at maximum distance in deciBels.</summary>
		[FieldOffset(140)]
		public float dBAttenuationAtMax;
		/// <summary>
		/// The dimensions to use for the attenuation shape. Interpretation of the values differ per shape.
		///          Sphere  - X is Sphere Radius. Y and Z are unused
		///          Capsule - X is Capsule Half Height, Y is Capsule Radius, Z is unused
		///          Box     - X, Y, and Z are the Box's dimensions
		///          Cone    - X is Cone Radius, Y is Cone Angle, Z is Cone Falloff Angle
		/// </summary>
		[FieldOffset(144)]
		public FVector AttenuationShapeExtents;
		/// <summary>The distance back from the sound's origin to begin the cone when using the cone attenuation shape.</summary>
		[FieldOffset(156)]
		public float ConeOffset;
		/// <summary>The distance over which falloff occurs.</summary>
		[FieldOffset(160)]
		public float FalloffDistance;
		
	}
	
}
#endif
#endif
