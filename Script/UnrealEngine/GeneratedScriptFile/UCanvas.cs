using System;
namespace UnrealEngine
{
	public partial class UCanvas:UObject
	{
		/// <summary>
		/// Returns the clipped text size in screen space coordinates.
		/// @param RenderFont                            Font to use when determining the size of the text. If this is null, then a default engine font is used.
		/// @param RenderText                            Text to determine the size of.
		/// @param Scale                                         Scale of the font to use when determining the size of the text.
		/// @return                                                      Returns the screen space size of the text.
		/// </summary>
		public extern FVector2D K2_TextSize(UFont RenderFont,FString RenderText,FVector2D Scale=default(FVector2D));
		/// <summary>
		/// Returns the wrapped text size in screen space coordinates.
		/// @param RenderFont                            Font to use when determining the size of the text. If this is null, then a default engine font is used.
		/// @param RenderText                            Text to determine the size of.
		/// @return                                                      Returns the screen space size of the text.
		/// </summary>
		public extern FVector2D K2_StrLen(UFont RenderFont,FString RenderText);
		/// <summary>
		/// Performs a deprojection of a screen space coordinate using the projection matrix set up for the Canvas.
		/// @param ScreenPosition                        Screen space position to deproject to the World.
		/// @param WorldOrigin                           Vector which is the world position of the screen space position.
		/// @param WorldDirection                        Vector which can be used in a trace to determine what is "behind" the screen space position. Useful for object picking.
		/// </summary>
		public extern void K2_Deproject(FVector2D ScreenPosition,out FVector WorldOrigin,out FVector WorldDirection);
		/// <summary>
		/// Performs a projection of a world space coordinates using the projection matrix set up for the Canvas.
		/// @param WorldLocation                         World space location to project onto the Canvas rendering plane.
		/// @return                                                      Returns a vector where X, Y defines a screen space position representing the world space location.
		/// </summary>
		public extern FVector K2_Project(FVector WorldLocation);
		/// <summary>
		/// Draws a polygon on the Canvas.
		/// @param RenderTexture                         Texture to use when rendering the triangles. If no texture is set, then the default white texture is used.
		/// @param ScreenPosition                        Screen space position to render the text.
		/// @param Radius                                        How large in pixels this polygon should be.
		/// @param NumberOfSides                         How many sides this polygon should have. This should be above or equal to three.
		/// @param RenderColor                           Color to tint the polygon.
		/// </summary>
		public extern void K2_DrawPolygon(UTexture RenderTexture,FVector2D ScreenPosition,FVector2D Radius=default(FVector2D),int NumberOfSides=3,FLinearColor RenderColor=default(FLinearColor));
		/// <summary>
		/// Draws an unfilled box on the Canvas.
		/// @param ScreenPosition                        Screen space position to render the text.
		/// @param ScreenSize                            Screen space size to render the texture.
		/// @param Thickness                                     How many pixels thick the box lines should be.
		/// </summary>
		public extern void K2_DrawBox(FVector2D ScreenPosition,FVector2D ScreenSize,float Thickness=1.000000f);
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
		public extern void K2_DrawBorder(UTexture BorderTexture,UTexture BackgroundTexture,UTexture LeftBorderTexture,UTexture RightBorderTexture,UTexture TopBorderTexture,UTexture BottomBorderTexture,FVector2D ScreenPosition,FVector2D ScreenSize,FVector2D CoordinatePosition,FVector2D CoordinateSize=default(FVector2D),FLinearColor RenderColor=default(FLinearColor),FVector2D BorderScale=default(FVector2D),FVector2D BackgroundScale=default(FVector2D),float Rotation=0.000000f,FVector2D PivotPoint=default(FVector2D),FVector2D CornerSize=default(FVector2D));
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
		public extern void K2_DrawText(UFont RenderFont,FString RenderText,FVector2D ScreenPosition,FLinearColor RenderColor=default(FLinearColor),float Kerning=0.000000f,FLinearColor ShadowColor=default(FLinearColor),FVector2D ShadowOffset=default(FVector2D),bool bCentreX=false,bool bCentreY=false,bool bOutlined=false,FLinearColor OutlineColor=default(FLinearColor));
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
		public extern void K2_DrawMaterial(UMaterialInterface RenderMaterial,FVector2D ScreenPosition,FVector2D ScreenSize,FVector2D CoordinatePosition,FVector2D CoordinateSize=default(FVector2D),float Rotation=0.000000f,FVector2D PivotPoint=default(FVector2D));
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
		public extern void K2_DrawTexture(UTexture RenderTexture,FVector2D ScreenPosition,FVector2D ScreenSize,FVector2D CoordinatePosition,FVector2D CoordinateSize=default(FVector2D),FLinearColor RenderColor=default(FLinearColor),EBlendMode BlendMode=EBlendMode.BLEND_Translucent,float Rotation=0.000000f,FVector2D PivotPoint=default(FVector2D));
		/// <summary>
		/// Draws a line on the Canvas.
		/// @param ScreenPositionA               Starting position of the line in screen space.
		/// @param ScreenPositionB               Ending position of the line in screen space.
		/// @param Thickness                             How many pixels thick this line should be.
		/// @param RenderColor                   Color to render the line.
		/// </summary>
		public extern void K2_DrawLine(FVector2D ScreenPositionA,FVector2D ScreenPositionB,float Thickness=1.000000f,FLinearColor RenderColor=default(FLinearColor));
		/// <summary>Modifiable properties.</summary>
		public float OrgX;
		
		/// <summary>Origin for drawing in X.</summary>
		public float OrgY;
		
		/// <summary>Origin for drawing in Y.</summary>
		public float ClipX;
		
		/// <summary>Bottom right clipping region.</summary>
		public float ClipY;
		
		/// <summary>Bottom right clipping region.</summary>
		public FColor DrawColor;
		
		/// <summary>Color for drawing.</summary>
		public bool bCenterX;
		
		/// <summary>Whether to center the text horizontally (about CurX)</summary>
		public bool bCenterY;
		
		/// <summary>Whether to center the text vertically (about CurY)</summary>
		public bool bNoSmooth;
		
		/// <summary>Don't bilinear filter.</summary>
		public int SizeX;
		
		/// <summary>Zero-based actual dimensions X.</summary>
		public int SizeY;
		
		/// <summary>Internal.</summary>
		public FPlane ColorModulate;
		
		public UTexture2D DefaultTexture;
		
		/// <summary>Default texture to use</summary>
		public UTexture2D GradientTexture0;
		
		/// <summary>Helper class to render 2d graphs on canvas</summary>
		public UReporterGraph ReporterGraph;
		
		
	}
	
}
