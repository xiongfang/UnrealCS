#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ASceneCapture2D
	{
		static readonly int CaptureComponent2D__Offset;
		public USceneCaptureComponent2D CaptureComponent2D
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CaptureComponent2D__Offset); if (v == IntPtr.Zero)return null; USceneCaptureComponent2D retValue = new USceneCaptureComponent2D(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + CaptureComponent2D__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + CaptureComponent2D__Offset, value._this.Get()); }
			
		}
		
		static readonly int DrawFrustum__Offset;
		public UDrawFrustumComponent DrawFrustum
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DrawFrustum__Offset); if (v == IntPtr.Zero)return null; UDrawFrustumComponent retValue = new UDrawFrustumComponent(); retValue._this = v; return retValue; }
			
		}
		
		static ASceneCapture2D()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SceneCapture2D");
			CaptureComponent2D__Offset=GetPropertyOffset(NativeClassPtr,"CaptureComponent2D");
			DrawFrustum__Offset=GetPropertyOffset(NativeClassPtr,"DrawFrustum");
			
		}
		
	}
	
}
#endif
#endif
