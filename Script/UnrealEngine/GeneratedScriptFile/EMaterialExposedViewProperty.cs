using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EMaterialExposedViewProperty:byte
	{
		/// <summary>Horizontal and vertical size of the view's buffer in pixels</summary>
		MEVP_BufferSize=0,
		/// <summary>Horizontal and vertical field of view angles in radian</summary>
		MEVP_FieldOfView=1,
		/// <summary>Tan(FieldOfView * 0.5)</summary>
		MEVP_TanHalfFieldOfView=2,
		/// <summary>Horizontal and vertical size of the view in pixels</summary>
		MEVP_ViewSize=3,
		/// <summary>Absolute world space view position (differs from the camera position in the shadow passes)</summary>
		MEVP_WorldSpaceViewPosition=4,
		/// <summary>Absolute world space camera position</summary>
		MEVP_WorldSpaceCameraPosition=5,
		MEVP_MAX=6,
		
	}
	
}
