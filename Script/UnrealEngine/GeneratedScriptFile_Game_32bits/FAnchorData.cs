#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FAnchorData
	{
		[FieldOffset(0)]
		public FMargin Offsets;
		[FieldOffset(16)]
		public FAnchors Anchors;
		[FieldOffset(32)]
		public FVector2D Alignment;
		
	}
	
}
#endif
#endif
