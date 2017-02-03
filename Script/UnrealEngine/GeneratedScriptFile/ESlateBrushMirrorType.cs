using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Possible options for mirroring the brush image</summary>
	public enum ESlateBrushMirrorType:byte
	{
		/// <summary>Don't mirror anything, just draw the texture as it is.</summary>
		NoMirror=0,
		/// <summary>Mirror the image horizontally.</summary>
		Horizontal=1,
		/// <summary>Mirror the image vertically.</summary>
		Vertical=2,
		/// <summary>Mirror in both directions.</summary>
		Both=3,
		ESlateBrushMirrorType_MAX=4,
		
	}
	
}
