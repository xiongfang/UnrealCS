#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FMovieSceneCameraShakeSectionData
	{
		/// <summary>Class of the camera shake to play</summary>
		/// <summary>Scalar that affects shake intensity</summary>
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
