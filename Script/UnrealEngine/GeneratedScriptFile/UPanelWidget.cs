using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPanelWidget:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearChildren(IntPtr _this);
/// <summary>Remove all child widgets from the panel widget.</summary>
public  void ClearChildren()
{
	CheckIsValid();
	ClearChildren(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasAnyChildren(IntPtr _this);
/// <summary>@return true if there are any child widgets in the panel</summary>
public  bool HasAnyChildren()
{
	CheckIsValid();
	int ___ret = HasAnyChildren(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int RemoveChild(IntPtr _this,IntPtr Content);
/// <summary>
/// Removes a specific widget from the container.
/// @return true if the widget was found and removed.
/// </summary>
public  bool RemoveChild(UWidget Content)
{
	CheckIsValid();
	int ___ret = RemoveChild(_this.Get(),Content);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr AddChild(IntPtr _this,IntPtr Content);
/// <summary>
/// Adds a new child widget to the container.  Returns the base slot type,
/// requires casting to turn it into the type specific to the container.
/// </summary>
public  UPanelSlot AddChild(UWidget Content)
{
	CheckIsValid();
	IntPtr ___ret = AddChild(_this.Get(),Content);
	if(___ret==IntPtr.Zero) return null; UPanelSlot ___ret2= new UPanelSlot(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int RemoveChildAt(IntPtr _this,int Index);
/// <summary>Removes a child by it's index.</summary>
public  bool RemoveChildAt(int Index)
{
	CheckIsValid();
	int ___ret = RemoveChildAt(_this.Get(),Index);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasChild(IntPtr _this,IntPtr Content);
/// <summary>@return true if panel contains this widget</summary>
public  bool HasChild(UWidget Content)
{
	CheckIsValid();
	int ___ret = HasChild(_this.Get(),Content);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetChildIndex(IntPtr _this,IntPtr Content);
/// <summary>Gets the index of a specific child widget</summary>
public  int GetChildIndex(UWidget Content)
{
	CheckIsValid();
	int ___ret = GetChildIndex(_this.Get(),Content);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetChildAt(IntPtr _this,int Index);
/// <summary>
/// Gets the widget at an index.
/// @param Index The index of the widget.
/// @return The widget at the given index, or nothing if there is no widget there.
/// </summary>
public  UWidget GetChildAt(int Index)
{
	CheckIsValid();
	IntPtr ___ret = GetChildAt(_this.Get(),Index);
	if(___ret==IntPtr.Zero) return null; UWidget ___ret2= new UWidget(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetChildrenCount(IntPtr _this);
/// <summary>Gets number of child widgets in the container.</summary>
public  int GetChildrenCount()
{
	CheckIsValid();
	int ___ret = GetChildrenCount(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
