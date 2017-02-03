using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Used by IStereoLayer</summary>
	public enum EStereoLayerType:byte
	{
		/// <summary>Location within the world</summary>
		SLT_WorldLocked=0,
		/// <summary>Location within the HMD tracking space</summary>
		SLT_TrackerLocked=1,
		/// <summary>Location within the view space</summary>
		SLT_FaceLocked=2,
		SLT_MAX=3,
		
	}
	
}
