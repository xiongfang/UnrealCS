using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>This is used by the drawing passes to determine tessellation policy, so changes here need to be supported in native code.</summary>
	public enum EMaterialTessellationMode:byte
	{
		/// <summary>Tessellation disabled.</summary>
		MTM_NoTessellation=0,
		/// <summary>Simple tessellation.</summary>
		MTM_FlatTessellation=1,
		/// <summary>Simple spline based tessellation.</summary>
		MTM_PNTriangles=2,
		MTM_MAX=3,
		
	}
	
}
