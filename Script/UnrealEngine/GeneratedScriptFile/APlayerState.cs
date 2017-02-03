using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class APlayerState:AInfo 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_UniqueId(IntPtr _this);
public  void OnRep_UniqueId()
{
	CheckIsValid();
	OnRep_UniqueId(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_bIsInactive(IntPtr _this);
public  void OnRep_bIsInactive()
{
	CheckIsValid();
	OnRep_bIsInactive(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_PlayerName(IntPtr _this);
public  void OnRep_PlayerName()
{
	CheckIsValid();
	OnRep_PlayerName(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_Score(IntPtr _this);
/// <summary>Replication Notification Callbacks</summary>
public  void OnRep_Score()
{
	CheckIsValid();
	OnRep_Score(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
