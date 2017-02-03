using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UInputKeySelector:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetIsSelectingKey(IntPtr _this);
/// <summary>Returns true if the widget is currently selecting a key, otherwise returns false.</summary>
public  bool GetIsSelectingKey()
{
	CheckIsValid();
	int ___ret = GetIsSelectingKey(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAllowModifierKeys(IntPtr _this,int bInAllowModifierKeys);
/// <summary>Sets whether or not modifier keys are allowed in the selected key.</summary>
public  void SetAllowModifierKeys(bool bInAllowModifierKeys)
{
	CheckIsValid();
	SetAllowModifierKeys(_this.Get(),bInAllowModifierKeys?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetKeySelectionText(IntPtr _this,string InKeySelectionText);
/// <summary>Sets the text which is displayed while selecting keys.</summary>
public  void SetKeySelectionText(string InKeySelectionText)
{
	CheckIsValid();
	SetKeySelectionText(_this.Get(),InKeySelectionText);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSelectedKey(IntPtr _this,ref FInputChord InSelectedKey);
/// <summary>Sets the currently selected key.</summary>
public  void SetSelectedKey(FInputChord InSelectedKey)
{
	CheckIsValid();
	SetSelectedKey(_this.Get(),ref InSelectedKey);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
