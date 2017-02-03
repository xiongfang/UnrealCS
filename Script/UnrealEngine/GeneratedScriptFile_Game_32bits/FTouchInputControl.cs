#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=80)]
	public partial struct FTouchInputControl
	{
		[FieldOffset(8)]
		public FVector2D Center;
		[FieldOffset(16)]
		public FVector2D VisualSize;
		[FieldOffset(24)]
		public FVector2D ThumbSize;
		[FieldOffset(32)]
		public FVector2D InteractionSize;
		[FieldOffset(40)]
		public FVector2D InputScale;
		[FieldOffset(48)]
		public FKey MainInputKey;
		[FieldOffset(64)]
		public FKey AltInputKey;
		
	}
	
}
#endif
#endif
