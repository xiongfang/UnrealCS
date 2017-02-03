#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Data for a single key in this track</summary>
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FParticleReplayTrackKey
	{
		/// <summary>Position along timeline</summary>
		[FieldOffset(0)]
		public float Time;
		/// <summary>Time length this clip should be captured/played for</summary>
		[FieldOffset(4)]
		public float Duration;
		/// <summary>Replay clip ID number that identifies the clip we should capture to or playback from</summary>
		[FieldOffset(8)]
		public int ClipIDNumber;
		
	}
	
}
#endif
#endif
