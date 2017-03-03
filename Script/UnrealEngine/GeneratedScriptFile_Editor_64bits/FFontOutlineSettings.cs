#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Settings for applying an outline to a font</summary>
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FFontOutlineSettings
	{
		/// <summary>Size of the outline in slate units (at 1.0 font scale this unit is a pixel)</summary>
		[FieldOffset(0)]
		public int OutlineSize;
		/// <summary>Optional material to apply to the outline</summary>
		/// <summary>The color of the outline for any character in this font</summary>
		[FieldOffset(16)]
		public FLinearColor OutlineColor;
		/// <summary>
		/// If checked, the outline will be completely translucent where the filled area will be.  This allows for a separate fill alpha value
		/// The trade off when enabling this is slightly worse quality for completely opaque fills where the inner outline border meets the fill area
		/// </summary>
		public bool bSeparateFillAlpha
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
