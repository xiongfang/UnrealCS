using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCheckBox:UContentWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCheckedState(IntPtr _this,int InCheckedState);
/// <summary>Sets the checked state.</summary>
public  void SetCheckedState(ECheckBoxState InCheckedState)
{
	CheckIsValid();
	SetCheckedState(_this.Get(),(int)InCheckedState);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIsChecked(IntPtr _this,int InIsChecked);
/// <summary>Sets the checked state.</summary>
public  void SetIsChecked(bool InIsChecked)
{
	CheckIsValid();
	SetIsChecked(_this.Get(),InIsChecked?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetCheckedState(IntPtr _this);
/// <summary>@return the full current checked state.</summary>
public  ECheckBoxState GetCheckedState()
{
	CheckIsValid();
	int ___ret = GetCheckedState(_this.Get());
	return (ECheckBoxState)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsChecked(IntPtr _this);
/// <summary>Returns true if the checkbox is currently checked</summary>
public  bool IsChecked()
{
	CheckIsValid();
	int ___ret = IsChecked(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsPressed(IntPtr _this);
/// <summary>Returns true if this button is currently pressed</summary>
public  bool IsPressed()
{
	CheckIsValid();
	int ___ret = IsPressed(_this.Get());
	return ___ret!=0;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
