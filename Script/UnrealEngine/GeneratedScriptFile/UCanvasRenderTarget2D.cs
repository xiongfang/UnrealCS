using System;
namespace UnrealEngine
{
	public partial class UCanvasRenderTarget2D:UTextureRenderTarget2D
	{
		/// <summary>
		/// Gets a specific render target's size from the global map of canvas render targets.
		/// @param       Width   Output variable for the render target's width
		/// @param       Height  Output variable for the render target's height
		/// </summary>
		public extern void GetSize(out int Width,out int Height);
		/// <summary>
		/// Creates a new canvas render target and initializes it to the specified dimensions
		/// @param       WorldContextObject      The world where this render target will be rendered for
		/// @param       CanvasRenderTarget2DClass       Class of the render target.  Unless you want to use a special sub-class, you can simply pass UCanvasRenderTarget2D::StaticClass() here.
		/// @param       Width                           Width of the render target.
		/// @param       Height                          Height of the render target.
		/// @return                                              Returns the instanced render target.
		/// </summary>
		public extern static UCanvasRenderTarget2D CreateCanvasRenderTarget2D(UObject WorldContextObject,TSubclassOf<UCanvasRenderTarget2D>  CanvasRenderTarget2DClass,int Width=1024,int Height=1024);
		/// <summary>
		/// Updates the the canvas render target texture's resource. This is where the render target will create or
		/// find a canvas object to use.  It also calls UpdateResourceImmediate() to clear the render target texture
		/// from the deferred rendering list, to stop the texture from being cleared the next frame. From there it
		/// will ask the rendering thread to set up the RHI viewport. The canvas is then set up for rendering and
		/// then the user's update delegate is called.  The canvas is then flushed and the RHI resolves the
		/// texture to make it available for rendering.
		/// </summary>
		public extern virtual void UpdateResource();
		/// <summary>
		/// If true, clear the render target to green whenever OnReceiveUpdate() is called.  (Defaults to true.)
		/// If false, the render target will retain whatever values it had, allowing the user to update only areas that
		/// have changed.
		/// </summary>
		public bool bShouldClearRenderTargetOnReceiveUpdate;
		
		
	}
	
}
