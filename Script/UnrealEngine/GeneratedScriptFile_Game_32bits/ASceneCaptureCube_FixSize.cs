#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ASceneCaptureCube
	{
		static readonly int CaptureComponentCube__Offset;
		public USceneCaptureComponentCube CaptureComponentCube
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CaptureComponentCube__Offset); if (v == IntPtr.Zero)return null; USceneCaptureComponentCube retValue = new USceneCaptureComponentCube(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + CaptureComponentCube__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + CaptureComponentCube__Offset, value._this.Get()); }
			
		}
		
		static readonly int DrawFrustum__Offset;
		public UDrawFrustumComponent DrawFrustum
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DrawFrustum__Offset); if (v == IntPtr.Zero)return null; UDrawFrustumComponent retValue = new UDrawFrustumComponent(); retValue._this = v; return retValue; }
			
		}
		
		static ASceneCaptureCube()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SceneCaptureCube");
			CaptureComponentCube__Offset=GetPropertyOffset(NativeClassPtr,"CaptureComponentCube");
			DrawFrustum__Offset=GetPropertyOffset(NativeClassPtr,"DrawFrustum");
			
		}
		
	}
	
}
#endif
#endif
