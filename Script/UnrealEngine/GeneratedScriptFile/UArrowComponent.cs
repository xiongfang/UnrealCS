using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UArrowComponent:UPrimitiveComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetArrowColor_New(IntPtr _this,ref FLinearColor NewColor);
/// <summary>Updates the arrow's colour, and tells it to refresh</summary>
public  void SetArrowColor_New(FLinearColor NewColor)
{
	CheckIsValid();
	SetArrowColor_New(_this.Get(),ref NewColor);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
