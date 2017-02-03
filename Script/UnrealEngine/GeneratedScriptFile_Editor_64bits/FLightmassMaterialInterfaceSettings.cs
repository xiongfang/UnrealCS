#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>UMaterial interface settings for Lightmass</summary>
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FLightmassMaterialInterfaceSettings
	{
		/// <summary>If true, forces translucency to cast static shadows as if the material were masked.</summary>
		public bool bCastShadowAsMasked
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Scales the emissive contribution of this material to static lighting.</summary>
		[FieldOffset(4)]
		public float EmissiveBoost;
		/// <summary>Scales the diffuse contribution of this material to static lighting.</summary>
		[FieldOffset(8)]
		public float DiffuseBoost;
		/// <summary>
		/// Scales the resolution that this material's attributes were exported at.
		/// This is useful for increasing material resolution when details are needed.
		/// </summary>
		[FieldOffset(12)]
		public float ExportResolutionScale;
		/// <summary>If true, override the bCastShadowAsMasked setting of the parent material.</summary>
		public bool bOverrideCastShadowAsMasked
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 1, 1); } }}
			
		}
		/// <summary>If true, override the emissive boost setting of the parent material.</summary>
		public bool bOverrideEmissiveBoost
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 2, 2); } }}
			
		}
		/// <summary>If true, override the diffuse boost setting of the parent material.</summary>
		public bool bOverrideDiffuseBoost
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 4, 4); } }}
			
		}
		/// <summary>If true, override the export resolution scale setting of the parent material.</summary>
		public bool bOverrideExportResolutionScale
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 8, 8); } }}
			
		}
		
	}
	
}
#endif
#endif
