#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=80)]
	public partial struct FInstancedStaticMeshInstanceData
	{
		[FieldOffset(0)]
		public FMatrix Transform;
		[FieldOffset(64)]
		public FVector2D LightmapUVBias;
		[FieldOffset(72)]
		public FVector2D ShadowmapUVBias;
		
	}
	
}
#endif
#endif
