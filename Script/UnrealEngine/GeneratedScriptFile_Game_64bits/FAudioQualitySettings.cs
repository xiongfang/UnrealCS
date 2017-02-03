#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FAudioQualitySettings
	{
		[FieldOffset(0)]
		public FText DisplayName;
		[FieldOffset(24)]
		public int MaxChannels;
		
	}
	
}
#endif
#endif
