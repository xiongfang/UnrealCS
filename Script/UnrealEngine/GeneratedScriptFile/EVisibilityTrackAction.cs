using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Visibility track actions</summary>
	public enum EVisibilityTrackAction:byte
	{
		/// <summary>Hides the object</summary>
		EVTA_Hide=0,
		/// <summary>Shows the object</summary>
		EVTA_Show=1,
		/// <summary>Toggles visibility of the object</summary>
		EVTA_Toggle=2,
		EVTA_MAX=3,
		
	}
	
}
