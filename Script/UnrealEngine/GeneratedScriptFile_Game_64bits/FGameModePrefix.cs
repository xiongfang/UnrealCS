#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FGameModePrefix
	{
		[FieldOffset(0)]
		public FString Prefix;
		[FieldOffset(16)]
		public FString GameMode;
		
	}
	
}
#endif
#endif
