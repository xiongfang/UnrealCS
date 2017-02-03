#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FStaticMaterial
	{
		[FieldOffset(4)]
		public FName MaterialSlotName;
		[FieldOffset(12)]
		public FMeshUVChannelInfo UVChannelData;
		
	}
	
}
#endif
#endif
