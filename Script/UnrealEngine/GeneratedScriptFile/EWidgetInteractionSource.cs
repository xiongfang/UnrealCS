using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// The interaction source for the widget interaction component, e.g. where do we try and
	/// trace from to try to find a widget under a virtual pointer device.
	/// </summary>
	public enum EWidgetInteractionSource:byte
	{
		/// <summary>Sends traces from the world location and orientation of the interaction component.</summary>
		World=0,
		/// <summary>Sends traces from the mouse location of the first local player controller.</summary>
		Mouse=1,
		/// <summary>Sends trace from the center of the first local player's screen.</summary>
		CenterScreen=2,
		/// <summary>
		/// Sends traces from a custom location determined by the user.  Will use whatever
		/// FHitResult is set by the call to SetCustomHitResult.
		/// </summary>
		Custom=3,
		EWidgetInteractionSource_MAX=4,
		
	}
	
}
