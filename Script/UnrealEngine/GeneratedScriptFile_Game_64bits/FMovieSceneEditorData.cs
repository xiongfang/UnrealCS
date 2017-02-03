#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=112)]
	public partial struct FMovieSceneEditorData
	{
		[FieldOffset(80)]
		public FFloatRange WorkingRange;
		[FieldOffset(96)]
		public FFloatRange ViewRange;
		
	}
	
}
#endif
#endif
