using System;
namespace UnrealEngine
{
	public partial class AHUD:AActor
	{
		/// <summary>
		/// Add a hitbox to the hud
		/// @param Position                      Coordinates of the top left of the hit box.
		/// @param Size                          Size of the hit box.
		/// @param Name                          Name of the hit box.
		/// @param bConsumesInput        Whether click processing should continue if this hit box is clicked.
		/// @param Priority                      The priority of the box used for layering. Larger values are considered first.  Equal values are considered in the order they were added.
		/// </summary>
		public extern void AddHitBox(FVector2D Position,FVector2D Size,FName InName,bool bConsumesInput,int Priority=0);
		/// <summary>Transforms a 2D screen location into a 3D location and direction</summary>
		public extern void Deproject(float ScreenX,float ScreenY,out FVector WorldPosition,out FVector WorldDirection);
		/// <summary>Transforms a 3D world-space vector into 2D screen coordinates</summary>
		public extern FVector Project(FVector Location);
		public extern void DrawMaterialTriangle(UMaterialInterface Material,FVector2D V0_Pos,FVector2D V1_Pos,FVector2D V2_Pos,FVector2D V0_UV,FVector2D V1_UV,FVector2D V2_UV,FLinearColor V0_Color=default(FLinearColor),FLinearColor V1_Color=default(FLinearColor),FLinearColor V2_Color=default(FLinearColor));
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
		public extern void DrawMaterialSimple(UMaterialInterface Material,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float Scale=1.000000f,bool bScalePosition=false);
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
		public extern void DrawMaterial(UMaterialInterface Material,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float MaterialU,float MaterialV,float MaterialUWidth,float MaterialVHeight,float Scale=1.000000f,bool bScalePosition=false,float Rotation=0.000000f,FVector2D RotPivot=default(FVector2D));
		/// <summary>
		/// Draws a textured quad on the HUD. Assumes 1:1 texel density.
		/// @param Texture                       Texture to draw.
		/// @param ScreenX                       Screen-space X coordinate of upper left corner of the quad.
		/// @param ScreenY                       Screen-space Y coordinate of upper left corner of the quad.
		/// @param Scale                         Scale multiplier to control size of the text.
		/// @param bScalePosition        Whether the "Scale" parameter should also scale the position of this draw call.
		/// </summary>
		public extern void DrawTextureSimple(UTexture Texture,float ScreenX,float ScreenY,float Scale=1.000000f,bool bScalePosition=false);
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
		public extern void DrawTexture(UTexture Texture,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float TextureU,float TextureV,float TextureUWidth,float TextureVHeight,FLinearColor TintColor=default(FLinearColor),EBlendMode BlendMode=EBlendMode.BLEND_Translucent,float Scale=1.000000f,bool bScalePosition=false,float Rotation=0.000000f,FVector2D RotPivot=default(FVector2D));
		/// <summary>
		/// Draws a colored untextured quad on the HUD.
		/// @param RectColor                     Color of the rect. Can be translucent.
		/// @param ScreenX                       Screen-space X coordinate of upper left corner of the quad.
		/// @param ScreenY                       Screen-space Y coordinate of upper left corner of the quad.
		/// @param ScreenW                       Screen-space width of the quad (in pixels).
		/// @param ScreenH                       Screen-space height of the quad (in pixels).
		/// </summary>
		public extern void DrawRect(FLinearColor RectColor,float ScreenX,float ScreenY,float ScreenW,float ScreenH);
		/// <summary>
		/// Draws a 2D line on the HUD.
		/// @param StartScreenX          Screen-space X coordinate of start of the line.
		/// @param StartScreenY          Screen-space Y coordinate of start of the line.
		/// @param EndScreenX            Screen-space X coordinate of end of the line.
		/// @param EndScreenY            Screen-space Y coordinate of end of the line.
		/// @param LineColor                     Color to draw line
		/// @param LineThickness         Thickness of the line to draw
		/// </summary>
		public extern void DrawLine(float StartScreenX,float StartScreenY,float EndScreenX,float EndScreenY,FLinearColor LineColor,float LineThickness=0.000000f);
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
		public extern void DrawText(FString Text,FLinearColor TextColor,float ScreenX,float ScreenY,UFont Font,float Scale=1.000000f,bool bScalePosition=false);
		/// <summary>
		/// Returns the width and height of a string.
		/// @param Text                          String to draw
		/// @param OutWidth                      Returns the width in pixels of the string.
		/// @param OutHeight                     Returns the height in pixels of the string.
		/// @param Font                          Font to draw text.  If NULL, default font is chosen.
		/// @param Scale                         Scale multiplier to control size of the text.
		/// </summary>
		public extern void GetTextSize(FString Text,out float OutWidth,out float OutHeight,UFont Font,float Scale=1.000000f);
		/// <summary>
		/// Remove debug strings for the given actor
		/// @param       SrcActor                        Actor whose string you wish to remove
		/// @param       bLeaveDurationText      when true text that has a finite duration will be removed, otherwise all will be removed for given actor
		/// </summary>
		public extern void RemoveDebugText(AActor SrcActor,bool bLeaveDurationText);
		/// <summary>Remove all debug strings added via AddDebugText</summary>
		public extern void RemoveAllDebugStrings();
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
		public extern void AddDebugText(FString DebugText,AActor SrcActor,float Duration,FVector Offset,FVector DesiredOffset,FColor TextColor,bool bSkipOverwriteCheck,bool bAbsoluteLocation,bool bKeepAttachedToActor,UFont InFont,float FontScale,bool bDrawShadow);
		/// <summary>Toggles 'ShowDebug' from showing debug info between reticle target actor (of subclass <DesiredClass>) and camera view target</summary>
		public extern void ShowDebugForReticleTargetToggle(TSubclassOf<AActor>  DesiredClass);
		/// <summary>Toggles sub categories of show debug to customize display</summary>
		public extern void ShowDebugToggleSubCategory(FName Category);
		/// <summary>
		/// Toggles displaying properties of player's current ViewTarget
		/// DebugType input values supported by base engine include "AI", "physics", "net", "camera", and "collision"
		/// </summary>
		public extern virtual void ShowDebug(FName DebugType);
		/// <summary>hides or shows HUD</summary>
		public extern virtual void ShowHUD();
		/// <summary>PlayerController which owns this HUD.</summary>
		public APlayerController PlayerOwner;
		
