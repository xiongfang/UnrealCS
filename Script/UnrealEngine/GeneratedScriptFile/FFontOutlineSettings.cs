using System;
namespace UnrealEngine
{
	/// <summary>Settings for applying an outline to a font</summary>
	public partial struct FFontOutlineSettings
	{
		/// <summary>Size of the outline in slate units (at 1.0 font scale this unit is a pixel)</summary>
		public int OutlineSize;
		/// <summary>Optional material to apply to the outline</summary>
		public UObject OutlineMaterial;
		/// <summary>The color of the outline for any character in this font</summary>
		public FLinearColor OutlineColor;
		/// <summary>
		/// If checked, the outline will be completely translucent where the filled area will be.  This allows for a separate fill alpha value
		/// The trade off when enabling this is slightly worse quality for completely opaque fills where the inner outline border meets the fill area
		/// </summary>
		public bool bSeparateFillAlpha;
		
	}
	
}
