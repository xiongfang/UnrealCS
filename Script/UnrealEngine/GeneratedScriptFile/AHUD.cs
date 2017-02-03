using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AHUD:AActor 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddHitBox(IntPtr _this,ref FVector2D Position,ref FVector2D Size,string InName,int bConsumesInput,int Priority);
/// <summary>
/// Add a hitbox to the hud
/// @param Position                      Coordinates of the top left of the hit box.
/// @param Size                          Size of the hit box.
/// @param Name                          Name of the hit box.
/// @param bConsumesInput        Whether click processing should continue if this hit box is clicked.
/// @param Priority                      The priority of the box used for layering. Larger values are considered first.  Equal values are considered in the order they were added.
/// </summary>
public  void AddHitBox(FVector2D Position,FVector2D Size,string InName,bool bConsumesInput,int Priority=0)
{
	CheckIsValid();
	AddHitBox(_this.Get(),ref Position,ref Size,InName,bConsumesInput?1:0,Priority);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetActorsInSelectionRectangle(IntPtr _this,IntPtr ClassFilter,ref FVector2D FirstPoint,ref FVector2D SecondPoint,out IntPtr[] OutActors,int bIncludeNonCollidingComponents,int bActorMustBeFullyEnclosed);
/// <summary>
/// Returns the array of actors inside a selection rectangle, with a class filter.
/// Sample usage:
///       TArray<AStaticMeshActor*> ActorsInSelectionRect;
///              Canvas->GetActorsInSelectionRectangle<AStaticMeshActor>(FirstPoint,SecondPoint,ActorsInSelectionRect);
/// @param FirstPoint                                    The first point, or anchor of the marquee box. Where the dragging of the marquee started in screen space.
/// @param SecondPoint                                   The second point, where the mouse cursor currently is / the other point of the box selection, in screen space.
/// @return OutActors                                    The actors that are within the selection box according to selection rule
/// @param bIncludeNonCollidingComponents        Whether to include even non-colliding components of the actor when determining its bounds
/// @param bActorMustBeFullyEnclosed     The Selection rule: whether the selection box can partially intersect Actor, or must fully enclose the Actor.
/// </summary>
public  void GetActorsInSelectionRectangle(TSubclassOf<AActor>  ClassFilter,FVector2D FirstPoint,FVector2D SecondPoint,out AActor[] OutActors,bool bIncludeNonCollidingComponents=true,bool bActorMustBeFullyEnclosed=false)
{
	CheckIsValid();
	IntPtr[] OutActors_temp;
	GetActorsInSelectionRectangle(_this.Get(),ClassFilter.NativeClass,ref FirstPoint,ref SecondPoint,out OutActors_temp,bIncludeNonCollidingComponents?1:0,bActorMustBeFullyEnclosed?1:0);
	OutActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActors_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Deproject(IntPtr _this,float ScreenX,float ScreenY,out FVector WorldPosition,out FVector WorldDirection);
/// <summary>Transforms a 2D screen location into a 3D location and direction</summary>
public  void Deproject(float ScreenX,float ScreenY,out FVector WorldPosition,out FVector WorldDirection)
{
	CheckIsValid();
	Deproject(_this.Get(),ScreenX,ScreenY,out WorldPosition,out WorldDirection);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Project(IntPtr _this,ref FVector Location);
/// <summary>Transforms a 3D world-space vector into 2D screen coordinates</summary>
public  FVector Project(FVector Location)
{
	CheckIsValid();
	FVector ___ret = Project(_this.Get(),ref Location);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawMaterialTriangle(IntPtr _this,IntPtr Material,ref FVector2D V0_Pos,ref FVector2D V1_Pos,ref FVector2D V2_Pos,ref FVector2D V0_UV,ref FVector2D V1_UV,ref FVector2D V2_UV,ref FLinearColor V0_Color,ref FLinearColor V1_Color,ref FLinearColor V2_Color);
public  void DrawMaterialTriangle(UMaterialInterface Material,FVector2D V0_Pos,FVector2D V1_Pos,FVector2D V2_Pos,FVector2D V0_UV,FVector2D V1_UV,FVector2D V2_UV,FLinearColor V0_Color=default(FLinearColor),FLinearColor V1_Color=default(FLinearColor),FLinearColor V2_Color=default(FLinearColor))
{
	CheckIsValid();
	DrawMaterialTriangle(_this.Get(),Material,ref V0_Pos,ref V1_Pos,ref V2_Pos,ref V0_UV,ref V1_UV,ref V2_UV,ref V0_Color,ref V1_Color,ref V2_Color);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawMaterialSimple(IntPtr _this,IntPtr Material,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float Scale,int bScalePosition);
/// <summary>
/// Draws a material-textured quad on the HUD.  Assumes UVs such that the entire material is shown.
/// @param Material                      Material to use
/// @param ScreenX                       Screen-space X coordinate of upper left corner of the quad.
/// @param ScreenY                       Screen-space Y coordinate of upper left corner of the quad.
/// @param ScreenW                       Screen-space width of the quad (in pixels).
/// @param ScreenH                       Screen-space height of the quad (in pixels).
/// @param Scale                         Amount to scale the entire texture (horizontally and vertically)
/// @param bScalePosition        Whether the "Scale" parameter should also scale the position of this draw call.
/// </summary>
public  void DrawMaterialSimple(UMaterialInterface Material,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float Scale=1.000000f,bool bScalePosition=false)
{
	CheckIsValid();
	DrawMaterialSimple(_this.Get(),Material,ScreenX,ScreenY,ScreenW,ScreenH,Scale,bScalePosition?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawMaterial(IntPtr _this,IntPtr Material,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float MaterialU,float MaterialV,float MaterialUWidth,float MaterialVHeight,float Scale,int bScalePosition,float Rotation,ref FVector2D RotPivot);
/// <summary>
/// Draws a material-textured quad on the HUD.
/// @param Material                      Material to use
/// @param ScreenX                       Screen-space X coordinate of upper left corner of the quad.
/// @param ScreenY                       Screen-space Y coordinate of upper left corner of the quad.
/// @param ScreenW                       Screen-space width of the quad (in pixels).
/// @param ScreenH                       Screen-space height of the quad (in pixels).
/// @param MaterialU                     Texture-space U coordinate of upper left corner of the quad
/// @param MaterialV                     Texture-space V coordinate of upper left corner of the quad.
/// @param MaterialUWidth        Texture-space width of the quad (in normalized UV distance).
/// @param MaterialVHeight       Texture-space height of the quad (in normalized UV distance).
/// @param Scale                         Amount to scale the entire texture (horizontally and vertically)
/// @param bScalePosition        Whether the "Scale" parameter should also scale the position of this draw call.
/// @param Rotation                      Amount to rotate this quad
/// @param RotPivot                      Location (as proportion of quad, 0-1) to rotate about
/// </summary>
public  void DrawMaterial(UMaterialInterface Material,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float MaterialU,float MaterialV,float MaterialUWidth,float MaterialVHeight,float Scale=1.000000f,bool bScalePosition=false,float Rotation=0.000000f,FVector2D RotPivot=default(FVector2D))
{
	CheckIsValid();
	DrawMaterial(_this.Get(),Material,ScreenX,ScreenY,ScreenW,ScreenH,MaterialU,MaterialV,MaterialUWidth,MaterialVHeight,Scale,bScalePosition?1:0,Rotation,ref RotPivot);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawTextureSimple(IntPtr _this,IntPtr Texture,float ScreenX,float ScreenY,float Scale,int bScalePosition);
/// <summary>
/// Draws a textured quad on the HUD. Assumes 1:1 texel density.
/// @param Texture                       Texture to draw.
/// @param ScreenX                       Screen-space X coordinate of upper left corner of the quad.
/// @param ScreenY                       Screen-space Y coordinate of upper left corner of the quad.
/// @param Scale                         Scale multiplier to control size of the text.
/// @param bScalePosition        Whether the "Scale" parameter should also scale the position of this draw call.
/// </summary>
public  void DrawTextureSimple(UTexture Texture,float ScreenX,float ScreenY,float Scale=1.000000f,bool bScalePosition=false)
{
	CheckIsValid();
	DrawTextureSimple(_this.Get(),Texture,ScreenX,ScreenY,Scale,bScalePosition?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawTexture(IntPtr _this,IntPtr Texture,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float TextureU,float TextureV,float TextureUWidth,float TextureVHeight,ref FLinearColor TintColor,int BlendMode,float Scale,int bScalePosition,float Rotation,ref FVector2D RotPivot);
/// <summary>
/// Draws a textured quad on the HUD.
/// @param Texture                       Texture to draw.
/// @param ScreenX                       Screen-space X coordinate of upper left corner of the quad.
/// @param ScreenY                       Screen-space Y coordinate of upper left corner of the quad.
/// @param ScreenW                       Screen-space width of the quad (in pixels).
/// @param ScreenH                       Screen-space height of the quad (in pixels).
/// @param TextureU                      Texture-space U coordinate of upper left corner of the quad
/// @param TextureV                      Texture-space V coordinate of upper left corner of the quad.
/// @param TextureUWidth         Texture-space width of the quad (in normalized UV distance).
/// @param TextureVHeight        Texture-space height of the quad (in normalized UV distance).
/// @param TintColor                     Vertex color for the quad.
/// @param BlendMode                     Controls how to blend this quad with the scene. Translucent by default.
/// @param Scale                         Amount to scale the entire texture (horizontally and vertically)
/// @param bScalePosition        Whether the "Scale" parameter should also scale the position of this draw call.
/// @param Rotation                      Amount to rotate this quad
/// @param RotPivot                      Location (as proportion of quad, 0-1) to rotate about
/// </summary>
public  void DrawTexture(UTexture Texture,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float TextureU,float TextureV,float TextureUWidth,float TextureVHeight,FLinearColor TintColor=default(FLinearColor),EBlendMode BlendMode=EBlendMode.BLEND_Translucent,float Scale=1.000000f,bool bScalePosition=false,float Rotation=0.000000f,FVector2D RotPivot=default(FVector2D))
{
	CheckIsValid();
	DrawTexture(_this.Get(),Texture,ScreenX,ScreenY,ScreenW,ScreenH,TextureU,TextureV,TextureUWidth,TextureVHeight,ref TintColor,(int)BlendMode,Scale,bScalePosition?1:0,Rotation,ref RotPivot);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawRect(IntPtr _this,ref FLinearColor RectColor,float ScreenX,float ScreenY,float ScreenW,float ScreenH);
/// <summary>
/// Draws a colored untextured quad on the HUD.
/// @param RectColor                     Color of the rect. Can be translucent.
/// @param ScreenX                       Screen-space X coordinate of upper left corner of the quad.
/// @param ScreenY                       Screen-space Y coordinate of upper left corner of the quad.
/// @param ScreenW                       Screen-space width of the quad (in pixels).
/// @param ScreenH                       Screen-space height of the quad (in pixels).
/// </summary>
public  void DrawRect(FLinearColor RectColor,float ScreenX,float ScreenY,float ScreenW,float ScreenH)
{
	CheckIsValid();
	DrawRect(_this.Get(),ref RectColor,ScreenX,ScreenY,ScreenW,ScreenH);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawLine(IntPtr _this,float StartScreenX,float StartScreenY,float EndScreenX,float EndScreenY,ref FLinearColor LineColor,float LineThickness);
/// <summary>
/// Draws a 2D line on the HUD.
/// @param StartScreenX          Screen-space X coordinate of start of the line.
/// @param StartScreenY          Screen-space Y coordinate of start of the line.
/// @param EndScreenX            Screen-space X coordinate of end of the line.
/// @param EndScreenY            Screen-space Y coordinate of end of the line.
/// @param LineColor                     Color to draw line
/// @param LineThickness         Thickness of the line to draw
/// </summary>
public  void DrawLine(float StartScreenX,float StartScreenY,float EndScreenX,float EndScreenY,FLinearColor LineColor,float LineThickness=0.000000f)
{
	CheckIsValid();
	DrawLine(_this.Get(),StartScreenX,StartScreenY,EndScreenX,EndScreenY,ref LineColor,LineThickness);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawText(IntPtr _this,string Text,ref FLinearColor TextColor,float ScreenX,float ScreenY,IntPtr Font,float Scale,int bScalePosition);
/// <summary>
/// Draws a string on the HUD.
/// @param Text                          String to draw
/// @param TextColor                     Color to draw string
/// @param ScreenX                       Screen-space X coordinate of upper left corner of the string.
/// @param ScreenY                       Screen-space Y coordinate of upper left corner of the string.
/// @param Font                          Font to draw text.  If NULL, default font is chosen.
/// @param Scale                         Scale multiplier to control size of the text.
/// @param bScalePosition        Whether the "Scale" parameter should also scale the position of this draw call.
/// </summary>
public  void DrawText(string Text,FLinearColor TextColor,float ScreenX,float ScreenY,UFont Font,float Scale=1.000000f,bool bScalePosition=false)
{
	CheckIsValid();
	DrawText(_this.Get(),Text,ref TextColor,ScreenX,ScreenY,Font,Scale,bScalePosition?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetTextSize(IntPtr _this,string Text,out float OutWidth,out float OutHeight,IntPtr Font,float Scale);
/// <summary>
/// Returns the width and height of a string.
/// @param Text                          String to draw
/// @param OutWidth                      Returns the width in pixels of the string.
/// @param OutHeight                     Returns the height in pixels of the string.
/// @param Font                          Font to draw text.  If NULL, default font is chosen.
/// @param Scale                         Scale multiplier to control size of the text.
/// </summary>
public  void GetTextSize(string Text,out float OutWidth,out float OutHeight,UFont Font,float Scale=1.000000f)
{
	CheckIsValid();
	GetTextSize(_this.Get(),Text,out OutWidth,out OutHeight,Font,Scale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RemoveDebugText(IntPtr _this,IntPtr SrcActor,int bLeaveDurationText);
/// <summary>
/// Remove debug strings for the given actor
/// @param       SrcActor                        Actor whose string you wish to remove
/// @param       bLeaveDurationText      when true text that has a finite duration will be removed, otherwise all will be removed for given actor
/// </summary>
public  void RemoveDebugText(AActor SrcActor,bool bLeaveDurationText)
{
	CheckIsValid();
	RemoveDebugText(_this.Get(),SrcActor,bLeaveDurationText?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RemoveAllDebugStrings(IntPtr _this);
/// <summary>Remove all debug strings added via AddDebugText</summary>
public  void RemoveAllDebugStrings()
{
	CheckIsValid();
	RemoveAllDebugStrings(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddDebugText(IntPtr _this,string DebugText,IntPtr SrcActor,float Duration,ref FVector Offset,ref FVector DesiredOffset,ref FColor TextColor,int bSkipOverwriteCheck,int bAbsoluteLocation,int bKeepAttachedToActor,IntPtr InFont,float FontScale,int bDrawShadow);
/// <summary>
/// Add debug text for a specific actor to be displayed via DrawDebugTextList().  If the debug text is invalid then it will
/// attempt to remove any previous entries via RemoveDebugText().
/// @param DebugText                             Text to draw
/// @param SrcActor                              Actor to which this relates
/// @param Duration                              Duration to display the string
/// @param Offset                                Initial offset to render text
/// @param DesiredOffset                 Desired offset to render text - the text will move to this location over the given duration
/// @param TextColor                     Color of text to render
/// @param bSkipOverwriteCheck   skips the check to see if there is already debug text for the given actor
/// @param bAbsoluteLocation     use an absolute world location
/// @param bKeepAttachedToActor  if this is true the text will follow the actor, otherwise it will be drawn at the location when the call was made
/// @param InFont                                font to use
/// @param FontScale                     scale
/// @param bDrawShadow                   Draw shadow on this string
/// </summary>
public  void AddDebugText(string DebugText,AActor SrcActor,float Duration,FVector Offset,FVector DesiredOffset,FColor TextColor,bool bSkipOverwriteCheck,bool bAbsoluteLocation,bool bKeepAttachedToActor,UFont InFont,float FontScale,bool bDrawShadow)
{
	CheckIsValid();
	AddDebugText(_this.Get(),DebugText,SrcActor,Duration,ref Offset,ref DesiredOffset,ref TextColor,bSkipOverwriteCheck?1:0,bAbsoluteLocation?1:0,bKeepAttachedToActor?1:0,InFont,FontScale,bDrawShadow?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ShowDebugForReticleTargetToggle(IntPtr _this,IntPtr DesiredClass);
/// <summary>Toggles 'ShowDebug' from showing debug info between reticle target actor (of subclass <DesiredClass>) and camera view target</summary>
public  void ShowDebugForReticleTargetToggle(TSubclassOf<AActor>  DesiredClass)
{
	CheckIsValid();
	ShowDebugForReticleTargetToggle(_this.Get(),DesiredClass.NativeClass);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ShowDebugToggleSubCategory(IntPtr _this,string Category);
/// <summary>Toggles sub categories of show debug to customize display</summary>
public  void ShowDebugToggleSubCategory(string Category)
{
	CheckIsValid();
	ShowDebugToggleSubCategory(_this.Get(),Category);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ShowDebug(IntPtr _this,string DebugType);
/// <summary>
/// Toggles displaying properties of player's current ViewTarget
/// DebugType input values supported by base engine include "AI", "physics", "net", "camera", and "collision"
/// </summary>
public  void ShowDebug(string DebugType="None")
{
	CheckIsValid();
	ShowDebug(_this.Get(),DebugType);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ShowHUD(IntPtr _this);
/// <summary>hides or shows HUD</summary>
public  void ShowHUD()
{
	CheckIsValid();
	ShowHUD(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
