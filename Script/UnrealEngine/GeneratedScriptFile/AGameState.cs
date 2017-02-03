using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AGameState:AInfo 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetServerWorldTimeSeconds(IntPtr _this);
/// <summary>Returns the simulated TimeSeconds on the server</summary>
public  float GetServerWorldTimeSeconds()
{
	CheckIsValid();
	float ___ret = GetServerWorldTimeSeconds(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_ElapsedTime(IntPtr _this);
/// <summary>Gives clients the chance to do something when time gets updates</summary>
public  void OnRep_ElapsedTime()
{
	CheckIsValid();
	OnRep_ElapsedTime(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_MatchState(IntPtr _this);
/// <summary>Match state has changed</summary>
public  void OnRep_MatchState()
{
	CheckIsValid();
	OnRep_MatchState(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_SpectatorClass(IntPtr _this);
/// <summary>Callback when we receive the spectator class</summary>
public  void OnRep_SpectatorClass()
{
	CheckIsValid();
	OnRep_SpectatorClass(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_GameModeClass(IntPtr _this);
/// <summary>GameMode class notification callback.</summary>
public  void OnRep_GameModeClass()
{
	CheckIsValid();
	OnRep_GameModeClass(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
