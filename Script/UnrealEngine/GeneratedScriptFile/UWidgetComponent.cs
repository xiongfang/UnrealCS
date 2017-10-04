using System;
namespace UnrealEngine
{
	public partial class UWidgetComponent:UMeshComponent
	{
		/// <summary>Sets the background color and opacityscale for this widget</summary>
		public extern void SetBackgroundColor(FLinearColor NewBackgroundColor);
		/// <summary>Requests that the widget be redrawn.</summary>
		public extern virtual void RequestRedraw();
		/// <summary>Sets the draw size of the quad in the world</summary>
		public extern void SetDrawSize(FVector2D Size);
		/// <summary>@return The draw size of the quad in the world</summary>
		public extern FVector2D GetDrawSize();
		/// <summary>Gets the local player that owns this widget component.</summary>
		public extern ULocalPlayer GetOwnerPlayer();
		/// <summary>
		/// Sets the local player that owns this widget component.  Setting the owning player controls
		/// which player's viewport the widget appears on in a split screen scenario.  Additionally it
		/// forwards the owning player to the actual UserWidget that is spawned.
		/// </summary>
		public extern void SetOwnerPlayer(ULocalPlayer LocalPlayer);
		/// <summary>
		/// Sets the widget to use directly. This function will keep track of the widget till the next time it's called
		///     with either a newer widget or a nullptr
		/// </summary>
		public extern virtual void SetWidget(UUserWidget Widget);
		/// <summary>@return The dynamic material instance used to render the user widget</summary>
		public extern UMaterialInstanceDynamic GetMaterialInstance();
		/// <summary>@return The render target to which the user widget is rendered</summary>
		public extern UTextureRenderTarget2D GetRenderTarget();
		/// <summary>@return The user widget object displayed by this component</summary>
		public extern UUserWidget GetUserWidgetObject();
		/// <summary>The class of User Widget to create and display an instance of</summary>
		public TSubclassOf<UUserWidget>  WidgetClass;
		
		/// <summary>The size of the displayed quad.</summary>
		public FIntPoint DrawSize;
		
		/// <summary>Should we wait to be told to redraw to actually draw?</summary>
		public bool bManuallyRedraw;
		
		/// <summary>Has anyone requested we redraw?</summary>
		public bool bRedrawRequested;
		
		/// <summary>
		/// The time in between draws, if 0 - we would redraw every frame.  If 1, we would redraw every second.
		/// This will work with bManuallyRedraw as well.  So you can say, manually redraw, but only redraw at this
		/// maximum rate.
		/// </summary>
		public float RedrawTime;
		
		/// <summary>
		/// The actual draw size, this changes based on DrawSize - or the desired size of the widget if
		/// bDrawAtDesiredSize is true.
		/// </summary>
		public FIntPoint CurrentDrawSize;
		
		/// <summary>
		/// Causes the render target to automatically match the desired size.
		/// WARNING: If you change this every frame, it will be very expensive.  If you need
		///    that effect, you should keep the outer widget's sized locked and dynamically
		///    scale or resize some inner widget.
		/// </summary>
		public bool bDrawAtDesiredSize;
		
		/// <summary>The Alignment/Pivot point that the widget is placed at relative to the position.</summary>
		public FVector2D Pivot;
		
		/// <summary>
		/// Register with the viewport for hardware input from the true mouse and keyboard.  These widgets
		/// will more or less react like regular 2D widgets in the viewport, e.g. they can and will steal focus
		/// from the viewport.
		/// WARNING: If you are making a VR game, definitely do not change this to true.  This option should ONLY be used
		/// if you're making what would otherwise be a normal menu for a game, just in 3D.  If you also need the game to
		/// remain responsive and for the player to be able to interact with UI and move around the world (such as a keypad on a door),
		/// use the WidgetInteractionComponent instead.
		/// </summary>
		public bool bReceiveHardwareInput;
		
		/// <summary>Is the virtual window created to host the widget focusable?</summary>
		public bool bWindowFocusable;
		
		/// <summary>
		/// The owner player for a widget component, if this widget is drawn on the screen, this controls
		/// what player's screen it appears on for split screen, if not set, users player 0.
		/// </summary>
		public ULocalPlayer OwnerPlayer;
		
		/// <summary>The background color of the component</summary>
		public FLinearColor BackgroundColor;
		
		/// <summary>Tint color and opacity for this component</summary>
		public FLinearColor TintColorAndOpacity;
		
		/// <summary>Sets the amount of opacity from the widget's UI texture to use when rendering the translucent or masked UI to the viewport (0.0-1.0)</summary>
		public float OpacityFromTexture;
		
		/// <summary>Is the component visible from behind?</summary>
		public bool bIsTwoSided;
		
		/// <summary>Should the component tick the widget when it's off screen?</summary>
		public bool TickWhenOffscreen;
		
		/// <summary>The User Widget object displayed and managed by this component</summary>
		public UUserWidget Widget;
		
		/// <summary>The body setup of the displayed quad</summary>
		public UBodySetup BodySetup;
		
		/// <summary>The material instance for translucent widget components</summary>
		public UMaterialInterface TranslucentMaterial;
		
		/// <summary>The material instance for translucent, one-sided widget components</summary>
		public UMaterialInterface TranslucentMaterial_OneSided;
		
		/// <summary>The material instance for opaque widget components</summary>
		public UMaterialInterface OpaqueMaterial;
		
		/// <summary>The material instance for opaque, one-sided widget components</summary>
		public UMaterialInterface OpaqueMaterial_OneSided;
		
		/// <summary>The material instance for masked widget components.</summary>
		public UMaterialInterface MaskedMaterial;
		
		/// <summary>The material instance for masked, one-sided widget components.</summary>
		public UMaterialInterface MaskedMaterial_OneSided;
		
		/// <summary>The target to which the user widget is rendered</summary>
		public UTextureRenderTarget2D RenderTarget;
		
		/// <summary>The dynamic instance of the material that the render target is attached to</summary>
		public UMaterialInstanceDynamic MaterialInstance;
		
		public bool bAddedToScreen;
		
		/// <summary>Allows the widget component to be used at editor time.  For use in the VR-Editor.</summary>
		public bool bEditTimeUsable;
		
		/// <summary>Layer Name the widget will live on</summary>
		public FName SharedLayerName;
		
		/// <summary>ZOrder the layer will be created on, note this only matters on the first time a new layer is created, subsequent additions to the same layer will use the initially defined ZOrder</summary>
		public int LayerZOrder;
		
		/// <summary>Curvature of a cylindrical widget in degrees.</summary>
		public float CylinderArcAngle;
		
		
	}
	
}
