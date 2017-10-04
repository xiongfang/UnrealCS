using System;
namespace UnrealEngine
{
	public partial class UScrollBox:UPanelWidget
	{
		/// <summary>Scrolls the ScrollBox to the widget during the next layout pass.</summary>
		public extern void ScrollWidgetIntoView(UWidget WidgetToFind,bool AnimateScroll=true);
		/// <summary>Scrolls the ScrollBox to the bottom instantly during the next layout pass.</summary>
		public extern void ScrollToEnd();
		/// <summary>Scrolls the ScrollBox to the top instantly</summary>
		public extern void ScrollToStart();
		/// <summary>Gets the scroll offset of the scrollbox in Slate Units.</summary>
		public extern float GetScrollOffset();
		/// <summary>
		/// Updates the scroll offset of the scrollbox.
		/// @param NewScrollOffset is in Slate Units.
		/// </summary>
		public extern void SetScrollOffset(float NewScrollOffset);
		/// <summary>The style</summary>
		public FScrollBoxStyle WidgetStyle;
		
		/// <summary>The bar style</summary>
		public FScrollBarStyle WidgetBarStyle;
		
		public USlateWidgetStyleAsset Style;
		
		public USlateWidgetStyleAsset BarStyle;
		
		/// <summary>The orientation of the scrolling and stacking in the box.</summary>
		public EOrientation Orientation;
		
		public FVector2D ScrollbarThickness;
		
		public bool AlwaysShowScrollbar;
		
		
	}
	
}
