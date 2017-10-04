using System;
namespace UnrealEngine
{
	public partial struct FAnchorData
	{
		/// <summary>Offset.</summary>
		public FMargin Offsets;
		/// <summary>Anchors.</summary>
		public FAnchors Anchors;
		/// <summary>
		/// Alignment is the pivot point of the widget.  Starting in the upper left at (0,0),
		/// ending in the lower right at (1,1).  Moving the alignment point allows you to move
		/// the origin of the widget.
		/// </summary>
		public FVector2D Alignment;
		
	}
	
}
