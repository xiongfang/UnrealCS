using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class ULevelStreaming:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetLevelScriptActor(IntPtr _this);
/// <summary>Returns the Level Script Actor of the level if the level is loaded and valid</summary>
public  ALevelScriptActor GetLevelScriptActor()
{
	CheckIsValid();
	IntPtr ___ret = GetLevelScriptActor(_this.Get());
	if(___ret==IntPtr.Zero) return null; ALevelScriptActor ___ret2= new ALevelScriptActor(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsStreamingStatePending(IntPtr _this);
/// <summary>Returns whether level has streaming state change pending</summary>
public  bool IsStreamingStatePending()
{
	CheckIsValid();
	int ___ret = IsStreamingStatePending(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsLevelLoaded(IntPtr _this);
/// <summary>Returns whether streaming level is loaded</summary>
public  bool IsLevelLoaded()
{
	CheckIsValid();
	int ___ret = IsLevelLoaded(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsLevelVisible(IntPtr _this);
/// <summary>Returns whether streaming level is visible</summary>
public  bool IsLevelVisible()
{
	CheckIsValid();
	int ___ret = IsLevelVisible(_this.Get());
	return ___ret!=0;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
