#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FGameClassShortName
	{
		[FieldOffset(0)]
		public FString ShortName;
		[FieldOffset(16)]
		public FString GameClassName;
		
	}
	
}
#endif
#endif
