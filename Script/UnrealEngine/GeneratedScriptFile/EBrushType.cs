using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EBrushType:byte
	{
		/// <summary>Default/builder brush.</summary>
		Brush_Default=0,
		/// <summary>Add to world.</summary>
		Brush_Add=1,
		/// <summary>Subtract from world.</summary>
		Brush_Subtract=2,
		Brush_MAX=3,
		
	}
	
}
