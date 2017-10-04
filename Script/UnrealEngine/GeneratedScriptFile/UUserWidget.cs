using System;
namespace UnrealEngine
{
	public partial class UUserWidget:UWidget
	{
		/// <summary>Are we currently playing any animations?</summary>
		public extern bool IsPlayingAnimation();
		/// <summary>
		/// If an animation is playing, this function will reverse the playback.
		/// @param InAnimation The playing animation that we want to reverse
		/// </summary>
		public extern void ReverseAnimation(UWidgetAnimation InAnimation);
		/// <summary>
		/// Changes the playback rate of a playing animation
		/// @param InAnimation The animation that is already playing
		/// @param PlaybackRate Playback rate multiplier (1 is default)
		/// </summary>
		public extern void SetPlaybackSpeed(UWidgetAnimation InAnimation,float PlaybackSpeed=1.000000f);
		/// <summary>
		/// Changes the number of loops to play given a playing animation
		/// @param InAnimation The animation that is already playing
		/// @param NumLoopsToPlay The number of loops to play. (0 to loop indefinitely)
		/// </summary>
		public extern void SetNumLoopsToPlay(UWidgetAnimation InAnimation,int NumLoopsToPlay);
		/// <summary>@return True if any animation is currently playing</summary>
		public extern bool IsAnyAnimationPlaying();
		/// <summary>
		/// Gets whether an animation is currently playing on this widget.
		/// @param InAnimation The animation to check the playback status of
		/// @return True if the animation is currently playing
		/// </summary>
		public extern bool IsAnimationPlaying(UWidgetAnimation InAnimation);
		/// <summary>
		/// Gets the current time of the animation in this widget
		/// @param The name of the animation to get the current time for
		/// @return the current time of the animation.
		/// </summary>
		public extern float GetAnimationCurrentTime(UWidgetAnimation InAnimation);
		/// <summary>
		/// Pauses an already running animation in this widget
		/// @param The name of the animation to pause
		/// @return the time point the animation was at when it was paused, relative to its start position.  Use this as the StartAtTime when you trigger PlayAnimation.
		/// </summary>
		public extern float PauseAnimation(UWidgetAnimation InAnimation);
		/// <summary>
		/// Stops an already running animation in this widget
		/// @param The name of the animation to stop
		/// </summary>
		public extern void StopAnimation(UWidgetAnimation InAnimation);
		/// <summary>
		/// Plays an animation in this widget a specified number of times stoping at a specified time
		/// @param InAnimation The animation to play
		/// @param StartAtTime The time in the animation from which to start playing, relative to the start position. For looped animations, this will only affect the first playback of the animation.
		/// @param EndAtTime The absolute time in the animation where to stop, this is only considered in the last loop.
		/// @param NumLoopsToPlay The number of times to loop this animation (0 to loop indefinitely)
		/// @param PlaybackSpeed The speed at which the animation should play
		/// @param PlayMode Specifies the playback mode
		/// </summary>
		public extern void PlayAnimationTo(UWidgetAnimation InAnimation,float StartAtTime=0.000000f,float EndAtTime=0.000000f,int NumLoopsToPlay=1,EUMGSequencePlayMode PlayMode=EUMGSequencePlayMode.Forward,float PlaybackSpeed=1.000000f);
		/// <summary>
		/// Plays an animation in this widget a specified number of times
		/// @param InAnimation The animation to play
		/// @param StartAtTime The time in the animation from which to start playing, relative to the start position. For looped animations, this will only affect the first playback of the animation.
		/// @param NumLoopsToPlay The number of times to loop this animation (0 to loop indefinitely)
		/// @param PlaybackSpeed The speed at which the animation should play
		/// @param PlayMode Specifies the playback mode
		/// </summary>
		public extern void PlayAnimation(UWidgetAnimation InAnimation,float StartAtTime=0.000000f,int NumLoopsToPlay=1,EUMGSequencePlayMode PlayMode=EUMGSequencePlayMode.Forward,float PlaybackSpeed=1.000000f);
		public extern void SetPadding(FMargin InPadding);
		/// <summary>
		/// Sets the foreground color of the widget, this is inherited by sub widgets.  Any color property
		/// that is marked as inherit will use this color.
		/// @param InForegroundColor     The foreground color.
		/// </summary>
		public extern void SetForegroundColor(FSlateColor InForegroundColor);
		/// <summary>
		/// Sets the tint of the widget, this affects all child widgets.
		/// @param InColorAndOpacity     The tint to apply to all child widgets.
		/// </summary>
		public extern void SetColorAndOpacity(FLinearColor InColorAndOpacity);
		/// <summary>
		/// Gets the player pawn associated with this UI.
		/// @return Gets the owning player pawn that's owned by the player controller assigned to this widget.
		/// </summary>
		public extern APawn GetOwningPlayerPawn();
		/// <summary>
		/// Sets the local player associated with this UI via PlayerController reference.
		/// @param LocalPlayerController The PlayerController of the local player you want to be the conceptual owner of this UI.
		/// </summary>
		public extern void SetOwningPlayer(APlayerController LocalPlayerController);
		/// <summary>
		/// Gets the player controller associated with this UI.
		/// @return The player controller that owns the UI.
		/// </summary>
		public extern APlayerController GetOwningPlayer();
		/// <summary>
		/// Sets the player associated with this UI via LocalPlayer reference.
		/// @param LocalPlayer The local player you want to be the conceptual owner of this UI.
		/// </summary>
		public extern void SetOwningLocalPlayer(ULocalPlayer LocalPlayer);
		/// <summary>
		/// Gets the local player associated with this UI.
		/// @return The owning local player.
		/// </summary>
		public extern ULocalPlayer GetOwningLocalPlayer();
		/// <summary>@return true if the widget was added to the viewport using AddToViewport.</summary>
		public extern bool IsInViewport();
		public extern void SetAlignmentInViewport(FVector2D Alignment);
		public extern void SetAnchorsInViewport(FAnchors Anchors);
		public extern void SetDesiredSizeInViewport(FVector2D Size);
		/// <summary>
		/// Sets the widgets position in the viewport.
		/// @param Position The 2D position to set the widget to in the viewport.
		/// @param bRemoveDPIScale If you've already calculated inverse DPI, set this to false.
		/// Otherwise inverse DPI is applied to the position so that when the location is scaled
		/// by DPI, it ends up in the expected position.
		/// </summary>
		public extern void SetPositionInViewport(FVector2D Position,bool bRemoveDPIScale=true);
		/// <summary>
		/// Adds the widget to the game's viewport in a section dedicated to the player.  This is valuable in a split screen
		/// game where you need to only show a widget over a player's portion of the viewport.
		/// @param ZOrder The higher the number, the more on top this widget will be.
		/// </summary>
		public extern bool AddToPlayerScreen(int ZOrder=0);
		/// <summary>
		/// Adds it to the game's viewport and fills the entire screen, unless SetDesiredSizeInViewport is called
		/// to explicitly set the size.
		/// @param ZOrder The higher the number, the more on top this widget will be.
		/// </summary>
		public extern void AddToViewport(int ZOrder=0);
		/// <summary>The color and opacity of this widget.  Tints all child widgets.</summary>
		public FLinearColor ColorAndOpacity;
		
