#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SButton</summary>
	[StructLayout(LayoutKind.Explicit,Size=736)]
	public partial struct FButtonStyle
	{
		/// <summary>Button appearance when the button is not hovered or pressed</summary>
		[FieldOffset(8)]
		public FSlateBrush Normal;
		/// <summary>Button appearance when hovered</summary>
		[FieldOffset(160)]
		public FSlateBrush Hovered;
		/// <summary>Button appearance when pressed</summary>
		[FieldOffset(312)]
		public FSlateBrush Pressed;
		/// <summary>Button appearance when disabled, by default this is set to an invalid resource when that is the case default disabled drawing is used.</summary>
		[FieldOffset(464)]
		public FSlateBrush Disabled;
		/// <summary>
		/// Padding that accounts for the border in the button's background image.
		/// When this is applied, the content of the button should appear flush
		/// with the button's border. Use this padding when the button is not pressed.
		/// </summary>
		[FieldOffset(616)]
		public FMargin NormalPadding;
		/// <summary>
		/// Same as NormalPadding but used when the button is pressed. Allows for moving the content to match
		/// any "movement" in the button's border image.
		/// </summary>
		[FieldOffset(632)]
		public FMargin PressedPadding;
		/// <summary>The sound the button should play when pressed</summary>
		[FieldOffset(648)]
		public FSlateSound PressedSlateSound;
		/// <summary>The sound the button should play when initially hovered over</summary>
		[FieldOffset(680)]
		public FSlateSound HoveredSlateSound;
		[FieldOffset(712)]
		public FName PressedSound;
		[FieldOffset(724)]
		public FName HoveredSound;
		
	}
	
}
#endif
#endif
