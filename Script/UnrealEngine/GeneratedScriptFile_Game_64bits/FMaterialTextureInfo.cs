#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FMaterialTextureInfo
	{
		[FieldOffset(0)]
		public float SamplingScale;
		[FieldOffset(4)]
		public int UVChannelIndex;
		[FieldOffset(8)]
		public FName TextureName;
		
	}
	
}
#endif
#endif
