using System;
namespace UnrealEngine
{
	public partial class UWidget:UVisual
	{
		/// <summary>
		/// Gets the player controller associated with this UI.
		/// @return The player controller that owns the UI.
		/// </summary>
		public extern virtual APlayerController GetOwningPlayer();
		/// <summary>
		/// Gets the last geometry used to Tick the widget.  This data may not exist yet if this call happens prior to
		/// the widget having been ticked/painted, or it may be out of date, or a frame behind.
		/// We recommend not to use this data unless there's no other way to solve your problem.  Normally in Slate we
		/// try and handle these issues by making a dependent widget part of the hierarchy, as to avoid frame behind
		/// or what are referred to as hysteresis problems, both caused by depending on geometry from the previous frame
		/// being used to advise how to layout a dependent object the current frame.
		/// </summary>
		public extern FGeometry GetCachedGeometry();
		/// <summary>
		/// Removes the widget from its parent widget.  If this widget was added to the player's screen or the viewport
		/// it will also be removed from those containers.
		/// </summary>
		public extern virtual void RemoveFromParent();
		/// <summary>Gets the parent widget</summary>
		public extern UPanelWidget GetParent();
		/// <summary>
		/// Gets the widgets desired size.
		/// NOTE: The underlying Slate widget must exist and be valid, also at least one pre-pass must
		///       have occurred before this value will be of any use.
		/// @return The widget's desired size
		/// </summary>
		public extern FVector2D GetDesiredSize();
		/// <summary>
		/// Invalidates the widget from the view of a layout caching widget that may own this widget.
		/// will force the owning widget to redraw and cache children on the next paint pass.
		/// </summary>
		public extern void InvalidateLayoutAndVolatility();
		/// <summary>
		/// Forces a pre-pass.  A pre-pass caches the desired size of the widget hierarchy owned by this widget.
		/// One pre-pass is already happens for every widget before Tick occurs.  You only need to perform another
		/// pre-pass if you are adding child widgets this frame and want them to immediately be visible this frame.
		/// </summary>
		public extern void ForceLayoutPrepass();
		/// <summary>Sets the focus to this widget for a specific user</summary>
		public extern void SetUserFocus(APlayerController PlayerController);
		/// <summary>@return true if any descendant widget is focused by a specific user.</summary>
		public extern bool HasUserFocusedDescendants(APlayerController PlayerController);
		/// <summary>@return true if any descendant widget is focused by any user.</summary>
		public extern bool HasFocusedDescendants();
		/// <summary>@return true if this widget is focused by any user.</summary>
		public extern bool HasAnyUserFocus();
		/// <summary>@return true if this widget is focused by a specific user.</summary>
		public extern bool HasUserFocus(APlayerController PlayerController);
		/// <summary>Sets the focus to this widget.</summary>
		public extern void SetKeyboardFocus();
		/// <summary>
		/// Checks to see if this widget is the current mouse captor
		/// @return  True if this widget has captured the mouse
		/// </summary>
		public extern bool HasMouseCapture();
		/// <summary>
		/// Checks to see if this widget currently has the keyboard focus
		/// @return  True if this widget has keyboard focus
		/// </summary>
		public extern bool HasKeyboardFocus();
		/// <summary>@return true if the widget is currently being hovered by a pointer device</summary>
		public extern bool IsHovered();
		/// <summary>Sets the forced volatility of the widget.</summary>
		public extern void ForceVolatile(bool bForce);
		/// <summary>@return true if the widget is Visible, HitTestInvisible or SelfHitTestInvisible.</summary>
		public extern bool IsVisible();
		/// <summary>Resets the cursor to use on the widget, removing any customization for it.</summary>
		public extern void ResetCursor();
		/// <summary>Sets the cursor to show over the widget.</summary>
		public extern void SetCursor(EMouseCursor InCursor);
		/// <summary>Sets a custom widget as the tooltip of the widget.</summary>
		public extern void SetToolTip(UWidget Widget);
		/// <summary>Sets the tooltip text for the widget.</summary>
		public extern void SetToolTipText(FText InToolTipText);
		/// <summary>Sets the current enabled status of the widget</summary>
		public extern virtual void SetIsEnabled(bool bInIsEnabled);
		/// <summary>Gets the current enabled status of the widget</summary>
		public extern bool GetIsEnabled();
		public extern void SetRenderTransformPivot(FVector2D Pivot);
		public extern void SetRenderTranslation(FVector2D Translation);
		public extern void SetRenderAngle(float Angle);
		public extern void SetRenderShear(FVector2D Shear);
		public extern void SetRenderScale(FVector2D Scale);
		public extern void SetRenderTransform(FWidgetTransform InTransform);
		/// <summary>
		/// Allows controls to be exposed as variables in a blueprint.  Not all controls need to be exposed
		/// as variables, so this allows only the most useful ones to end up being exposed.
		/// </summary>
		public bool bIsVariable;
		
		/// <summary>Flag if the Widget was created from a blueprint</summary>
		public bool bCreatedByConstructionScript;
		
		/// <summary>The parent slot of the UWidget.  Allows us to easily inline edit the layout controlling this widget.</summary>
		public UPanelSlot Slot;
		
		/// <summary>Sets whether this widget can be modified interactively by the user</summary>
		public bool bIsEnabled;
		
		/// <summary>Tooltip text to show when the user hovers over the widget with the mouse</summary>
		public FText ToolTipText;
		
		/// <summary>Tooltip widget to show when the user hovers over the widget with the mouse</summary>
		public UWidget ToolTipWidget;
		
		public bool bOverride_Cursor;
		
		/// <summary>The cursor to show when the mouse is over the widget</summary>
		public EMouseCursor Cursor;
		
		/// <summary>
		/// If true prevents the widget or its child's geometry or layout information from being cached.  If this widget
		/// changes every frame, but you want it to still be in an invalidation panel you should make it as volatile
		/// instead of invalidating it every frame, which would prevent the invalidation panel from actually
		/// ever caching anything.
		/// </summary>
		public bool bIsVolatile;
		
		/// <summary>The render transform of the widget allows for arbitrary 2D transforms to be applied to the widget.</summary>
		public FWidgetTransform RenderTransform;
		
		/// <summary>
		/// The render transform pivot controls the location about which transforms are applied.
		/// This value is a normalized coordinate about which things like rotations will occur.
		/// </summary>
		public FVector2D RenderTransformPivot;
		
		/// <summary>
		/// The navigation object for this widget is optionally created if the user has configured custom
		/// navigation rules for this widget in the widget designer.  Those rules determine how navigation transitions
		/// can occur between widgets.
		/// </summary>
		public UWidgetNavigation Navigation;
		
		/// <summary>Stores the design time flag setting if the widget is hidden inside the designer</summary>
		public bool bHiddenInDesigner;
		
		/// <summary>Stores the design time flag setting if the widget is expanded inside the designer</summary>
		public bool bExpandedInDesigner;
		
		/// <summary>Any flags used by the designer at edit time.</summary>
		public EWidgetDesignFlags DesignerFlags;
		
		/// <summary>The friendly name for this widget displayed in the designer and BP graph.</summary>
		public FString DisplayLabel;
		
		
	}
	
}
