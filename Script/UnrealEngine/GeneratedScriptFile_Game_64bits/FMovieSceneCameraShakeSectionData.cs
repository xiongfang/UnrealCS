#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FMovieSceneCameraShakeSectionData
	{
		[FieldOffset(8)]
		public float PlayScale;
		[FieldOffset(12)]
		public ECameraAnimPlaySpace PlaySpace;
		[FieldOffset(16)]
		public FRotator UserDefinedPlaySpace;
		
	}
	
}
#endif
#endif
