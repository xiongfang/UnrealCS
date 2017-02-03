using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Required condition for this track to be enabled</summary>
	public enum ETrackActiveCondition:byte
	{
		/// <summary>Track is always active</summary>
		ETAC_Always=0,
		/// <summary>Track is active when extreme content (gore) is enabled</summary>
		ETAC_GoreEnabled=1,
		/// <summary>Track is active when extreme content (gore) is disabled</summary>
		ETAC_GoreDisabled=2,
		ETAC_MAX=3,
		
	}
	
}
