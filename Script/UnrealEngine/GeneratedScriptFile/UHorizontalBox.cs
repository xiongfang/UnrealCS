using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UHorizontalBox:UPanelWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr AddChildToHorizontalBox(IntPtr _this,IntPtr Content);
public  UHorizontalBoxSlot AddChildToHorizontalBox(UWidget Content)
{
	CheckIsValid();
	IntPtr ___ret = AddChildToHorizontalBox(_this.Get(),Content);
	if(___ret==IntPtr.Zero) return null; UHorizontalBoxSlot ___ret2= new UHorizontalBoxSlot(){ _this = ___ret }; return ___ret2;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
