using System;
namespace UnrealEngine
{
	public partial class UExpandableArea:UWidget
	{
		public extern void SetIsExpanded_Animated(bool IsExpanded);
		public extern void SetIsExpanded(bool IsExpanded);
		public extern bool GetIsExpanded();
		public FExpandableAreaStyle Style;
		
		public FSlateBrush BorderBrush;
		
		public FSlateColor BorderColor;
		
		public bool bIsExpanded;
		
		/// <summary>The maximum height of the area</summary>
		public float MaxHeight;
		
		public FMargin HeaderPadding;
		
		public FMargin AreaPadding;
		
		public UWidget HeaderContent;
		
		public UWidget BodyContent;
		
		
	}
	
}
