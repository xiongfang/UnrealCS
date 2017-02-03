#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=92)]
	public partial struct FMovieSceneEditorData
	{
		[FieldOffset(60)]
		public FFloatRange WorkingRange;
		[FieldOffset(76)]
		public FFloatRange ViewRange;
		
	}
	
}
#endif
#endif
