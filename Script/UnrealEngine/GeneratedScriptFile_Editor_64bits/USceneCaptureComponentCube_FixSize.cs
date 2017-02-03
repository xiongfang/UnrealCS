#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Used to capture a 'snapshot' of the scene from a 6 planes and feed it to a render target.</summary>
	public partial class USceneCaptureComponentCube
	{
		static readonly int TextureTarget__Offset;
		/// <summary>Temporary render target that can be used by the editor.</summary>
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