		/// <summary>
		/// The foreground color of the widget, this is inherited by sub widgets.  Any color property
		/// that is marked as inherit will use this color.
		/// </summary>
		public FSlateColor ForegroundColor;
		
		/// <summary>The padding area around the content.</summary>
		public FMargin Padding;
		
		public bool bSupportsKeyboardFocus;
		
		/// <summary>Setting this flag to true, allows this widget to accept focus when clicked, or when navigated to.</summary>
		public bool bIsFocusable;
		
		/// <summary>The widget tree contained inside this user widget initialized by the blueprint</summary>
		public UWidgetTree WidgetTree;
		
		public bool bStopAction;
		
		public int Priority;
		
		/// <summary>Stores the design time desired size of the user widget</summary>
		public FVector2D DesignTimeSize;
		
		/// <summary>A flag that determines if the design time size is used for previewing the widget in the designer.</summary>
		public bool bUseDesignTimeSize;
		
		/// <summary>A flag that determines if the widget's desired size is used for previewing the widget in the designer.</summary>
		public bool bUseDesiredSizeAtDesignTime;
		
		/// <summary>The category this widget appears in the palette.</summary>
		public FText PaletteCategory;
		
		/// <summary>
		/// A preview background that you can use when designing the UI to get a sense of scale on the screen.  Use
		/// a texture with a screenshot of your game in it, for example if you were designing a HUD.
		/// </summary>
		public UTexture2D PreviewBackground;
		
		public UInputComponent InputComponent;
		
		
	}
	
}
