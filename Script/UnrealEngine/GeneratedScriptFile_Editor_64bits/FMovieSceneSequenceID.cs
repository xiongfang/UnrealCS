#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=4)]
	public partial struct FMovieSceneSequenceID
	{
		[FieldOffset(0)]
		public uint Value;
		
	}
	
}
#endif
#endif
