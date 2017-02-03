#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AAmbientSound
	{
		static readonly int AudioComponent__Offset;
		public UAudioComponent AudioComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AudioComponent__Offset); if (v == IntPtr.Zero)return null; UAudioComponent retValue = new UAudioComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + AudioComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + AudioComponent__Offset, value._this.Get()); }
			
		}
		
		static AAmbientSound()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AmbientSound");
			AudioComponent__Offset=GetPropertyOffset(NativeClassPtr,"AudioComponent");
			
		}
		
	}
	
}
#endif
#endif
