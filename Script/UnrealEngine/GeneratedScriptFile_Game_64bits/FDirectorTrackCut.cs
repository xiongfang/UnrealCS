#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FDirectorTrackCut
	{
		[FieldOffset(0)]
		public float Time;
		[FieldOffset(4)]
		public float TransitionTime;
		[FieldOffset(8)]
		public FName TargetCamGroup;
		[FieldOffset(16)]
		public int ShotNumber;
		
	}
	
}
#endif
#endif
