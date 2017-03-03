#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FFontData
	{
		[FieldOffset(0)]
		public FString FontFilename;
		
	}
	
}
#endif
#endif
