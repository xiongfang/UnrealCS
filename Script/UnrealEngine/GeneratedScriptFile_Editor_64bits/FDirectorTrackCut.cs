#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Information for one cut in this track.</summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FDirectorTrackCut
	{
		/// <summary>Time to perform the cut.</summary>
		[FieldOffset(0)]
		public float Time;
		/// <summary>Time taken to move view to new camera.</summary>
		[FieldOffset(4)]
		public float TransitionTime;
		/// <summary>GroupName of UInterpGroup to cut viewpoint to.</summary>
		[FieldOffset(8)]
		public FName TargetCamGroup;
		/// <summary>Shot number for developer reference</summary>
		[FieldOffset(20)]
		public int ShotNumber;
		
	}
	
}
#endif
#endif
