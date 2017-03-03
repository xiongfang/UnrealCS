#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FMovieSceneSectionParameters
	{
		[FieldOffset(0)]
		public float StartOffset;
		[FieldOffset(4)]
		public float TimeScale;
		[FieldOffset(8)]
		public float PrerollTime;
		[FieldOffset(12)]
		public float PostrollTime;
		
	}
	
}
#endif
#endif
