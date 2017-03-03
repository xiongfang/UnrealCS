#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=168)]
	public partial struct FMovieSceneGenerationLedger
	{
		[FieldOffset(0)]
		public FMovieSceneTrackIdentifier LastTrackIdentifier;
		
	}
	
}
#endif
#endif
