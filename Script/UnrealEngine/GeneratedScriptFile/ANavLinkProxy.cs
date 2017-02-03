using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class ANavLinkProxy:AActor 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasMovingAgents(IntPtr _this);
/// <summary>check if any agent is moving through smart link right now</summary>
public  bool HasMovingAgents()
{
	CheckIsValid();
	int ___ret = HasMovingAgents(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSmartLinkEnabled(IntPtr _this,int bEnabled);
/// <summary>change state of smart link</summary>
public  void SetSmartLinkEnabled(bool bEnabled)
{
	CheckIsValid();
	SetSmartLinkEnabled(_this.Get(),bEnabled?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsSmartLinkEnabled(IntPtr _this);
/// <summary>check if smart link is enabled</summary>
public  bool IsSmartLinkEnabled()
{
	CheckIsValid();
	int ___ret = IsSmartLinkEnabled(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResumePathFollowing(IntPtr _this,IntPtr Agent);
/// <summary>resume normal path following</summary>
public  void ResumePathFollowing(AActor Agent)
{
	CheckIsValid();
	ResumePathFollowing(_this.Get(),Agent);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
