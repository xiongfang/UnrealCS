using System;
namespace UnrealEngine
{
	public partial class UWrapBox:UPanelWidget
	{
		public extern UWrapBoxSlot AddChildWrapBox(UWidget Content);
		/// <summary>Sets the inner slot padding goes between slots sharing borders</summary>
		public extern void SetInnerSlotPadding(FVector2D InPadding);
		/// <summary>The inner slot padding goes between slots sharing borders</summary>
		public FVector2D InnerSlotPadding;
		
		/// <summary>When this width is exceeded, elements will start appearing on the next line.</summary>
		public float WrapWidth;
		
		/// <summary>Use explicit wrap width whenever possible. It greatly simplifies layout calculations and reduces likelihood of "wiggling UI"</summary>
		public bool bExplicitWrapWidth;
		
		
	}
	
}
