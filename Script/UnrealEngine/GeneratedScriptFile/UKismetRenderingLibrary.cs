using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UKismetRenderingLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void EndDrawCanvasToRenderTarget(IntPtr _this,IntPtr WorldContextObject,ref FDrawToRenderTargetContext Context);
/// <summary>Must be paired with a BeginDrawCanvasToRenderTarget to complete rendering to a render target.</summary>
public static void EndDrawCanvasToRenderTarget(UObject WorldContextObject,FDrawToRenderTargetContext Context)
{
	EndDrawCanvasToRenderTarget(IntPtr.Zero,WorldContextObject,ref Context);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BeginDrawCanvasToRenderTarget(IntPtr _this,IntPtr WorldContextObject,IntPtr TextureRenderTarget,out IntPtr Canvas,out FVector2D Size,out FDrawToRenderTargetContext Context);
/// <summary>
/// Returns a Canvas object that can be used to draw to the specified render target.
/// Canvas has functions like DrawMaterial with size parameters that can be used to draw to a specific area of a render target.
/// Be sure to call EndDrawCanvasToRenderTarget to complete the rendering!
/// </summary>
public static void BeginDrawCanvasToRenderTarget(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,out UCanvas Canvas,out FVector2D Size,out FDrawToRenderTargetContext Context)
{
	IntPtr Canvas_temp;
	BeginDrawCanvasToRenderTarget(IntPtr.Zero,WorldContextObject,TextureRenderTarget,out Canvas_temp,out Size,out Context);
	Canvas=new UCanvas(){ _this=Canvas_temp};
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ExportTexture2D(IntPtr _this,IntPtr WorldContextObject,IntPtr Texture,string FilePath,string FileName);
/// <summary>Exports a Texture2D as a HDR image onto the disk.</summary>
public static void ExportTexture2D(UObject WorldContextObject,UTexture2D Texture,string FilePath,string FileName)
{
	ExportTexture2D(IntPtr.Zero,WorldContextObject,Texture,FilePath,FileName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ExportRenderTarget(IntPtr _this,IntPtr WorldContextObject,IntPtr TextureRenderTarget,string FilePath,string FileName);
/// <summary>Exports a render target as a HDR image onto the disk.</summary>
public static void ExportRenderTarget(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,string FilePath,string FileName)
{
	ExportRenderTarget(IntPtr.Zero,WorldContextObject,TextureRenderTarget,FilePath,FileName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawMaterialToRenderTarget(IntPtr _this,IntPtr WorldContextObject,IntPtr TextureRenderTarget,IntPtr Material);
/// <summary>
/// Renders a quad with the material applied to the specified render target.
/// This sets the render target even if it is already set, which is an expensive operation.
/// Use BeginDrawCanvasToRenderTarget / EndDrawCanvasToRenderTarget instead if rendering multiple primitives to the same render target.
/// </summary>
public static void DrawMaterialToRenderTarget(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,UMaterialInterface Material)
{
	DrawMaterialToRenderTarget(IntPtr.Zero,WorldContextObject,TextureRenderTarget,Material);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr CreateRenderTarget2D(IntPtr _this,IntPtr WorldContextObject,int Width,int Height);
/// <summary>Creates a new render target and initializes it to the specified dimensions</summary>
public static UTextureRenderTarget2D CreateRenderTarget2D(UObject WorldContextObject,int Width=256,int Height=256)
{
	IntPtr ___ret = CreateRenderTarget2D(IntPtr.Zero,WorldContextObject,Width,Height);
	if(___ret==IntPtr.Zero) return null; UTextureRenderTarget2D ___ret2= new UTextureRenderTarget2D(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearRenderTarget2D(IntPtr _this,IntPtr WorldContextObject,IntPtr TextureRenderTarget,ref FLinearColor ClearColor);
/// <summary>Clears the specified render target with the given ClearColor.</summary>
public static void ClearRenderTarget2D(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,FLinearColor ClearColor)
{
	ClearRenderTarget2D(IntPtr.Zero,WorldContextObject,TextureRenderTarget,ref ClearColor);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
