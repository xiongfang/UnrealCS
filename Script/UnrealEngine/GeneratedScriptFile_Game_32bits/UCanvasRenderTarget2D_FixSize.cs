#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UCanvasRenderTarget2D
	{
		static readonly int OnCanvasRenderTargetUpdate__Offset;
		public FMulticastScriptDelegate OnCanvasRenderTargetUpdate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnCanvasRenderTargetUpdate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnCanvasRenderTargetUpdate__Offset, false);}
			
		}
		
		static readonly int bShouldClearRenderTargetOnReceiveUpdate__Offset;
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
