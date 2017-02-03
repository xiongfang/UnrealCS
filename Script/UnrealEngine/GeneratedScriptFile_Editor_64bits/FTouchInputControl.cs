#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=120)]
	public partial struct FTouchInputControl
	{
		/// <summary>For sticks, this is the Thumb</summary>
		/// <summary>For sticks, this is the Background</summary>
		/// <summary>The center point of the control (if <= 1.0, it's relative to screen, > 1.0 is absolute)</summary>
		[FieldOffset(16)]
		public FVector2D Center;
		/// <summary>The size of the control (if <= 1.0, it's relative to screen, > 1.0 is absolute)</summary>
		[FieldOffset(24)]
		public FVector2D VisualSize;
		/// <summary>For sticks, the size of the thumb (if <= 1.0, it's relative to screen, > 1.0 is absolute)</summary>
		[FieldOffset(32)]
		public FVector2D ThumbSize;
		/// <summary>The interactive size of the control (if <= 1.0, it's relative to screen, > 1.0 is absolute)</summary>
		[FieldOffset(40)]
		public FVector2D InteractionSize;
		/// <summary>The scale for control input</summary>
		[FieldOffset(48)]
		public FVector2D InputScale;
		/// <summary>The main input to send from this control (for sticks, this is the horizontal axis)</summary>
		[FieldOffset(56)]
		public FKey MainInputKey;
		/// <summary>The alternate input to send from this control (for sticks, this is the vertical axis)</summary>
		[FieldOffset(88)]
		public FKey AltInputKey;
		
	}
	
}
#endif
#endif
