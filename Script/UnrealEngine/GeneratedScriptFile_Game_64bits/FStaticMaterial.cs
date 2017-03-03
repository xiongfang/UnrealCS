#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FStaticMaterial
	{
		[FieldOffset(8)]
		public FName MaterialSlotName;
		[FieldOffset(16)]
		public FMeshUVChannelInfo UVChannelData;
		
	}
	
}
#endif
#endif
