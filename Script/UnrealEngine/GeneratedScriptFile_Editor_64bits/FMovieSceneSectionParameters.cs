#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FMovieSceneSectionParameters
	{
		/// <summary>Number of seconds to skip at the beginning of the sub-sequence.</summary>
		[FieldOffset(0)]
		public float StartOffset;
		/// <summary>Playback time scaling factor.</summary>
		[FieldOffset(4)]
		public float TimeScale;
		/// <summary>Amount of time to evaluate the section before its actual physical start time.</summary>
		[FieldOffset(8)]
		public float PrerollTime;
		/// <summary>Amount of time to evaluate the section after its actual physical end time.</summary>
		[FieldOffset(12)]
		public float PostrollTime;
		
	}
	
}
#endif
#endif
