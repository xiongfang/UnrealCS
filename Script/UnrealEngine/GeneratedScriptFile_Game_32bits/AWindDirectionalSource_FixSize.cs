#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AWindDirectionalSource
	{
		static readonly int Component__Offset;
		public UWindDirectionalSourceComponent Component
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Component__Offset); if (v == IntPtr.Zero)return null; UWindDirectionalSourceComponent retValue = new UWindDirectionalSourceComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Component__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Component__Offset, value._this.Get()); }
			
		}
		
		static AWindDirectionalSource()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WindDirectionalSource");
			Component__Offset=GetPropertyOffset(NativeClassPtr,"Component");
			
		}
		
	}
	
}
#endif
#endif
