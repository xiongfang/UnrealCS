#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AVectorFieldVolume
	{
		static readonly int VectorFieldComponent__Offset;
		public UVectorFieldComponent VectorFieldComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VectorFieldComponent__Offset); if (v == IntPtr.Zero)return null; UVectorFieldComponent retValue = new UVectorFieldComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + VectorFieldComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + VectorFieldComponent__Offset, value._this.Get()); }
			
		}
		
		static AVectorFieldVolume()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("VectorFieldVolume");
			VectorFieldComponent__Offset=GetPropertyOffset(NativeClassPtr,"VectorFieldComponent");
			
		}
		
	}
	
}
#endif
#endif
