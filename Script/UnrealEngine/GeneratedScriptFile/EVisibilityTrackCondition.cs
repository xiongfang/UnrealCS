using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Required condition for firing this event</summary>
	public enum EVisibilityTrackCondition:byte
	{
		/// <summary>Always play this event</summary>
		EVTC_Always=0,
		/// <summary>Only play this event when extreme content (gore) is enabled</summary>
		EVTC_GoreEnabled=1,
		/// <summary>Only play this event when extreme content (gore) is disabled</summary>
		EVTC_GoreDisabled=2,
		EVTC_MAX=3,
		
	}
	
}
