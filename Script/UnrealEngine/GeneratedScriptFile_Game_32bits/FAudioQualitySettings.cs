#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FAudioQualitySettings
	{
		[FieldOffset(0)]
		public FText DisplayName;
		[FieldOffset(12)]
		public int MaxChannels;
		
	}
	
}
#endif
#endif
