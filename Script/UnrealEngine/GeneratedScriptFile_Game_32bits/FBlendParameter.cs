#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FBlendParameter
	{
		[FieldOffset(0)]
		public FString DisplayName;
		[FieldOffset(12)]
		public float Min;
		[FieldOffset(16)]
		public float Max;
		[FieldOffset(20)]
		public int GridNum;
		
	}
	
}
#endif
#endif
