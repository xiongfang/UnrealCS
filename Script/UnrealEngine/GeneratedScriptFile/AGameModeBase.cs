using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AGameModeBase:AInfo 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RestartPlayerAtTransform(IntPtr _this,IntPtr NewPlayer,ref FTransform SpawnTransform);
/// <summary>Tries to spawn the player's pawn at a specific location</summary>
public  void RestartPlayerAtTransform(AController NewPlayer,FTransform SpawnTransform)
{
	CheckIsValid();
	RestartPlayerAtTransform(_this.Get(),NewPlayer,ref SpawnTransform);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RestartPlayerAtPlayerStart(IntPtr _this,IntPtr NewPlayer,IntPtr StartSpot);
/// <summary>Tries to spawn the player's pawn at the specified actor's location</summary>
public  void RestartPlayerAtPlayerStart(AController NewPlayer,AActor StartSpot)
{
	CheckIsValid();
	RestartPlayerAtPlayerStart(_this.Get(),NewPlayer,StartSpot);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RestartPlayer(IntPtr _this,IntPtr NewPlayer);
/// <summary>Tries to spawn the player's pawn, at the location returned by FindPlayerStart</summary>
public  void RestartPlayer(AController NewPlayer)
{
	CheckIsValid();
	RestartPlayer(_this.Get(),NewPlayer);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr K2_FindPlayerStart(IntPtr _this,IntPtr Player,string IncomingName);
/// <summary>
/// Return the specific player start actor that should be used for the next spawn
/// This will either use a previously saved startactor, or calls ChoosePlayerStart
/// @param Player The AController for whom we are choosing a Player Start
/// @param IncomingName Specifies the tag of a Player Start to use
/// @returns Actor chosen as player start (usually a PlayerStart)
/// </summary>
public  AActor K2_FindPlayerStart(AController Player,string IncomingName)
{
	CheckIsValid();
	IntPtr ___ret = K2_FindPlayerStart(_this.Get(),Player,IncomingName);
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
extern static void ReturnToMainMenuHost(IntPtr _this);
/// <summary>Return to main menu, and disconnect any players</summary>
public  void ReturnToMainMenuHost()
{
	CheckIsValid();
	ReturnToMainMenuHost(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetLevel(IntPtr _this);
/// <summary>
/// Overridable function called when resetting level. This is used to reset the game state while staying in the same map
/// Default implementation calls Reset() on all actors except GameMode and Controllers
/// </summary>
public  void ResetLevel()
{
	CheckIsValid();
	ResetLevel(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasMatchStarted(IntPtr _this);
/// <summary>Returns true if the match start callbacks have been called</summary>
public  bool HasMatchStarted()
{
	CheckIsValid();
	int ___ret = HasMatchStarted(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StartPlay(IntPtr _this);
/// <summary>Transitions to calls BeginPlay on actors.</summary>
public  void StartPlay()
{
	CheckIsValid();
	StartPlay(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetNumSpectators(IntPtr _this);
/// <summary>Returns number of human players currently spectating</summary>
public  int GetNumSpectators()
{
	CheckIsValid();
	int ___ret = GetNumSpectators(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetNumPlayers(IntPtr _this);
/// <summary>Returns number of active human players, excluding spectators</summary>
public  int GetNumPlayers()
{
	CheckIsValid();
	int ___ret = GetNumPlayers(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
