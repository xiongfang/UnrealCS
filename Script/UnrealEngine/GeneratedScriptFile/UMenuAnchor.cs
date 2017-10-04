using System;
namespace UnrealEngine
{
	public partial class UMenuAnchor:UContentWidget
	{
		/// <summary>@return Whether this menu has open submenus</summary>
		public extern bool HasOpenSubMenus();
		/// <summary>@return The current menu position</summary>
		public extern FVector2D GetMenuPosition();
		/// <summary>
		/// @return true if we should open the menu due to a click. Sometimes we should not, if
		/// the same MouseDownEvent that just closed the menu is about to re-open it because it
		/// happens to land on the button.
		/// </summary>
		public extern bool ShouldOpenDueToClick();
		/// <summary>@return true if the popup is open; false otherwise.</summary>
		public extern bool IsOpen();
		/// <summary>Closes the menu if it is currently open.</summary>
		public extern void Close();
		/// <summary>Opens the menu if it is not already open</summary>
		public extern void Open(bool bFocusMenu);
		/// <summary>
		/// Toggles the menus open state.
		/// @param bFocusOnOpen  Should we focus the popup as soon as it opens?
		/// </summary>
		public extern void ToggleOpen(bool bFocusOnOpen);
		/// <summary>
		/// The widget class to spawn when the menu is required.  Creates the widget freshly each time.
		/// If you want to customize the creation of the popup, you should bind a function to OnGetMenuContentEvent
		/// instead.
		/// </summary>
		public TSubclassOf<UUserWidget>  MenuClass;
		
		/// <summary>The placement location of the summoned widget.</summary>
		public EMenuPlacement Placement;
		
		public bool ShouldDeferPaintingAfterWindowContent;
		
		/// <summary>Does this menu behave like a normal stacked menu? Set it to false to control the menu's lifetime yourself.</summary>
		public bool UseApplicationMenuStack;
		
		
	}
	
}
