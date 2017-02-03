using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>For HMDs that support it, this specifies whether the origin of the tracking universe will be at the floor, or at the user's eye height</summary>
	public enum EHMDTrackingOrigin:byte
	{
		Floor=0,
		Eye=1,
		EHMDTrackingOrigin_MAX=2,
		
	}
	
}
