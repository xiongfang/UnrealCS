using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EDOFMode:byte
	{
		/// <summary>Inherits the degrees of freedom from the project settings.</summary>
		Default=0,
		/// <summary>Specifies which axis to freeze rotation and movement along.</summary>
		SixDOF=1,
		/// <summary>Allows 2D movement along the Y-Z plane.</summary>
		YZPlane=2,
		/// <summary>Allows 2D movement along the X-Z plane.</summary>
		XZPlane=3,
		/// <summary>Allows 2D movement along the X-Y plane.</summary>
		XYPlane=4,
		/// <summary>Allows 2D movement along the plane of a given normal</summary>
		CustomPlane=5,
		/// <summary>No constraints.</summary>
		None=6,
		EDOFMode_MAX=7,
		
	}
	
}
