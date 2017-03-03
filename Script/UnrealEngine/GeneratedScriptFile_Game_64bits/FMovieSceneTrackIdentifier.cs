#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=4)]
	public partial struct FMovieSceneTrackIdentifier
	{
		[FieldOffset(0)]
		public uint Value;
		
	}
	
}
#endif
#endif
