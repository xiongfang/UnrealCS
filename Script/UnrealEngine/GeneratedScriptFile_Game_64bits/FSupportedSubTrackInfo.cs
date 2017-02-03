#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FSupportedSubTrackInfo
	{
		[FieldOffset(8)]
		public FString SubTrackName;
		[FieldOffset(24)]
		public int GroupIndex;
		
	}
	
}
#endif
#endif
