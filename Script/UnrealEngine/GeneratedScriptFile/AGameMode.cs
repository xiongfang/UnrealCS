using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AGameMode:AGameModeBase 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBandwidthLimit(IntPtr _this,float AsyncIOBandwidthLimit);
/// <summary>Alters the synthetic bandwidth limit for a running game.</summary>
public  void SetBandwidthLimit(float AsyncIOBandwidthLimit)
{
	CheckIsValid();
	SetBandwidthLimit(_this.Get(),AsyncIOBandwidthLimit);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Say(IntPtr _this,string Msg);
/// <summary>Exec command to broadcast a string to all players</summary>
public  void Say(string Msg)
{
	CheckIsValid();
	Say(_this.Get(),Msg);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AbortMatch(IntPtr _this);
/// <summary>Report that a match has failed due to unrecoverable error</summary>
public  void AbortMatch()
{
	CheckIsValid();
	AbortMatch(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RestartGame(IntPtr _this);
/// <summary>Restart the game, by default travel to the current map</summary>
public  void RestartGame()
{
	CheckIsValid();
	RestartGame(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void EndMatch(IntPtr _this);
/// <summary>Transition from InProgress to WaitingPostMatch. You can call this manually, will also get called if ReadyToEndMatch returns true</summary>
public  void EndMatch()
{
	CheckIsValid();
	EndMatch(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StartMatch(IntPtr _this);
/// <summary>Transition from WaitingToStart to InProgress. You can call this manually, will also get called if ReadyToStartMatch returns true</summary>
public  void StartMatch()
{
	CheckIsValid();
	StartMatch(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasMatchEnded(IntPtr _this);
/// <summary>Returns true if the match state is WaitingPostMatch or later</summary>
public  bool HasMatchEnded()
{
	CheckIsValid();
	int ___ret = HasMatchEnded(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsMatchInProgress(IntPtr _this);
/// <summary>Returns true if the match state is InProgress or other gameplay state</summary>
public  bool IsMatchInProgress()
{
	CheckIsValid();
	int ___ret = IsMatchInProgress(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetMatchState(IntPtr _this);
/// <summary>Returns the current match state, this is an accessor to protect the state machine flow</summary>
public  string GetMatchState()
{
	CheckIsValid();
	string ___ret = GetMatchState(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
