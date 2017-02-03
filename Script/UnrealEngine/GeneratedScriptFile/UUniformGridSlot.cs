using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UUniformGridSlot:UPanelSlot 
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
extern static void SetColumn(IntPtr _this,int InColumn);
/// <summary>Sets the column index of the slot, this determines what cell the slot is in the panel</summary>
public  void SetColumn(int InColumn)
{
	CheckIsValid();
	SetColumn(_this.Get(),InColumn);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRow(IntPtr _this,int InRow);
/// <summary>Sets the row index of the slot, this determines what cell the slot is in the panel</summary>
public  void SetRow(int InRow)
{
	CheckIsValid();
	SetRow(_this.Get(),InRow);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
