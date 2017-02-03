using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UScaleBox:UContentWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIgnoreInheritedScale(IntPtr _this,int bInIgnoreInheritedScale);
public  void SetIgnoreInheritedScale(bool bInIgnoreInheritedScale)
{
	CheckIsValid();
	SetIgnoreInheritedScale(_this.Get(),bInIgnoreInheritedScale?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetUserSpecifiedScale(IntPtr _this,float InUserSpecifiedScale);
public  void SetUserSpecifiedScale(float InUserSpecifiedScale)
{
	CheckIsValid();
	SetUserSpecifiedScale(_this.Get(),InUserSpecifiedScale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetStretchDirection(IntPtr _this,int InStretchDirection);
public  void SetStretchDirection(EStretchDirection InStretchDirection)
{
	CheckIsValid();
	SetStretchDirection(_this.Get(),(int)InStretchDirection);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetStretch(IntPtr _this,int InStretch);
public  void SetStretch(EStretch InStretch)
{
	CheckIsValid();
	SetStretch(_this.Get(),(int)InStretch);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
