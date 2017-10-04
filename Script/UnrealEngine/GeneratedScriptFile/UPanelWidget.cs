using System;
namespace UnrealEngine
{
	public partial class UPanelWidget:UWidget
	{
		/// <summary>Remove all child widgets from the panel widget.</summary>
		public extern void ClearChildren();
		/// <summary>@return true if there are any child widgets in the panel</summary>
		public extern bool HasAnyChildren();
		/// <summary>
		/// Removes a specific widget from the container.
		/// @return true if the widget was found and removed.
		/// </summary>
		public extern bool RemoveChild(UWidget Content);
		/// <summary>
		/// Adds a new child widget to the container.  Returns the base slot type,
		/// requires casting to turn it into the type specific to the container.
		/// </summary>
		public extern UPanelSlot AddChild(UWidget Content);
		/// <summary>Removes a child by it's index.</summary>
		public extern bool RemoveChildAt(int Index);
		/// <summary>@return true if panel contains this widget</summary>
		public extern bool HasChild(UWidget Content);
		/// <summary>Gets the index of a specific child widget</summary>
		public extern int GetChildIndex(UWidget Content);
		/// <summary>
		/// Gets the widget at an index.
		/// @param Index The index of the widget.
		/// @return The widget at the given index, or nothing if there is no widget there.
		/// </summary>
		public extern UWidget GetChildAt(int Index);
		/// <summary>Gets number of child widgets in the container.</summary>
		public extern int GetChildrenCount();
		
	}
	
}
