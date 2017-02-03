using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USlateBlueprintLibrary:UBlueprintFunctionLibrary 
{
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
