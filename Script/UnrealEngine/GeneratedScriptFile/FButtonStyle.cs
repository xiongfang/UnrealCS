using System;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SButton</summary>
	public partial struct FButtonStyle
	{
		/// <summary>Button appearance when the button is not hovered or pressed</summary>
		public FSlateBrush Normal;
		/// <summary>Button appearance when hovered</summary>
		public FSlateBrush Hovered;
		/// <summary>Button appearance when pressed</summary>
		public FSlateBrush Pressed;
		/// <summary>Button appearance when disabled, by default this is set to an invalid resource when that is the case default disabled drawing is used.</summary>
		public FSlateBrush Disabled;
		/// <summary>
		/// Padding that accounts for the border in the button's background image.
		/// When this is applied, the content of the button should appear flush
		/// with the button's border. Use this padding when the button is not pressed.
		/// </summary>
		public FMargin NormalPadding;
		/// <summary>
		/// Same as NormalPadding but used when the button is pressed. Allows for moving the content to match
		/// any "movement" in the button's border image.
		/// </summary>
		public FMargin PressedPadding;
		/// <summary>The sound the button should play when pressed</summary>
		public FSlateSound PressedSlateSound;
		/// <summary>The sound the button should play when initially hovered over</summary>
		public FSlateSound HoveredSlateSound;
		public FName PressedSound;
		public FName HoveredSound;
		
	}
	
}
