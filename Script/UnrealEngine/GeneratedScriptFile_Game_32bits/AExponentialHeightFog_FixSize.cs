#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AExponentialHeightFog
	{
		static readonly int Component__Offset;
		public UExponentialHeightFogComponent Component
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Component__Offset); if (v == IntPtr.Zero)return null; UExponentialHeightFogComponent retValue = new UExponentialHeightFogComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Component__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Component__Offset, value._this.Get()); }
			
		}
		
		static readonly int bEnabled__Offset;
		public bool bEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnabled__Offset, 1, 0, 1, 1);}
			
		}
		
		static AExponentialHeightFog()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ExponentialHeightFog");
			Component__Offset=GetPropertyOffset(NativeClassPtr,"Component");
			bEnabled__Offset=GetPropertyOffset(NativeClassPtr,"bEnabled");
			
		}
		
	}
	
}
#endif
#endif
