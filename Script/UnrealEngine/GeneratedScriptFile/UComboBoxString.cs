using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UComboBoxString:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetOptionCount(IntPtr _this);
/// <summary>@return The number of options</summary>
public  int GetOptionCount()
{
	CheckIsValid();
	int ___ret = GetOptionCount(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetSelectedOption(IntPtr _this);
public  string GetSelectedOption()
{
	CheckIsValid();
	string ___ret = GetSelectedOption(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSelectedOption(IntPtr _this,string Option);
public  void SetSelectedOption(string Option)
{
	CheckIsValid();
	SetSelectedOption(_this.Get(),Option);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RefreshOptions(IntPtr _this);
/// <summary>
/// Refreshes the list of options.  If you added new ones, and want to update the list even if it's
/// currently being displayed use this.
/// </summary>
public  void RefreshOptions()
{
	CheckIsValid();
	RefreshOptions(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearSelection(IntPtr _this);
public  void ClearSelection()
{
	CheckIsValid();
	ClearSelection(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearOptions(IntPtr _this);
public  void ClearOptions()
{
	CheckIsValid();
	ClearOptions(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetOptionAtIndex(IntPtr _this,int Index);
public  string GetOptionAtIndex(int Index)
{
	CheckIsValid();
	string ___ret = GetOptionAtIndex(_this.Get(),Index);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int FindOptionIndex(IntPtr _this,string Option);
public  int FindOptionIndex(string Option)
{
	CheckIsValid();
	int ___ret = FindOptionIndex(_this.Get(),Option);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int RemoveOption(IntPtr _this,string Option);
public  bool RemoveOption(string Option)
{
	CheckIsValid();
	int ___ret = RemoveOption(_this.Get(),Option);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddOption(IntPtr _this,string Option);
public  void AddOption(string Option)
{
	CheckIsValid();
	AddOption(_this.Get(),Option);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
