#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FMovieSceneCameraShakeSectionData
	{
		[FieldOffset(4)]
		public float PlayScale;
		[FieldOffset(8)]
		public ECameraAnimPlaySpace PlaySpace;
		[FieldOffset(12)]
		public FRotator UserDefinedPlaySpace;
		
	}
	
}
#endif
#endif
