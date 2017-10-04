using System;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SExpandableArea</summary>
	public partial struct FExpandableAreaStyle
	{
		/// <summary>Image to use when the area is collapsed</summary>
		public FSlateBrush CollapsedImage;
		/// <summary>Image to use when the area is expanded</summary>
		public FSlateBrush ExpandedImage;
		/// <summary>How long the rollout animation lasts</summary>
		public float RolloutAnimationSeconds;
		
	}
	
}
