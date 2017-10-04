using System;
namespace UnrealEngine
{
	public partial class USlateBlueprintLibrary:UBlueprintFunctionLibrary
	{
		/// <summary>Translates a screen position in pixels into the local space of the viewport widget.</summary>
		public extern static void ScreenToViewport(UObject WorldContextObject,FVector2D ScreenPosition,out FVector2D ViewportPosition);
		/// <summary>Translates a screen position in pixels into absolute application coordinates.</summary>
		public extern static void ScreenToWidgetAbsolute(UObject WorldContextObject,FVector2D ScreenPosition,out FVector2D AbsoluteCoordinate);
		/// <summary>Translates a screen position in pixels into the local space of a widget with the given geometry.</summary>
		public extern static void ScreenToWidgetLocal(UObject WorldContextObject,FGeometry Geometry,FVector2D ScreenPosition,out FVector2D LocalCoordinate);
		/// <summary>
		/// Translates absolute coordinate in desktop space of the geometry provided into local viewport coordinates.
		/// @param PixelPosition The position in the game's viewport, usable for line traces and
		/// other uses where you need a coordinate in the space of viewport resolution units.
		/// @param ViewportPosition The position in the space of other widgets in the viewport.  Like if you wanted
		/// to add another widget to the viewport at the same position in viewport space as this location, this is
		/// what you would use.
		/// </summary>
		public extern static void AbsoluteToViewport(UObject WorldContextObject,FVector2D AbsoluteDesktopCoordinate,out FVector2D PixelPosition,out FVector2D ViewportPosition);
		/// <summary>
		/// Translates local coordinate of the geometry provided into local viewport coordinates.
		/// @param PixelPosition The position in the game's viewport, usable for line traces and
		/// other uses where you need a coordinate in the space of viewport resolution units.
		/// @param ViewportPosition The position in the space of other widgets in the viewport.  Like if you wanted
		/// to add another widget to the viewport at the same position in viewport space as this location, this is
		/// what you would use.
		/// </summary>
		public extern static void LocalToViewport(UObject WorldContextObject,FGeometry Geometry,FVector2D LocalCoordinate,out FVector2D PixelPosition,out FVector2D ViewportPosition);
		/// <summary>@return Whether brushes A and B are identical.</summary>
		public extern static bool EqualEqual_SlateBrush(FSlateBrush A,FSlateBrush B);
		/// <summary>@return the size of the geometry in local space.</summary>
		public extern static FVector2D GetLocalSize(FGeometry Geometry);
		/// <summary>
		/// Translates local coordinates into absolute coordinates
		/// Absolute coordinates could be either desktop or window space depending on what space the root of the widget hierarchy is in.
		/// @return  Absolute coordinates
		/// </summary>
		public extern static FVector2D LocalToAbsolute(FGeometry Geometry,FVector2D LocalCoordinate);
		/// <summary>
		/// Absolute coordinates could be either desktop or window space depending on what space the root of the widget hierarchy is in.
		/// @return Transforms AbsoluteCoordinate into the local space of this Geometry.
		/// </summary>
		public extern static FVector2D AbsoluteToLocal(FGeometry Geometry,FVector2D AbsoluteCoordinate);
		/// <summary>
		/// Absolute coordinates could be either desktop or window space depending on what space the root of the widget hierarchy is in.
		/// @return true if the provided location in absolute coordinates is within the bounds of this geometry.
		/// </summary>
		public extern static bool IsUnderLocation(FGeometry Geometry,FVector2D AbsoluteCoordinate);
		
	}
	
}
