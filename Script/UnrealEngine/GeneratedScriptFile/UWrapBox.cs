using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UWrapBox:UPanelWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr AddChildWrapBox(IntPtr _this,IntPtr Content);
public  UWrapBoxSlot AddChildWrapBox(UWidget Content)
{
	CheckIsValid();
	IntPtr ___ret = AddChildWrapBox(_this.Get(),Content);
	if(___ret==IntPtr.Zero) return null; UWrapBoxSlot ___ret2= new UWrapBoxSlot(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetInnerSlotPadding(IntPtr _this,ref FVector2D InPadding);
/// <summary>Sets the inner slot padding goes between slots sharing borders</summary>
public  void SetInnerSlotPadding(FVector2D InPadding)
{
	CheckIsValid();
	SetInnerSlotPadding(_this.Get(),ref InPadding);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
