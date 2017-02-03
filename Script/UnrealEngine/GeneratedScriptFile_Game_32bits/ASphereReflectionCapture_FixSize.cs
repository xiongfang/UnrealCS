#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ASphereReflectionCapture
	{
		static readonly int DrawCaptureRadius__Offset;
		public UDrawSphereComponent DrawCaptureRadius
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DrawCaptureRadius__Offset); if (v == IntPtr.Zero)return null; UDrawSphereComponent retValue = new UDrawSphereComponent(); retValue._this = v; return retValue; }
			
		}
		
		static ASphereReflectionCapture()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SphereReflectionCapture");
			DrawCaptureRadius__Offset=GetPropertyOffset(NativeClassPtr,"DrawCaptureRadius");
			
		}
		
	}
	
}
#endif
#endif
