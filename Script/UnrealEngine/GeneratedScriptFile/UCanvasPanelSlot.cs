using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCanvasPanelSlot:UPanelSlot 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMaximum(IntPtr _this,ref FVector2D InMaximumAnchors);
/// <summary>Sets the anchors on the slot</summary>
public  void SetMaximum(FVector2D InMaximumAnchors)
{
	CheckIsValid();
	SetMaximum(_this.Get(),ref InMaximumAnchors);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMinimum(IntPtr _this,ref FVector2D InMinimumAnchors);
/// <summary>Sets the anchors on the slot</summary>
public  void SetMinimum(FVector2D InMinimumAnchors)
{
	CheckIsValid();
	SetMinimum(_this.Get(),ref InMinimumAnchors);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetZOrder(IntPtr _this);
/// <summary>Gets the z-order on the slot</summary>
public  int GetZOrder()
{
	CheckIsValid();
	int ___ret = GetZOrder(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetZOrder(IntPtr _this,int InZOrder);
/// <summary>Sets the z-order on the slot</summary>
public  void SetZOrder(int InZOrder)
{
	CheckIsValid();
	SetZOrder(_this.Get(),InZOrder);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetAutoSize(IntPtr _this);
/// <summary>Gets if the slot to be auto-sized</summary>
public  bool GetAutoSize()
{
	CheckIsValid();
	int ___ret = GetAutoSize(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAutoSize(IntPtr _this,int InbAutoSize);
/// <summary>Sets if the slot to be auto-sized</summary>
public  void SetAutoSize(bool InbAutoSize)
{
	CheckIsValid();
	SetAutoSize(_this.Get(),InbAutoSize?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D GetAlignment(IntPtr _this);
/// <summary>Gets the alignment on the slot</summary>
public  FVector2D GetAlignment()
{
	CheckIsValid();
	FVector2D ___ret = GetAlignment(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAlignment(IntPtr _this,ref FVector2D InAlignment);
/// <summary>Sets the alignment on the slot</summary>
public  void SetAlignment(FVector2D InAlignment)
{
	CheckIsValid();
	SetAlignment(_this.Get(),ref InAlignment);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FAnchors GetAnchors(IntPtr _this);
/// <summary>Gets the anchors on the slot</summary>
public  FAnchors GetAnchors()
{
	CheckIsValid();
	FAnchors ___ret = GetAnchors(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAnchors(IntPtr _this,ref FAnchors InAnchors);
/// <summary>Sets the anchors on the slot</summary>
public  void SetAnchors(FAnchors InAnchors)
{
	CheckIsValid();
	SetAnchors(_this.Get(),ref InAnchors);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FMargin GetOffsets(IntPtr _this);
/// <summary>Gets the offset data of the slot, which could be position and size, or margins depending on the anchor points</summary>
public  FMargin GetOffsets()
{
	CheckIsValid();
	FMargin ___ret = GetOffsets(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOffsets(IntPtr _this,ref FMargin InOffset);
/// <summary>Sets the offset data of the slot, which could be position and size, or margins depending on the anchor points</summary>
public  void SetOffsets(FMargin InOffset)
{
	CheckIsValid();
	SetOffsets(_this.Get(),ref InOffset);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D GetSize(IntPtr _this);
/// <summary>Gets the size of the slot</summary>
public  FVector2D GetSize()
{
	CheckIsValid();
	FVector2D ___ret = GetSize(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSize(IntPtr _this,ref FVector2D InSize);
/// <summary>Sets the size of the slot</summary>
public  void SetSize(FVector2D InSize)
{
	CheckIsValid();
	SetSize(_this.Get(),ref InSize);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D GetPosition(IntPtr _this);
/// <summary>Gets the position of the slot</summary>
public  FVector2D GetPosition()
{
	CheckIsValid();
	FVector2D ___ret = GetPosition(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPosition(IntPtr _this,ref FVector2D InPosition);
/// <summary>Sets the position of the slot</summary>
public  void SetPosition(FVector2D InPosition)
{
	CheckIsValid();
	SetPosition(_this.Get(),ref InPosition);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FAnchorData GetLayout(IntPtr _this);
/// <summary>Gets the layout data of the slot</summary>
public  FAnchorData GetLayout()
{
	CheckIsValid();
	FAnchorData ___ret = GetLayout(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLayout(IntPtr _this,ref FAnchorData InLayoutData);
/// <summary>Sets the layout data of the slot</summary>
public  void SetLayout(FAnchorData InLayoutData)
{
	CheckIsValid();
	SetLayout(_this.Get(),ref InLayoutData);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
