using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UOverlay:UPanelWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr AddChildToOverlay(IntPtr _this,IntPtr Content);
public  UOverlaySlot AddChildToOverlay(UWidget Content)
{
	CheckIsValid();
	IntPtr ___ret = AddChildToOverlay(_this.Get(),Content);
	if(___ret==IntPtr.Zero) return null; UOverlaySlot ___ret2= new UOverlaySlot(){ _this = ___ret }; return ___ret2;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
