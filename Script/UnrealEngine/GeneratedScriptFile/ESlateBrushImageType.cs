using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enumerates brush image types.</summary>
	public enum ESlateBrushImageType:byte
	{
		/// <summary>No image is loaded.  Color only brushes, transparent brushes etc.</summary>
		NoImage=0,
		/// <summary>The image to be loaded is in full color.</summary>
		FullColor=1,
		/// <summary>The image is a special texture in linear space (usually a rendering resource such as a lookup table).</summary>
		Linear=2,
		ESlateBrushImageType_MAX=3,
		
	}
	
}
