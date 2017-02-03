using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AMatineeActor:AActor 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLoopingState(IntPtr _this,int bNewLooping);
/// <summary>Change the looping behaviour of this matinee</summary>
public  void SetLoopingState(bool bNewLooping)
{
	CheckIsValid();
	SetLoopingState(_this.Get(),bNewLooping?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ChangePlaybackDirection(IntPtr _this);
/// <summary>Changes the direction of playback (go in reverse if it was going forward, or vice versa)</summary>
public  void ChangePlaybackDirection()
{
	CheckIsValid();
	ChangePlaybackDirection(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPosition(IntPtr _this,float NewPosition,int bJump);
/// <summary>
/// Set the position of the interpolation.
/// @note if the interpolation is not currently active, this function doesn't send any Kismet events
/// @param NewPosition the new position to set the interpolation to
/// @param bJump if true, teleport to the new position (don't trigger any events between the old and new positions, etc)
/// </summary>
public  void SetPosition(float NewPosition,bool bJump=false)
{
	CheckIsValid();
	SetPosition(_this.Get(),NewPosition,bJump?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Pause(IntPtr _this);
/// <summary>Hold playback at its current position. Calling Pause again will continue playback in its current direction.</summary>
public  void Pause()
{
	CheckIsValid();
	Pause(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Reverse(IntPtr _this);
/// <summary>Similar to play, but the playback will go backwards until the beginning of the sequence is reached.</summary>
public  void Reverse()
{
	CheckIsValid();
	Reverse(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Stop(IntPtr _this);
/// <summary>Stops playback at the current position</summary>
public  void Stop()
{
	CheckIsValid();
	Stop(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Play(IntPtr _this);
/// <summary>
/// Begin playback of the matinee. Only called in game.
/// Will then advance Position by (PlayRate * Deltatime) each time the matinee is ticked.
/// </summary>
public  void Play()
{
	CheckIsValid();
	Play(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
