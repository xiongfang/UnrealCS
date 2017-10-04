using System;
namespace UnrealEngine
{
	public partial class UScrollBar:UWidget
	{
		/// <summary>
		/// Set the offset and size of the track's thumb.
		/// Note that the maximum offset is 1.0-ThumbSizeFraction.
		/// If the user can view 1/3 of the items in a single page, the maximum offset will be ~0.667f
		/// @param InOffsetFraction     Offset of the thumbnail from the top as a fraction of the total available scroll space.
		/// @param InThumbSizeFraction  Size of thumbnail as a fraction of the total available scroll space.
		/// </summary>
		public extern void SetState(float InOffsetFraction,float InThumbSizeFraction);
		/// <summary>Style of the scrollbar</summary>
		public FScrollBarStyle WidgetStyle;
		
		public USlateWidgetStyleAsset Style;
		
		public bool bAlwaysShowScrollbar;
		
		public EOrientation Orientation;
		
		/// <summary>The thickness of the scrollbar thumb</summary>
		public FVector2D Thickness;
		
		
	}
	
}