		/// <summary>Tells whether the game was paused due to lost focus</summary>
		public bool bLostFocusPaused;
		
		/// <summary>Whether or not the HUD should be drawn.</summary>
		public bool bShowHUD;
		
		/// <summary>If true, current ViewTarget shows debug information using its DisplayDebug().</summary>
		public bool bShowDebugInfo;
		
		/// <summary>If true, show hitbox debugging info.</summary>
		public bool bShowHitBoxDebugInfo;
		
		/// <summary>If true, render actor overlays.</summary>
		public bool bShowOverlays;
		
		/// <summary>Put shadow on debug strings</summary>
		public bool bEnableDebugTextShadow;
		
		/// <summary>Canvas to Draw HUD on.  Only valid during PostRender() event.</summary>
		public UCanvas Canvas;
		
		/// <summary>'Foreground' debug canvas, will draw in front of Slate UI.</summary>
		public UCanvas DebugCanvas;
		
		/// <summary>Class filter for selecting 'ShowDebugTargetActor' when 'bShowDebugForReticleTarget' is true.</summary>
		public TSubclassOf<AActor>  ShowDebugTargetDesiredClass;
		
		/// <summary>Show Debug Actor used if 'bShowDebugForReticleTarget' is true, only updated if trace from reticle hit a new Actor of class 'ShowDebugTargetDesiredClass'</summary>
		public AActor ShowDebugTargetActor;
		
		
	}
	
}
