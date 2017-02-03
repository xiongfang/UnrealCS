using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UEditableText:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIsReadOnly(IntPtr _this,int InbIsReadyOnly);
public  void SetIsReadOnly(bool InbIsReadyOnly)
{
	CheckIsValid();
	SetIsReadOnly(_this.Get(),InbIsReadyOnly?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetHintText(IntPtr _this,string InHintText);
public  void SetHintText(string InHintText)
{
	CheckIsValid();
	SetHintText(_this.Get(),InHintText);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIsPassword(IntPtr _this,int InbIsPassword);
public  void SetIsPassword(bool InbIsPassword)
{
	CheckIsValid();
	SetIsPassword(_this.Get(),InbIsPassword?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetText(IntPtr _this,string InText);
/// <summary>
/// Directly sets the widget text.
/// Warning: This will wipe any binding created for the Text property!
/// @param InText The text to assign to the widget
/// </summary>
public  void SetText(string InText)
{
	CheckIsValid();
	SetText(_this.Get(),InText);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetText(IntPtr _this);
/// <summary>
/// Gets the widget text
/// @return The widget text
/// </summary>
public  string GetText()
{
	CheckIsValid();
	string ___ret = GetText(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
