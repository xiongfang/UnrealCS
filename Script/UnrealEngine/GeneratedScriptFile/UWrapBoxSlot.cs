using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UWrapBoxSlot:UPanelSlot 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVerticalAlignment(IntPtr _this,int InVerticalAlignment);
public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
{
	CheckIsValid();
	SetVerticalAlignment(_this.Get(),(int)InVerticalAlignment);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetHorizontalAlignment(IntPtr _this,int InHorizontalAlignment);
public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
{
	CheckIsValid();
	SetHorizontalAlignment(_this.Get(),(int)InHorizontalAlignment);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFillSpanWhenLessThan(IntPtr _this,float InFillSpanWhenLessThan);
public  void SetFillSpanWhenLessThan(float InFillSpanWhenLessThan)
{
	CheckIsValid();
	SetFillSpanWhenLessThan(_this.Get(),InFillSpanWhenLessThan);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFillEmptySpace(IntPtr _this,int InbFillEmptySpace);
public  void SetFillEmptySpace(bool InbFillEmptySpace)
{
	CheckIsValid();
	SetFillEmptySpace(_this.Get(),InbFillEmptySpace?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPadding(IntPtr _this,ref FMargin InPadding);
public  void SetPadding(FMargin InPadding)
{
	CheckIsValid();
	SetPadding(_this.Get(),ref InPadding);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
