using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Specifies which shader generated offsets should included in the world position (displacement/WPO etc.)</summary>
	public enum EWorldPositionIncludedOffsets:byte
	{
		/// <summary>Absolute world position with all material shader offsets applied</summary>
		WPT_Default=0,
		/// <summary>Absolute world position with no material shader offsets applied</summary>
		WPT_ExcludeAllShaderOffsets=1,
		/// <summary>Camera relative world position with all material shader offsets applied</summary>
		WPT_CameraRelative=2,
		/// <summary>Camera relative world position with no material shader offsets applied</summary>
		WPT_CameraRelativeNoOffsets=3,
		WPT_MAX=4,
		
	}
	
}
