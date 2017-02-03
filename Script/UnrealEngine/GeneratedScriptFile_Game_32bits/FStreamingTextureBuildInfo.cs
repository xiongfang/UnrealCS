#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FStreamingTextureBuildInfo
	{
		[FieldOffset(0)]
		public uint PackedRelativeBox;
		[FieldOffset(4)]
		public int TextureLevelIndex;
		[FieldOffset(8)]
		public float TexelFactor;
		
	}
	
}
#endif
#endif
