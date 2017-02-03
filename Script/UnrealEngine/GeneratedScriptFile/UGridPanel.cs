using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UGridPanel:UPanelWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr AddChildToGrid(IntPtr _this,IntPtr Content);
public  UGridSlot AddChildToGrid(UWidget Content)
{
	CheckIsValid();
	IntPtr ___ret = AddChildToGrid(_this.Get(),Content);
	if(___ret==IntPtr.Zero) return null; UGridSlot ___ret2= new UGridSlot(){ _this = ___ret }; return ___ret2;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
