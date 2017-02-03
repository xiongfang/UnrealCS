using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AGameStateBase:AInfo 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetPlayerRespawnDelay(IntPtr _this,IntPtr Controller);
/// <summary>Returns how much time needs to be spent before a player can respawn</summary>
public  float GetPlayerRespawnDelay(AController Controller)
{
	CheckIsValid();
	float ___ret = GetPlayerRespawnDelay(_this.Get(),Controller);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetPlayerStartTime(IntPtr _this,IntPtr Controller);
/// <summary>Returns the time that should be used as when a player started</summary>
public  float GetPlayerStartTime(AController Controller)
{
	CheckIsValid();
	float ___ret = GetPlayerStartTime(_this.Get(),Controller);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasMatchStarted(IntPtr _this);
/// <summary>Returns true if the world has started match (called MatchStarted callbacks)</summary>
public  bool HasMatchStarted()
{
	CheckIsValid();
	int ___ret = HasMatchStarted(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasBegunPlay(IntPtr _this);
/// <summary>Returns true if the world has started play (called BeginPlay on actors)</summary>
public  bool HasBegunPlay()
{
	CheckIsValid();
	int ___ret = HasBegunPlay(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetServerWorldTimeSeconds(IntPtr _this);
/// <summary>Returns the simulated TimeSeconds on the server, will be synchronized on client and server</summary>
public  float GetServerWorldTimeSeconds()
{
	CheckIsValid();
	float ___ret = GetServerWorldTimeSeconds(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
