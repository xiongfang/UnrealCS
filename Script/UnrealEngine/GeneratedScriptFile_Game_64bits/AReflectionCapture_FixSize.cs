#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AReflectionCapture
	{
		static readonly int CaptureComponent__Offset;
		public UReflectionCaptureComponent CaptureComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CaptureComponent__Offset); if (v == IntPtr.Zero)return null; UReflectionCaptureComponent retValue = new UReflectionCaptureComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + CaptureComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + CaptureComponent__Offset, value._this.Get()); }
			
		}
		
		static AReflectionCapture()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ReflectionCapture");
			CaptureComponent__Offset=GetPropertyOffset(NativeClassPtr,"CaptureComponent");
			
		}
		
	}
	
}
#endif
#endif
