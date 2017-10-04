using System;
namespace UnrealEngine
{
	/// <summary>Per-object settings for Lightmass</summary>
	public partial struct FLightmassPrimitiveSettings
	{
		/// <summary>If true, this object will be lit as if it receives light from both sides of its polygons.</summary>
		public bool bUseTwoSidedLighting;
		/// <summary>If true, this object will only shadow indirect lighting.</summary>
		public bool bShadowIndirectOnly;
		/// <summary>If true, allow using the emissive for static lighting.</summary>
		public bool bUseEmissiveForStaticLighting;
		/// <summary>
		/// Typically the triangle normal is used for hemisphere gathering which prevents incorrect self-shadowing from artist-tweaked vertex normals.
		/// However in the case of foliage whose vertex normal has been setup to match the underlying terrain, gathering in the direction of the vertex normal is desired.
		/// </summary>
		public bool bUseVertexNormalForHemisphereGather;
		/// <summary>Direct lighting falloff exponent for mesh area lights created from emissive areas on this primitive.</summary>
		public float EmissiveLightFalloffExponent;
		/// <summary>
		/// Direct lighting influence radius.
		/// The default is 0, which means the influence radius should be automatically generated based on the emissive light brightness.
		/// Values greater than 0 override the automatic method.
		/// </summary>
		public float EmissiveLightExplicitInfluenceRadius;
		/// <summary>Scales the emissive contribution of all materials applied to this object.</summary>
		public float EmissiveBoost;
		/// <summary>Scales the diffuse contribution of all materials applied to this object.</summary>
		public float DiffuseBoost;
		/// <summary>Fraction of samples taken that must be occluded in order to reach full occlusion.</summary>
		public float FullyOccludedSamplesFraction;
		
	}
	
}
