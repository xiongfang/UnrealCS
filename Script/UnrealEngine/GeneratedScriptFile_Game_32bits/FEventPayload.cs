#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FEventPayload
	{
		[FieldOffset(0)]
		public FName EventName;
		[FieldOffset(8)]
		public FMovieSceneEventParameters Parameters;
		
	}
	
}
#endif
#endif
