using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USlateBlueprintLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ScreenToViewport(IntPtr _this,IntPtr WorldContextObject,ref FVector2D ScreenPosition,out FVector2D ViewportPosition);
/// <summary>Translates a screen position in pixels into the local space of the viewport widget.</summary>
public static void ScreenToViewport(UObject WorldContextObject,FVector2D ScreenPosition,out FVector2D ViewportPosition)
{
	ScreenToViewport(IntPtr.Zero,WorldContextObject,ref ScreenPosition,out ViewportPosition);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ScreenToWidgetAbsolute(IntPtr _this,IntPtr WorldContextObject,ref FVector2D ScreenPosition,out FVector2D AbsoluteCoordinate);
/// <summary>Translates a screen position in pixels into absolute application coordinates.</summary>
public static void ScreenToWidgetAbsolute(UObject WorldContextObject,FVector2D ScreenPosition,out FVector2D AbsoluteCoordinate)
{
	ScreenToWidgetAbsolute(IntPtr.Zero,WorldContextObject,ref ScreenPosition,out AbsoluteCoordinate);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ScreenToWidgetLocal(IntPtr _this,IntPtr WorldContextObject,ref FGeometry Geometry,ref FVector2D ScreenPosition,out FVector2D LocalCoordinate);
/// <summary>Translates a screen position in pixels into the local space of a widget with the given geometry.</summary>
public static void ScreenToWidgetLocal(UObject WorldContextObject,FGeometry Geometry,FVector2D ScreenPosition,out FVector2D LocalCoordinate)
{
	ScreenToWidgetLocal(IntPtr.Zero,WorldContextObject,ref Geometry,ref ScreenPosition,out LocalCoordinate);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AbsoluteToViewport(IntPtr _this,IntPtr WorldContextObject,ref FVector2D AbsoluteDesktopCoordinate,out FVector2D PixelPosition,out FVector2D ViewportPosition);
/// <summary>
/// Translates absolute coordinate in desktop space of the geometry provided into local viewport coordinates.
/// @param PixelPosition The position in the game's viewport, usable for line traces and
/// other uses where you need a coordinate in the space of viewport resolution units.
/// @param ViewportPosition The position in the space of other widgets in the viewport.  Like if you wanted
/// to add another widget to the viewport at the same position in viewport space as this location, this is
/// what you would use.
/// </summary>
public static void AbsoluteToViewport(UObject WorldContextObject,FVector2D AbsoluteDesktopCoordinate,out FVector2D PixelPosition,out FVector2D ViewportPosition)
{
	AbsoluteToViewport(IntPtr.Zero,WorldContextObject,ref AbsoluteDesktopCoordinate,out PixelPosition,out ViewportPosition);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void LocalToViewport(IntPtr _this,IntPtr WorldContextObject,ref FGeometry Geometry,ref FVector2D LocalCoordinate,out FVector2D PixelPosition,out FVector2D ViewportPosition);
/// <summary>
/// Translates local coordinate of the geometry provided into local viewport coordinates.
/// @param PixelPosition The position in the game's viewport, usable for line traces and
/// other uses where you need a coordinate in the space of viewport resolution units.
/// @param ViewportPosition The position in the space of other widgets in the viewport.  Like if you wanted
/// to add another widget to the viewport at the same position in viewport space as this location, this is
/// what you would use.
/// </summary>
public static void LocalToViewport(UObject WorldContextObject,FGeometry Geometry,FVector2D LocalCoordinate,out FVector2D PixelPosition,out FVector2D ViewportPosition)
{
	LocalToViewport(IntPtr.Zero,WorldContextObject,ref Geometry,ref LocalCoordinate,out PixelPosition,out ViewportPosition);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_SlateBrush(IntPtr _this,ref FSlateBrush A,ref FSlateBrush B);
/// <summary>@return Whether brushes A and B are identical.</summary>
public static bool EqualEqual_SlateBrush(FSlateBrush A,FSlateBrush B)
{
	int ___ret = EqualEqual_SlateBrush(IntPtr.Zero,ref A,ref B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D GetLocalSize(IntPtr _this,ref FGeometry Geometry);
/// <summary>@return the size of the geometry in local space.</summary>
public static FVector2D GetLocalSize(FGeometry Geometry)
{
	FVector2D ___ret = GetLocalSize(IntPtr.Zero,ref Geometry);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D LocalToAbsolute(IntPtr _this,ref FGeometry Geometry,ref FVector2D LocalCoordinate);
/// <summary>
/// Translates local coordinates into absolute coordinates
/// Absolute coordinates could be either desktop or window space depending on what space the root of the widget hierarchy is in.
/// @return  Absolute coordinates
/// </summary>
public static FVector2D LocalToAbsolute(FGeometry Geometry,FVector2D LocalCoordinate)
{
	FVector2D ___ret = LocalToAbsolute(IntPtr.Zero,ref Geometry,ref LocalCoordinate);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D AbsoluteToLocal(IntPtr _this,ref FGeometry Geometry,ref FVector2D AbsoluteCoordinate);
/// <summary>
/// Absolute coordinates could be either desktop or window space depending on what space the root of the widget hierarchy is in.
/// @return Transforms AbsoluteCoordinate into the local space of this Geometry.
/// </summary>
public static FVector2D AbsoluteToLocal(FGeometry Geometry,FVector2D AbsoluteCoordinate)
{
	FVector2D ___ret = AbsoluteToLocal(IntPtr.Zero,ref Geometry,ref AbsoluteCoordinate);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsUnderLocation(IntPtr _this,ref FGeometry Geometry,ref FVector2D AbsoluteCoordinate);
/// <summary>
/// Absolute coordinates could be either desktop or window space depending on what space the root of the widget hierarchy is in.
/// @return true if the provided location in absolute coordinates is within the bounds of this geometry.
/// </summary>
public static bool IsUnderLocation(FGeometry Geometry,FVector2D AbsoluteCoordinate)
{
	int ___ret = IsUnderLocation(IntPtr.Zero,ref Geometry,ref AbsoluteCoordinate);
	return ___ret!=0;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
