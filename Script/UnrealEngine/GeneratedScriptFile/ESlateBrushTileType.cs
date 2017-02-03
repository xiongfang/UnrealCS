using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enumerates tiling options for image drawing.</summary>
	public enum ESlateBrushTileType:byte
	{
		/// <summary>Just stretch</summary>
		NoTile=0,
		/// <summary>Tile the image horizontally</summary>
		Horizontal=1,
		/// <summary>Tile the image vertically</summary>
		Vertical=2,
		/// <summary>Tile in both directions</summary>
		Both=3,
		ESlateBrushTileType_MAX=4,
		
	}
	
}
