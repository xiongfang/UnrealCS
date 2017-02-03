using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Supported windowing modes (mirrored from GenericWindow.h)</summary>
	public enum EWindowMode:byte
	{
		/// <summary>The window is in true fullscreen mode</summary>
		Fullscreen=0,
		/// <summary>The window has no border and takes up the entire area of the screen</summary>
		WindowedFullscreen=1,
		/// <summary>The window has a border and may not take up the entire screen area</summary>
		Windowed=2,
		EWindowMode_MAX=3,
		
	}
	
}
