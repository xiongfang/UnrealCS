using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Controls where the drag widget visual will appear when dragged relative to the pointer performing
	/// the drag operation.
	/// </summary>
	public enum EDragPivot:byte
	{
		MouseDown=0,
		TopLeft=1,
		TopCenter=2,
		TopRight=3,
		CenterLeft=4,
		CenterCenter=5,
		CenterRight=6,
		BottomLeft=7,
		BottomCenter=8,
		BottomRight=9,
		EDragPivot_MAX=10,
		
	}
	
}
