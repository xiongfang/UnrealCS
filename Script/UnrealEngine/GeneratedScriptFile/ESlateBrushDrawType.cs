using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enumerates ways in which an image can be drawn.</summary>
	public enum ESlateBrushDrawType:byte
	{
		/// <summary>Don't do anything</summary>
		NoDrawType=0,
		/// <summary>Draw a 3x3 box, where the sides and the middle stretch based on the Margin</summary>
		Box=1,
		/// <summary>Draw a 3x3 border where the sides tile and the middle is empty</summary>
		Border=2,
		/// <summary>Draw an image; margin is ignored</summary>
		Image=3,
		ESlateBrushDrawType_MAX=4,
		
	}
	
}
