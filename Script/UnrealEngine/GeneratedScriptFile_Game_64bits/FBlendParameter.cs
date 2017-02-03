#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FBlendParameter
	{
		[FieldOffset(0)]
		public FString DisplayName;
		[FieldOffset(16)]
		public float Min;
		[FieldOffset(20)]
		public float Max;
		[FieldOffset(24)]
		public int GridNum;
		
	}
	
}
#endif
#endif
