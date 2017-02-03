using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCanvasRenderTarget2D:UTextureRenderTarget2D 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetSize(IntPtr _this,out int Width,out int Height);
/// <summary>
/// Gets a specific render target's size from the global map of canvas render targets.
/// @param       Width   Output variable for the render target's width
/// @param       Height  Output variable for the render target's height
/// </summary>
public  void GetSize(out int Width,out int Height)
{
	CheckIsValid();
	GetSize(_this.Get(),out Width,out Height);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr CreateCanvasRenderTarget2D(IntPtr _this,IntPtr WorldContextObject,IntPtr CanvasRenderTarget2DClass,int Width,int Height);
/// <summary>
/// Creates a new canvas render target and initializes it to the specified dimensions
/// @param       WorldContextObject      The world where this render target will be rendered for
/// @param       CanvasRenderTarget2DClass       Class of the render target.  Unless you want to use a special sub-class, you can simply pass UCanvasRenderTarget2D::StaticClass() here.
/// @param       Width                           Width of the render target.
/// @param       Height                          Height of the render target.
/// @return                                              Returns the instanced render target.
/// </summary>
public static UCanvasRenderTarget2D CreateCanvasRenderTarget2D(UObject WorldContextObject,TSubclassOf<UCanvasRenderTarget2D>  CanvasRenderTarget2DClass,int Width=1024,int Height=1024)
{
	IntPtr ___ret = CreateCanvasRenderTarget2D(IntPtr.Zero,WorldContextObject,CanvasRenderTarget2DClass.NativeClass,Width,Height);
	if(___ret==IntPtr.Zero) return null; UCanvasRenderTarget2D ___ret2= new UCanvasRenderTarget2D(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void UpdateResource(IntPtr _this);
/// <summary>
/// Updates the the canvas render target texture's resource. This is where the render target will create or
/// find a canvas object to use.  It also calls UpdateResourceImmediate() to clear the render target texture
/// from the deferred rendering list, to stop the texture from being cleared the next frame. From there it
/// will ask the rendering thread to set up the RHI viewport. The canvas is then set up for rendering and
/// then the user's update delegate is called.  The canvas is then flushed and the RHI resolves the
/// texture to make it available for rendering.
/// </summary>
public  void UpdateResource()
{
	CheckIsValid();
	UpdateResource(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
