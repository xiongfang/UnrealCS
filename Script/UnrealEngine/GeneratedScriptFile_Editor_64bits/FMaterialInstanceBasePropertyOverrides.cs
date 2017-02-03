#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Properties from the base material that can be overridden in material instances.</summary>
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FMaterialInstanceBasePropertyOverrides
	{
		/// <summary>Enables override of the opacity mask clip value.</summary>
		public bool bOverride_OpacityMaskClipValue
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Enables override of the blend mode.</summary>
		public bool bOverride_BlendMode
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Enables override of the shading model.</summary>
		public bool bOverride_ShadingModel
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 2, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 2, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Enables override of the two sided property.</summary>
		public bool bOverride_DitheredLODTransition
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 3, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 3, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Enables override of the two sided property.</summary>
		public bool bOverride_TwoSided
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 1, 255); } }}
			
		}
		/// <summary>If BlendMode is BLEND_Masked, the surface is not rendered where OpacityMask < OpacityMaskClipValue.</summary>
		[FieldOffset(8)]
		public float OpacityMaskClipValue;
		/// <summary>The blend mode</summary>
		[FieldOffset(12)]
		public EBlendMode BlendMode;
		/// <summary>The shading model</summary>
		[FieldOffset(13)]
		public EMaterialShadingModel ShadingModel;
		/// <summary>Indicates that the material should be rendered without backface culling and the normal should be flipped for backfaces.</summary>
		public bool TwoSided
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Whether the material should support a dithered LOD transition when used with the foliage system.</summary>
		public bool DitheredLODTransition
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 2, 2); } }}
			
		}
		
	}
	
}
#endif
#endif
