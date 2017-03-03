using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UMovieSceneSequencePlayer:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetPlaybackEnd(IntPtr _this);
/// <summary>Get the offset within the level sequence to finish playing</summary>
public  float GetPlaybackEnd()
{
	CheckIsValid();
	float ___ret = GetPlaybackEnd(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetPlaybackStart(IntPtr _this);
/// <summary>Get the offset within the level sequence to start playing</summary>
public  float GetPlaybackStart()
{
	CheckIsValid();
	float ___ret = GetPlaybackStart(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPlaybackRange(IntPtr _this,float NewStartTime,float NewEndTime);
/// <summary>
/// Sets the range in time to be played back by this player, overriding the default range stored in the asset
/// @param       NewStartTime    The new starting time for playback
/// @param       NewEndTime              The new ending time for playback.  Must be larger than the start time.
/// </summary>
public  void SetPlaybackRange(float NewStartTime,float NewEndTime)
{
	CheckIsValid();
	SetPlaybackRange(_this.Get(),NewStartTime,NewEndTime);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPlayRate(IntPtr _this,float PlayRate);
/// <summary>
/// Set the playback rate of this player. Negative values will play the animation in reverse.
/// @param PlayRate - The new rate of playback for the animation.
/// </summary>
public  void SetPlayRate(float PlayRate)
{
	CheckIsValid();
	SetPlayRate(_this.Get(),PlayRate);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetPlayRate(IntPtr _this);
/// <summary>Get the playback rate of this player.</summary>
public  float GetPlayRate()
{
	CheckIsValid();
	float ___ret = GetPlayRate(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetLength(IntPtr _this);
/// <summary>Get the playback length of the sequence</summary>
public  float GetLength()
{
	CheckIsValid();
	float ___ret = GetLength(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsPlaying(IntPtr _this);
/// <summary>Check whether the sequence is actively playing.</summary>
public  bool IsPlaying()
{
	CheckIsValid();
	int ___ret = IsPlaying(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPlaybackPosition(IntPtr _this,float NewPlaybackPosition);
/// <summary>
/// Set the current playback position
/// @param NewPlaybackPosition - The new playback position to set.
/// If the animation is currently playing, it will continue to do so from the new position
/// </summary>
public  void SetPlaybackPosition(float NewPlaybackPosition)
{
	CheckIsValid();
	SetPlaybackPosition(_this.Get(),NewPlaybackPosition);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetPlaybackPosition(IntPtr _this);
/// <summary>Get the current playback position</summary>
public  float GetPlaybackPosition()
{
	CheckIsValid();
	float ___ret = GetPlaybackPosition(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Stop(IntPtr _this);
/// <summary>Stop playback.</summary>
public  void Stop()
{
	CheckIsValid();
	Stop(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Pause(IntPtr _this);
/// <summary>Pause playback.</summary>
public  void Pause()
{
	CheckIsValid();
	Pause(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StartPlayingNextTick(IntPtr _this);
/// <summary>Start playback from the current time cursor position, using the current play rate. Does not update the animation until next tick.</summary>
public  void StartPlayingNextTick()
{
	CheckIsValid();
	StartPlayingNextTick(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PlayLooping(IntPtr _this,int NumLoops);
/// <summary>
/// Start playback from the current time cursor position, looping the specified number of times.
/// @param NumLoops - The number of loops to play. -1 indicates infinite looping.
/// </summary>
public  void PlayLooping(int NumLoops=-1)
{
	CheckIsValid();
	PlayLooping(_this.Get(),NumLoops);
	
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
extern static void PlayReverse(IntPtr _this);
/// <summary>Reverse playback.</summary>
public  void PlayReverse()
{
	CheckIsValid();
	PlayReverse(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Play(IntPtr _this);
/// <summary>Start playback forwards from the current time cursor position, using the current play rate.</summary>
public  void Play()
{
	CheckIsValid();
	Play(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
