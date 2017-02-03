using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ESettingsDOF:byte
	{
		/// <summary>Allows for full 3D movement and rotation.</summary>
		Full3D=0,
		/// <summary>Allows 2D movement along the Y-Z plane.</summary>
		YZPlane=1,
		/// <summary>Allows 2D movement along the X-Z plane.</summary>
		XZPlane=2,
		/// <summary>Allows 2D movement along the X-Y plane.</summary>
		XYPlane=3,
		ESettingsDOF_MAX=4,
		
	}
	
}
