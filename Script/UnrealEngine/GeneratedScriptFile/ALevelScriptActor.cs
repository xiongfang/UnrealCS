using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class ALevelScriptActor:AActor 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCinematicMode(IntPtr _this,int bCinematicMode,int bHidePlayer,int bAffectsHUD,int bAffectsMovement,int bAffectsTurning);
/// <summary>
/// Sets the cinematic mode on all PlayerControllers
/// @param       bInCinematicMode        specify true if the player is entering cinematic mode; false if the player is leaving cinematic mode.
/// @param       bHidePlayer                     specify true to hide the player's pawn (only relevant if bInCinematicMode is true)
/// @param       bAffectsHUD                     specify true if we should show/hide the HUD to match the value of bCinematicMode
/// @param       bAffectsMovement        specify true to disable movement in cinematic mode, enable it when leaving
/// @param       bAffectsTurning         specify true to disable turning in cinematic mode or enable it when leaving
/// </summary>
public  void SetCinematicMode(bool bCinematicMode,bool bHidePlayer=true,bool bAffectsHUD=true,bool bAffectsMovement=false,bool bAffectsTurning=false)
{
	CheckIsValid();
	SetCinematicMode(_this.Get(),bCinematicMode?1:0,bHidePlayer?1:0,bAffectsHUD?1:0,bAffectsMovement?1:0,bAffectsTurning?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int RemoteEvent(IntPtr _this,string EventName);
/// <summary>Tries to find an event named "EventName" on all other levels, and calls it</summary>
public  bool RemoteEvent(string EventName)
{
	CheckIsValid();
	int ___ret = RemoteEvent(_this.Get(),EventName);
	return ___ret!=0;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
