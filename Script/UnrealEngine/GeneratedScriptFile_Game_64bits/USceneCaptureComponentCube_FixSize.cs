#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USceneCaptureComponentCube
	{
		static readonly int TextureTarget__Offset;
		public UTextureRenderTargetCube TextureTarget
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TextureTarget__Offset); if (v == IntPtr.Zero)return null; UTextureRenderTargetCube retValue = new UTextureRenderTargetCube(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + TextureTarget__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + TextureTarget__Offset, value._this.Get()); }
			
		}
		
		static USceneCaptureComponentCube()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SceneCaptureComponentCube");
			TextureTarget__Offset=GetPropertyOffset(NativeClassPtr,"TextureTarget");
			
		}
		
	}
	
}
#endif
#endif
