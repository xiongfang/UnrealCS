using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UUserWidget:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsPlayingAnimation(IntPtr _this);
/// <summary>Are we currently playing any animations?</summary>
public  bool IsPlayingAnimation()
{
	CheckIsValid();
	int ___ret = IsPlayingAnimation(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ReverseAnimation(IntPtr _this,IntPtr InAnimation);
/// <summary>
/// If an animation is playing, this function will reverse the playback.
/// @param InAnimation The playing animation that we want to reverse
/// </summary>
public  void ReverseAnimation(UWidgetAnimation InAnimation)
{
	CheckIsValid();
	ReverseAnimation(_this.Get(),InAnimation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPlaybackSpeed(IntPtr _this,IntPtr InAnimation,float PlaybackSpeed);
/// <summary>
/// Changes the playback rate of a playing animation
/// @param InAnimation The animation that is already playing
/// @param PlaybackRate Playback rate multiplier (1 is default)
/// </summary>
public  void SetPlaybackSpeed(UWidgetAnimation InAnimation,float PlaybackSpeed=1.000000f)
{
	CheckIsValid();
	SetPlaybackSpeed(_this.Get(),InAnimation,PlaybackSpeed);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetNumLoopsToPlay(IntPtr _this,IntPtr InAnimation,int NumLoopsToPlay);
/// <summary>
/// Changes the number of loops to play given a playing animation
/// @param InAnimation The animation that is already playing
/// @param NumLoopsToPlay The number of loops to play. (0 to loop indefinitely)
/// </summary>
public  void SetNumLoopsToPlay(UWidgetAnimation InAnimation,int NumLoopsToPlay)
{
	CheckIsValid();
	SetNumLoopsToPlay(_this.Get(),InAnimation,NumLoopsToPlay);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsAnyAnimationPlaying(IntPtr _this);
/// <summary>@return True if any animation is currently playing</summary>
public  bool IsAnyAnimationPlaying()
{
	CheckIsValid();
	int ___ret = IsAnyAnimationPlaying(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsAnimationPlaying(IntPtr _this,IntPtr InAnimation);
/// <summary>
/// Gets whether an animation is currently playing on this widget.
/// @param InAnimation The animation to check the playback status of
/// @return True if the animation is currently playing
/// </summary>
public  bool IsAnimationPlaying(UWidgetAnimation InAnimation)
{
	CheckIsValid();
	int ___ret = IsAnimationPlaying(_this.Get(),InAnimation);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetAnimationCurrentTime(IntPtr _this,IntPtr InAnimation);
/// <summary>
/// Gets the current time of the animation in this widget
/// @param The name of the animation to get the current time for
/// @return the current time of the animation.
/// </summary>
public  float GetAnimationCurrentTime(UWidgetAnimation InAnimation)
{
	CheckIsValid();
	float ___ret = GetAnimationCurrentTime(_this.Get(),InAnimation);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float PauseAnimation(IntPtr _this,IntPtr InAnimation);
/// <summary>
/// Pauses an already running animation in this widget
/// @param The name of the animation to pause
/// @return the time point the animation was at when it was paused, relative to its start position.  Use this as the StartAtTime when you trigger PlayAnimation.
/// </summary>
public  float PauseAnimation(UWidgetAnimation InAnimation)
{
	CheckIsValid();
	float ___ret = PauseAnimation(_this.Get(),InAnimation);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopAnimation(IntPtr _this,IntPtr InAnimation);
/// <summary>
/// Stops an already running animation in this widget
/// @param The name of the animation to stop
/// </summary>
public  void StopAnimation(UWidgetAnimation InAnimation)
{
	CheckIsValid();
	StopAnimation(_this.Get(),InAnimation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PlayAnimationTo(IntPtr _this,IntPtr InAnimation,float StartAtTime,float EndAtTime,int NumLoopsToPlay,int PlayMode,float PlaybackSpeed);
/// <summary>
/// Plays an animation in this widget a specified number of times stoping at a specified time
/// @param InAnimation The animation to play
/// @param StartAtTime The time in the animation from which to start playing, relative to the start position. For looped animations, this will only affect the first playback of the animation.
/// @param EndAtTime The absolute time in the animation where to stop, this is only considered in the last loop.
/// @param NumLoopsToPlay The number of times to loop this animation (0 to loop indefinitely)
/// @param PlaybackSpeed The speed at which the animation should play
/// @param PlayMode Specifies the playback mode
/// </summary>
public  void PlayAnimationTo(UWidgetAnimation InAnimation,float StartAtTime=0.000000f,float EndAtTime=0.000000f,int NumLoopsToPlay=1,EUMGSequencePlayMode PlayMode=EUMGSequencePlayMode.Forward,float PlaybackSpeed=1.000000f)
{
	CheckIsValid();
	PlayAnimationTo(_this.Get(),InAnimation,StartAtTime,EndAtTime,NumLoopsToPlay,(int)PlayMode,PlaybackSpeed);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PlayAnimation(IntPtr _this,IntPtr InAnimation,float StartAtTime,int NumLoopsToPlay,int PlayMode,float PlaybackSpeed);
/// <summary>
/// Plays an animation in this widget a specified number of times
/// @param InAnimation The animation to play
/// @param StartAtTime The time in the animation from which to start playing, relative to the start position. For looped animations, this will only affect the first playback of the animation.
/// @param NumLoopsToPlay The number of times to loop this animation (0 to loop indefinitely)
/// @param PlaybackSpeed The speed at which the animation should play
/// @param PlayMode Specifies the playback mode
/// </summary>
public  void PlayAnimation(UWidgetAnimation InAnimation,float StartAtTime=0.000000f,int NumLoopsToPlay=1,EUMGSequencePlayMode PlayMode=EUMGSequencePlayMode.Forward,float PlaybackSpeed=1.000000f)
{
	CheckIsValid();
	PlayAnimation(_this.Get(),InAnimation,StartAtTime,NumLoopsToPlay,(int)PlayMode,PlaybackSpeed);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPadding(IntPtr _this,ref FMargin InPadding);
public  void SetPadding(FMargin InPadding)
{
	CheckIsValid();
	SetPadding(_this.Get(),ref InPadding);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetForegroundColor(IntPtr _this,ref FSlateColor InForegroundColor);
/// <summary>
/// Sets the foreground color of the widget, this is inherited by sub widgets.  Any color property
/// that is marked as inherit will use this color.
/// @param InForegroundColor     The foreground color.
/// </summary>
public  void SetForegroundColor(FSlateColor InForegroundColor)
{
	CheckIsValid();
	SetForegroundColor(_this.Get(),ref InForegroundColor);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetColorAndOpacity(IntPtr _this,ref FLinearColor InColorAndOpacity);
/// <summary>
/// Sets the tint of the widget, this affects all child widgets.
/// @param InColorAndOpacity     The tint to apply to all child widgets.
/// </summary>
public  void SetColorAndOpacity(FLinearColor InColorAndOpacity)
{
	CheckIsValid();
	SetColorAndOpacity(_this.Get(),ref InColorAndOpacity);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetOwningPlayerPawn(IntPtr _this);
/// <summary>
/// Gets the player pawn associated with this UI.
/// @return Gets the owning player pawn that's owned by the player controller assigned to this widget.
/// </summary>
public  APawn GetOwningPlayerPawn()
{
	CheckIsValid();
	IntPtr ___ret = GetOwningPlayerPawn(_this.Get());
	if(___ret==IntPtr.Zero) return null; APawn ___ret2= new APawn(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetOwningPlayer(IntPtr _this);
/// <summary>
/// Gets the player controller associated with this UI.
/// @return The player controller that owns the UI.
/// </summary>
public  APlayerController GetOwningPlayer()
{
	CheckIsValid();
	IntPtr ___ret = GetOwningPlayer(_this.Get());
	if(___ret==IntPtr.Zero) return null; APlayerController ___ret2= new APlayerController(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOwningLocalPlayer(IntPtr _this,IntPtr LocalPlayer);
/// <summary>
/// Sets the local player associated with this UI.
/// @param LocalPlayer The local player you want to be the conceptual owner of this UI.
/// </summary>
public  void SetOwningLocalPlayer(ULocalPlayer LocalPlayer)
{
	CheckIsValid();
	SetOwningLocalPlayer(_this.Get(),LocalPlayer);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetOwningLocalPlayer(IntPtr _this);
/// <summary>
/// Gets the local player associated with this UI.
/// @return The owning local player.
/// </summary>
public  ULocalPlayer GetOwningLocalPlayer()
{
	CheckIsValid();
	IntPtr ___ret = GetOwningLocalPlayer(_this.Get());
	if(___ret==IntPtr.Zero) return null; ULocalPlayer ___ret2= new ULocalPlayer(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsInViewport(IntPtr _this);
/// <summary>@return true if the widget was added to the viewport using AddToViewport.</summary>
public  bool IsInViewport()
{
	CheckIsValid();
	int ___ret = IsInViewport(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAlignmentInViewport(IntPtr _this,ref FVector2D Alignment);
public  void SetAlignmentInViewport(FVector2D Alignment)
{
	CheckIsValid();
	SetAlignmentInViewport(_this.Get(),ref Alignment);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAnchorsInViewport(IntPtr _this,ref FAnchors Anchors);
public  void SetAnchorsInViewport(FAnchors Anchors)
{
	CheckIsValid();
	SetAnchorsInViewport(_this.Get(),ref Anchors);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDesiredSizeInViewport(IntPtr _this,ref FVector2D Size);
public  void SetDesiredSizeInViewport(FVector2D Size)
{
	CheckIsValid();
	SetDesiredSizeInViewport(_this.Get(),ref Size);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPositionInViewport(IntPtr _this,ref FVector2D Position,int bRemoveDPIScale);
/// <summary>
/// Sets the widgets position in the viewport.
/// @param Position The 2D position to set the widget to in the viewport.
/// @param bRemoveDPIScale If you've already calculated inverse DPI, set this to false.
/// Otherwise inverse DPI is applied to the position so that when the location is scaled
/// by DPI, it ends up in the expected position.
/// </summary>
public  void SetPositionInViewport(FVector2D Position,bool bRemoveDPIScale=true)
{
	CheckIsValid();
	SetPositionInViewport(_this.Get(),ref Position,bRemoveDPIScale?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int AddToPlayerScreen(IntPtr _this,int ZOrder);
/// <summary>
/// Adds the widget to the game's viewport in a section dedicated to the player.  This is valuable in a split screen
/// game where you need to only show a widget over a player's portion of the viewport.
/// @param ZOrder The higher the number, the more on top this widget will be.
/// </summary>
public  bool AddToPlayerScreen(int ZOrder=0)
{
	CheckIsValid();
	int ___ret = AddToPlayerScreen(_this.Get(),ZOrder);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddToViewport(IntPtr _this,int ZOrder);
/// <summary>
/// Adds it to the game's viewport and fills the entire screen, unless SetDesiredSizeInViewport is called
/// to explicitly set the size.
/// @param ZOrder The higher the number, the more on top this widget will be.
/// </summary>
public  void AddToViewport(int ZOrder=0)
{
	CheckIsValid();
	AddToViewport(_this.Get(),ZOrder);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
