using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UVerticalBox:UPanelWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr AddChildToVerticalBox(IntPtr _this,IntPtr Content);
public  UVerticalBoxSlot AddChildToVerticalBox(UWidget Content)
{
	CheckIsValid();
	IntPtr ___ret = AddChildToVerticalBox(_this.Get(),Content);
	if(___ret==IntPtr.Zero) return null; UVerticalBoxSlot ___ret2= new UVerticalBoxSlot(){ _this = ___ret }; return ___ret2;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
