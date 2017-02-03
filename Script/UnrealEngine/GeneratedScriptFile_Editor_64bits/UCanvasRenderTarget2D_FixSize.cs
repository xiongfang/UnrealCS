#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// CanvasRenderTarget2D is 2D render target which exposes a Canvas interface to allow you to draw elements onto
	/// it directly.  Use FindCanvasRenderTarget2D() to find or create a render target texture by unique name, then
	/// bind a function to the OnCanvasRenderTargetUpdate delegate which will be called when the render target is
	/// updated.  If you need to repaint your canvas every single frame, simply call UpdateResource() on it from a Tick
	/// function.  Also, remember to hold onto your new canvas render target with a reference so that it doesn't get
	/// garbage collected.
	/// </summary>
	public partial class UCanvasRenderTarget2D
	{
		static readonly int OnCanvasRenderTargetUpdate__Offset;
		/// <summary>Called when this Canvas Render Target is asked to update its texture resource.</summary>
		public FMulticastScriptDelegate OnCanvasRenderTargetUpdate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnCanvasRenderTargetUpdate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnCanvasRenderTargetUpdate__Offset, false);}
			
		}
		
		static readonly int bShouldClearRenderTargetOnReceiveUpdate__Offset;
		/// <summary>
		/// If true, clear the render target to green whenever OnReceiveUpdate() is called.  (Defaults to true.)
		/// If false, the render target will retain whatever values it had, allowing the user to update only areas that
		/// have changed.
		/// </summary>
		public bool bShouldClearRenderTargetOnReceiveUpdate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldClearRenderTargetOnReceiveUpdate__Offset, 1, 0, 1, 255);}
			
		}
		
		static UCanvasRenderTarget2D()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CanvasRenderTarget2D");
			OnCanvasRenderTargetUpdate__Offset=GetPropertyOffset(NativeClassPtr,"OnCanvasRenderTargetUpdate");
			bShouldClearRenderTargetOnReceiveUpdate__Offset=GetPropertyOffset(NativeClassPtr,"bShouldClearRenderTargetOnReceiveUpdate");
			
		}
		
	}
	
}
#endif
#endif
