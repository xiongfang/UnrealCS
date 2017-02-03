using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCanvasPanel:UPanelWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr AddChildToCanvas(IntPtr _this,IntPtr Content);
public  UCanvasPanelSlot AddChildToCanvas(UWidget Content)
{
	CheckIsValid();
	IntPtr ___ret = AddChildToCanvas(_this.Get(),Content);
	if(___ret==IntPtr.Zero) return null; UCanvasPanelSlot ___ret2= new UCanvasPanelSlot(){ _this = ___ret }; return ___ret2;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
