#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FSlateChildSize
	{
		[FieldOffset(0)]
		public float Value;
		[FieldOffset(4)]
		public ESlateSizeRule SizeRule;
		
	}
	
}
#endif
#endif
