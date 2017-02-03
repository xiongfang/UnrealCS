using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AGameMode:AInfo 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr K2_FindPlayerStart(IntPtr _this,IntPtr Player);
/// <summary>Calls code to select the best player start for this player to start from.</summary>
public  AActor K2_FindPlayerStart(AController Player)
{
	CheckIsValid();
	IntPtr ___ret = K2_FindPlayerStart(_this.Get(),Player);
	if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ChangeName(IntPtr _this,IntPtr Controller,string NewName,int bNameChange);
/// <summary>
/// Sets the name for a controller
/// @param Controller    The controller of the player to change the name of
/// @param NewName               The name to set the player to
/// @param bNameChange   Whether the name is changing or if this is the first time it has been set
/// </summary>
public  void ChangeName(AController Controller,string NewName,bool bNameChange)
{
	CheckIsValid();
	ChangeName(_this.Get(),Controller,NewName,bNameChange?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetNumPlayers(IntPtr _this);
/// <summary>Total number of players</summary>
public  int GetNumPlayers()
{
	CheckIsValid();
	int ___ret = GetNumPlayers(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetLevel(IntPtr _this);
/// <summary>
/// Overridable function called when resetting level.
/// Default implementation calls Reset() on all actors except GameMode and Controllers
/// </summary>
public  void ResetLevel()
{
	CheckIsValid();
	ResetLevel(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBandwidthLimit(IntPtr _this,float AsyncIOBandwidthLimit);
/// <summary>Alters the synthetic bandwidth limit for a running game.</summary>
public  void SetBandwidthLimit(float AsyncIOBandwidthLimit)
{
	CheckIsValid();
	SetBandwidthLimit(_this.Get(),AsyncIOBandwidthLimit);
	
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
extern static void ReturnToMainMenuHost(IntPtr _this);
/// <summary>Return to main menu, and disconnect any players</summary>
public  void ReturnToMainMenuHost()
{
	CheckIsValid();
	ReturnToMainMenuHost(_this.Get());
	
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
extern static void StartPlay(IntPtr _this);
/// <summary>Transitions to WaitingToStart and calls BeginPlay on actors.</summary>
public  void StartPlay()
{
	CheckIsValid();
	StartPlay(_this.Get());
	
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
extern static int HasMatchStarted(IntPtr _this);
/// <summary>Returns true if the match state is InProgress or later</summary>
public  bool HasMatchStarted()
{
	CheckIsValid();
	int ___ret = HasMatchStarted(_this.Get());
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
