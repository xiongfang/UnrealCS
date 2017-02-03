#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FGameModePrefix
	{
		[FieldOffset(0)]
		public FString Prefix;
		[FieldOffset(12)]
		public FString GameMode;
		
	}
	
}
#endif
#endif
