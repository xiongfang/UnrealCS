using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class ACameraActor:AActor 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetAutoActivatePlayerIndex(IntPtr _this);
/// <summary>Returns index of the player for whom we auto-activate, or INDEX_NONE (-1) if disabled.</summary>
public  int GetAutoActivatePlayerIndex()
{
	CheckIsValid();
	int ___ret = GetAutoActivatePlayerIndex(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
