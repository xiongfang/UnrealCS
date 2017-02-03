using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UGameViewportClient:UScriptViewportClient 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetConsoleTarget(IntPtr _this,int PlayerIndex);
/// <summary>Sets the player which console commands will be executed in the context of.</summary>
public  void SetConsoleTarget(int PlayerIndex)
{
	CheckIsValid();
	SetConsoleTarget(_this.Get(),PlayerIndex);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ShowTitleSafeArea(IntPtr _this);
/// <summary>Exec for toggling the display of the title safe area</summary>
public  void ShowTitleSafeArea()
{
	CheckIsValid();
	ShowTitleSafeArea(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SSSwapControllers(IntPtr _this);
/// <summary>Rotates controller ids among gameplayers, useful for testing splitscreen with only one controller.</summary>
public  void SSSwapControllers()
{
	CheckIsValid();
	SSSwapControllers(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
