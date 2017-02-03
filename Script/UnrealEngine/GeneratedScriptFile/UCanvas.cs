using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCanvas:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D K2_TextSize(IntPtr _this,IntPtr RenderFont,string RenderText,ref FVector2D Scale);
/// <summary>
/// Returns the clipped text size in screen space coordinates.
/// @param RenderFont                            Font to use when determining the size of the text. If this is null, then a default engine font is used.
/// @param RenderText                            Text to determine the size of.
/// @param Scale                                         Scale of the font to use when determining the size of the text.
/// @return                                                      Returns the screen space size of the text.
/// </summary>
public  FVector2D K2_TextSize(UFont RenderFont,string RenderText,FVector2D Scale=default(FVector2D))
{
	CheckIsValid();
	FVector2D ___ret = K2_TextSize(_this.Get(),RenderFont,RenderText,ref Scale);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D K2_StrLen(IntPtr _this,IntPtr RenderFont,string RenderText);
/// <summary>
/// Returns the wrapped text size in screen space coordinates.
/// @param RenderFont                            Font to use when determining the size of the text. If this is null, then a default engine font is used.
/// @param RenderText                            Text to determine the size of.
/// @return                                                      Returns the screen space size of the text.
/// </summary>
public  FVector2D K2_StrLen(UFont RenderFont,string RenderText)
{
	CheckIsValid();
	FVector2D ___ret = K2_StrLen(_this.Get(),RenderFont,RenderText);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_Deproject(IntPtr _this,ref FVector2D ScreenPosition,out FVector WorldOrigin,out FVector WorldDirection);
/// <summary>
/// Performs a deprojection of a screen space coordinate using the projection matrix set up for the Canvas.
/// @param ScreenPosition                        Screen space position to deproject to the World.
/// @param WorldOrigin                           Vector which is the world position of the screen space position.
/// @param WorldDirection                        Vector which can be used in a trace to determine what is "behind" the screen space position. Useful for object picking.
/// </summary>
public  void K2_Deproject(FVector2D ScreenPosition,out FVector WorldOrigin,out FVector WorldDirection)
{
	CheckIsValid();
	K2_Deproject(_this.Get(),ref ScreenPosition,out WorldOrigin,out WorldDirection);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector K2_Project(IntPtr _this,ref FVector WorldLocation);
/// <summary>
/// Performs a projection of a world space coordinates using the projection matrix set up for the Canvas.
/// @param WorldLocation                         World space location to project onto the Canvas rendering plane.
/// @return                                                      Returns a vector where X, Y defines a screen space position representing the world space location.
/// </summary>
public  FVector K2_Project(FVector WorldLocation)
{
	CheckIsValid();
	FVector ___ret = K2_Project(_this.Get(),ref WorldLocation);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DrawPolygon(IntPtr _this,IntPtr RenderTexture,ref FVector2D ScreenPosition,ref FVector2D Radius,int NumberOfSides,ref FLinearColor RenderColor);
/// <summary>
/// Draws a polygon on the Canvas.
/// @param RenderTexture                         Texture to use when rendering the triangles. If no texture is set, then the default white texture is used.
/// @param ScreenPosition                        Screen space position to render the text.
/// @param Radius                                        How large in pixels this polygon should be.
/// @param NumberOfSides                         How many sides this polygon should have. This should be above or equal to three.
/// @param RenderColor                           Color to tint the polygon.
/// </summary>
public  void K2_DrawPolygon(UTexture RenderTexture,FVector2D ScreenPosition,FVector2D Radius=default(FVector2D),int NumberOfSides=3,FLinearColor RenderColor=default(FLinearColor))
{
	CheckIsValid();
	K2_DrawPolygon(_this.Get(),RenderTexture,ref ScreenPosition,ref Radius,NumberOfSides,ref RenderColor);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DrawMaterialTriangle(IntPtr _this,IntPtr RenderMaterial,FCanvasUVTri[] Triangles);
/// <summary>
/// Draws a set of triangles on the Canvas.
/// @param RenderMaterial                        Material to use when rendering. Remember that only the emissive channel is able to be rendered as no lighting is performed when rendering to the Canvas.
/// @param Triangles                                     Triangles to render.
/// </summary>
public  void K2_DrawMaterialTriangle(UMaterialInterface RenderMaterial,FCanvasUVTri[] Triangles)
{
	CheckIsValid();
	K2_DrawMaterialTriangle(_this.Get(),RenderMaterial,Triangles);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DrawTriangle(IntPtr _this,IntPtr RenderTexture,FCanvasUVTri[] Triangles);
/// <summary>
/// Draws a set of triangles on the Canvas.
/// @param RenderTexture                         Texture to use when rendering the triangles. If no texture is set, then the default white texture is used.
/// @param Triangles                                     Triangles to render.
/// </summary>
public  void K2_DrawTriangle(UTexture RenderTexture,FCanvasUVTri[] Triangles)
{
	CheckIsValid();
	K2_DrawTriangle(_this.Get(),RenderTexture,Triangles);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DrawBox(IntPtr _this,ref FVector2D ScreenPosition,ref FVector2D ScreenSize,float Thickness);
/// <summary>
/// Draws an unfilled box on the Canvas.
/// @param ScreenPosition                        Screen space position to render the text.
/// @param ScreenSize                            Screen space size to render the texture.
/// @param Thickness                                     How many pixels thick the box lines should be.
/// </summary>
public  void K2_DrawBox(FVector2D ScreenPosition,FVector2D ScreenSize,float Thickness=1.000000f)
{
	CheckIsValid();
	K2_DrawBox(_this.Get(),ref ScreenPosition,ref ScreenSize,Thickness);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DrawBorder(IntPtr _this,IntPtr BorderTexture,IntPtr BackgroundTexture,IntPtr LeftBorderTexture,IntPtr RightBorderTexture,IntPtr TopBorderTexture,IntPtr BottomBorderTexture,ref FVector2D ScreenPosition,ref FVector2D ScreenSize,ref FVector2D CoordinatePosition,ref FVector2D CoordinateSize,ref FLinearColor RenderColor,ref FVector2D BorderScale,ref FVector2D BackgroundScale,float Rotation,ref FVector2D PivotPoint,ref FVector2D CornerSize);
/// <summary>
/// Draws a 3x3 grid border with tiled frame and tiled interior on the Canvas.
/// @param BorderTexture                         Texture to use for border.
/// @param BackgroundTexture                     Texture to use for border background.
/// @param LeftBorderTexture                     Texture to use for the tiling left border.
/// @param RightBorderTexture            Texture to use for the tiling right border.
/// @param TopBorderTexture                      Texture to use for the tiling top border.
/// @param BottomBorderTexture           Texture to use for the tiling bottom border.
/// @param ScreenPosition                        Screen space position to render the texture.
/// @param ScreenSize                            Screen space size to render the texture.
/// @param CoordinatePosition            Normalized UV starting coordinate to use when rendering the border texture.
/// @param CoordinateSize                        Normalized UV size coordinate to use when rendering the border texture.
/// @param RenderColor                           Color to tint the border.
/// @param BorderScale                           Scale of the border.
/// @param BackgroundScale                       Scale of the background.
/// @param Rotation                                      Rotation, in degrees, to render the texture.
/// @param PivotPoint                            Normalized pivot point to use when rotating the texture.
/// @param CornerSize                            Frame corner size in percent of frame texture (should be < 0.5f).
/// </summary>
public  void K2_DrawBorder(UTexture BorderTexture,UTexture BackgroundTexture,UTexture LeftBorderTexture,UTexture RightBorderTexture,UTexture TopBorderTexture,UTexture BottomBorderTexture,FVector2D ScreenPosition,FVector2D ScreenSize,FVector2D CoordinatePosition,FVector2D CoordinateSize=default(FVector2D),FLinearColor RenderColor=default(FLinearColor),FVector2D BorderScale=default(FVector2D),FVector2D BackgroundScale=default(FVector2D),float Rotation=0.000000f,FVector2D PivotPoint=default(FVector2D),FVector2D CornerSize=default(FVector2D))
{
	CheckIsValid();
	K2_DrawBorder(_this.Get(),BorderTexture,BackgroundTexture,LeftBorderTexture,RightBorderTexture,TopBorderTexture,BottomBorderTexture,ref ScreenPosition,ref ScreenSize,ref CoordinatePosition,ref CoordinateSize,ref RenderColor,ref BorderScale,ref BackgroundScale,Rotation,ref PivotPoint,ref CornerSize);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DrawText(IntPtr _this,IntPtr RenderFont,string RenderText,ref FVector2D ScreenPosition,ref FLinearColor RenderColor,float Kerning,ref FLinearColor ShadowColor,ref FVector2D ShadowOffset,int bCentreX,int bCentreY,int bOutlined,ref FLinearColor OutlineColor);
/// <summary>
/// Draws text on the Canvas.
/// @param RenderFont                            Font to use when rendering the text. If this is null, then a default engine font is used.
/// @param RenderText                            Text to render on the Canvas.
/// @param ScreenPosition                        Screen space position to render the text.
/// @param RenderColor                           Color to render the text.
/// @param Kerning                                       Horizontal spacing adjustment to modify the spacing between each letter.
/// @param ShadowColor                           Color to render the shadow of the text.
/// @param ShadowOffset                          Pixel offset relative to the screen space position to render the shadow of the text.
/// @param bCentreX                                      If true, then interpret the screen space position X coordinate as the center of the rendered text.
/// @param bCentreY                                      If true, then interpret the screen space position Y coordinate as the center of the rendered text.
/// @param bOutlined                                     If true, then the text should be rendered with an outline.
/// @param OutlineColor                          Color to render the outline for the text.
/// </summary>
public  void K2_DrawText(UFont RenderFont,string RenderText,FVector2D ScreenPosition,FLinearColor RenderColor=default(FLinearColor),float Kerning=0.000000f,FLinearColor ShadowColor=default(FLinearColor),FVector2D ShadowOffset=default(FVector2D),bool bCentreX=false,bool bCentreY=false,bool bOutlined=false,FLinearColor OutlineColor=default(FLinearColor))
{
	CheckIsValid();
	K2_DrawText(_this.Get(),RenderFont,RenderText,ref ScreenPosition,ref RenderColor,Kerning,ref ShadowColor,ref ShadowOffset,bCentreX?1:0,bCentreY?1:0,bOutlined?1:0,ref OutlineColor);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DrawMaterial(IntPtr _this,IntPtr RenderMaterial,ref FVector2D ScreenPosition,ref FVector2D ScreenSize,ref FVector2D CoordinatePosition,ref FVector2D CoordinateSize,float Rotation,ref FVector2D PivotPoint);
/// <summary>
/// Draws a material on the Canvas.
/// @param RenderMaterial                        Material to use when rendering. Remember that only the emissive channel is able to be rendered as no lighting is performed when rendering to the Canvas.
/// @param ScreenPosition                        Screen space position to render the texture.
/// @param ScreenSize                            Screen space size to render the texture.
/// @param CoordinatePosition            Normalized UV starting coordinate to use when rendering the texture.
/// @param CoordinateSize                        Normalized UV size coordinate to use when rendering the texture.
/// @param Rotation                                      Rotation, in degrees, to render the texture.
/// @param PivotPoint                            Normalized pivot point to use when rotating the texture.
/// </summary>
public  void K2_DrawMaterial(UMaterialInterface RenderMaterial,FVector2D ScreenPosition,FVector2D ScreenSize,FVector2D CoordinatePosition,FVector2D CoordinateSize=default(FVector2D),float Rotation=0.000000f,FVector2D PivotPoint=default(FVector2D))
{
	CheckIsValid();
	K2_DrawMaterial(_this.Get(),RenderMaterial,ref ScreenPosition,ref ScreenSize,ref CoordinatePosition,ref CoordinateSize,Rotation,ref PivotPoint);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DrawTexture(IntPtr _this,IntPtr RenderTexture,ref FVector2D ScreenPosition,ref FVector2D ScreenSize,ref FVector2D CoordinatePosition,ref FVector2D CoordinateSize,ref FLinearColor RenderColor,int BlendMode,float Rotation,ref FVector2D PivotPoint);
/// <summary>
/// Draws a texture on the Canvas.
/// @param RenderTexture                         Texture to use when rendering. If no texture is set then this will use the default white texture.
/// @param ScreenPosition                        Screen space position to render the texture.
/// @param ScreenSize                            Screen space size to render the texture.
/// @param CoordinatePosition            Normalized UV starting coordinate to use when rendering the texture.
/// @param CoordinateSize                        Normalized UV size coordinate to use when rendering the texture.
/// @param RenderColor                           Color to use when rendering the texture.
/// @param BlendMode                                     Blending mode to use when rendering the texture.
/// @param Rotation                                      Rotation, in degrees, to render the texture.
/// @param PivotPoint                            Normalized pivot point to use when rotating the texture.
/// </summary>
public  void K2_DrawTexture(UTexture RenderTexture,FVector2D ScreenPosition,FVector2D ScreenSize,FVector2D CoordinatePosition,FVector2D CoordinateSize=default(FVector2D),FLinearColor RenderColor=default(FLinearColor),EBlendMode BlendMode=EBlendMode.BLEND_Translucent,float Rotation=0.000000f,FVector2D PivotPoint=default(FVector2D))
{
	CheckIsValid();
	K2_DrawTexture(_this.Get(),RenderTexture,ref ScreenPosition,ref ScreenSize,ref CoordinatePosition,ref CoordinateSize,ref RenderColor,(int)BlendMode,Rotation,ref PivotPoint);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DrawLine(IntPtr _this,ref FVector2D ScreenPositionA,ref FVector2D ScreenPositionB,float Thickness,ref FLinearColor RenderColor);
/// <summary>
/// Draws a line on the Canvas.
/// @param ScreenPositionA               Starting position of the line in screen space.
/// @param ScreenPositionB               Ending position of the line in screen space.
/// @param Thickness                             How many pixels thick this line should be.
/// @param RenderColor                   Color to render the line.
/// </summary>
public  void K2_DrawLine(FVector2D ScreenPositionA,FVector2D ScreenPositionB,float Thickness=1.000000f,FLinearColor RenderColor=default(FLinearColor))
{
	CheckIsValid();
	K2_DrawLine(_this.Get(),ref ScreenPositionA,ref ScreenPositionB,Thickness,ref RenderColor);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
