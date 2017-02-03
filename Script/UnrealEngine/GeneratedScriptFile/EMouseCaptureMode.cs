using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EMouseCaptureMode:byte
	{
		/// <summary>Do not capture the mouse at all</summary>
		NoCapture=0,
		/// <summary>Capture the mouse permanently when the viewport is clicked, and consume the initial mouse down that caused the capture so it isn't processed by player input</summary>
		CapturePermanently=1,
		/// <summary>Capture the mouse permanently when the viewport is clicked, and allow player input to process the mouse down that caused the capture</summary>
		CapturePermanently_IncludingInitialMouseDown=2,
		/// <summary>Capture the mouse during a mouse down, releases on mouse up</summary>
		CaptureDuringMouseDown=3,
		/// <summary>Capture only when the right mouse button is down, not any of the other mouse buttons</summary>
		CaptureDuringRightMouseDown=4,
		EMouseCaptureMode_MAX=5,
		
	}
	
}
