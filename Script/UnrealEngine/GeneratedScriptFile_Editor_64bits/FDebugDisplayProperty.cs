#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Debug property display functionality to interact with this, use "display", "displayall", "displayclear"
	/// @see UGameViewportClient
	/// @see FDebugDisplayProperty
	/// @see DrawStatsHUD
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FDebugDisplayProperty
	{
		/// <summary>the object whose property to display. If this is a class, all objects of that class are drawn.</summary>
		/// <summary>if Obj is a class and WithinClass is not nullptr, further limit the display to objects that have an Outer of WithinClass</summary>
		
	}
	
}
#endif
#endif
