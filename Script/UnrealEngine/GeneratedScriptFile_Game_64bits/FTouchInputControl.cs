#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=104)]
	public partial struct FTouchInputControl
	{
		[FieldOffset(16)]
		public FVector2D Center;
		[FieldOffset(24)]
		public FVector2D VisualSize;
		[FieldOffset(32)]
		public FVector2D ThumbSize;
		[FieldOffset(40)]
		public FVector2D InteractionSize;
		[FieldOffset(48)]
		public FVector2D InputScale;
		[FieldOffset(56)]
		public FKey MainInputKey;
		[FieldOffset(80)]
		public FKey AltInputKey;
		
	}
	
}
#endif
#endif
