#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Per-object settings for Lightmass</summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FLightmassPrimitiveSettings
	{
		/// <summary>If true, this object will be lit as if it receives light from both sides of its polygons.</summary>
		public bool bUseTwoSidedLighting
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 1); } }}
			
		}
		/// <summary>If true, this object will only shadow indirect lighting.</summary>
		public bool bShadowIndirectOnly
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 2, 2); } }}
			
		}
		/// <summary>If true, allow using the emissive for static lighting.</summary>
		public bool bUseEmissiveForStaticLighting
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 4, 4); } }}
			
		}
		/// <summary>
		/// Typically the triangle normal is used for hemisphere gathering which prevents incorrect self-shadowing from artist-tweaked vertex normals.
		/// However in the case of foliage whose vertex normal has been setup to match the underlying terrain, gathering in the direction of the vertex normal is desired.
		/// </summary>
		public bool bUseVertexNormalForHemisphereGather
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 8, 8); } }}
			
		}
		/// <summary>Direct lighting falloff exponent for mesh area lights created from emissive areas on this primitive.</summary>
		[FieldOffset(4)]
		public float EmissiveLightFalloffExponent;
		/// <summary>
		/// Direct lighting influence radius.
		/// The default is 0, which means the influence radius should be automatically generated based on the emissive light brightness.
		/// Values greater than 0 override the automatic method.
		/// </summary>
		[FieldOffset(8)]
		public float EmissiveLightExplicitInfluenceRadius;
		/// <summary>Scales the emissive contribution of all materials applied to this object.</summary>
		[FieldOffset(12)]
		public float EmissiveBoost;
		/// <summary>Scales the diffuse contribution of all materials applied to this object.</summary>
		[FieldOffset(16)]
		public float DiffuseBoost;
		/// <summary>Fraction of samples taken that must be occluded in order to reach full occlusion.</summary>
		[FieldOffset(20)]
		public float FullyOccludedSamplesFraction;
		
	}
	
}
#endif
#endif
