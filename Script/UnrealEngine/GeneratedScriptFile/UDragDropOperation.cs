using System;
namespace UnrealEngine
{
	public partial class UDragDropOperation:UObject
	{
		/// <summary>A simple string tag you can optionally use to provide extra metadata about the operation.</summary>
		public FString Tag;
		
		/// <summary>
		/// The payload of the drag operation.  This can be any UObject that you want to pass along as dragged data.  If you
		/// were building an inventory screen this would be the UObject representing the item being moved to another slot.
		/// </summary>
		public UObject Payload;
		
		/// <summary>
		/// The Drag Visual is the widget to display when dragging the item.  Normally people create a new widget to represent the
		/// temporary drag.
		/// </summary>
		public UWidget DefaultDragVisual;
		
		/// <summary>A percentage offset (-1..+1) from the Pivot location, the percentage is of the desired size of the dragged visual.</summary>
		public FVector2D Offset;
		
		
	}
	
}
