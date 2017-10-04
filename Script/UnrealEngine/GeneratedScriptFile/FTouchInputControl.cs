using System;
namespace UnrealEngine
{
	public partial struct FTouchInputControl
	{
		/// <summary>For sticks, this is the Thumb</summary>
		public UTexture2D Image1;
		/// <summary>For sticks, this is the Background</summary>
		public UTexture2D Image2;
		/// <summary>The center point of the control (if <= 1.0, it's relative to screen, > 1.0 is absolute)</summary>
		public FVector2D Center;
		/// <summary>The size of the control (if <= 1.0, it's relative to screen, > 1.0 is absolute)</summary>
		public FVector2D VisualSize;
		/// <summary>For sticks, the size of the thumb (if <= 1.0, it's relative to screen, > 1.0 is absolute)</summary>
		public FVector2D ThumbSize;
		/// <summary>The interactive size of the control (if <= 1.0, it's relative to screen, > 1.0 is absolute)</summary>
		public FVector2D InteractionSize;
		/// <summary>The scale for control input</summary>
		public FVector2D InputScale;
		/// <summary>The main input to send from this control (for sticks, this is the horizontal axis)</summary>
		public FKey MainInputKey;
		/// <summary>The alternate input to send from this control (for sticks, this is the vertical axis)</summary>
		public FKey AltInputKey;
		
	}
	
}
