using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enumerates ways to clear a scene.</summary>
	public enum EClearSceneOptions:byte
	{
		/// <summary>This option is fastest but can cause artifacts unless you render to every pixel. Make sure to use a skybox with this option!</summary>
		NoClear=0,
		/// <summary>Perform a full hardware clear before rendering. Most projects should use this option.</summary>
		HardwareClear=1,
		/// <summary>Draws a quad to perform the clear at the far plane, this is faster than a hardware clear on some GPUs.</summary>
		QuadAtMaxZ=2,
		EClearSceneOptions_MAX=3,
		
	}
	
}
