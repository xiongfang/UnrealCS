using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enum for different usage cases of level streaming volumes.</summary>
	public enum EStreamingVolumeUsage:byte
	{
		SVB_Loading=0,
		SVB_LoadingAndVisibility=1,
		SVB_VisibilityBlockingOnLoad=2,
		SVB_BlockingOnLoad=3,
		SVB_LoadingNotVisible=4,
		SVB_MAX=5,
		
	}
	
}
