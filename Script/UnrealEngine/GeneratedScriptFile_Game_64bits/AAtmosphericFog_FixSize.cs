#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AAtmosphericFog
	{
		static readonly int AtmosphericFogComponent__Offset;
		public UAtmosphericFogComponent AtmosphericFogComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AtmosphericFogComponent__Offset); if (v == IntPtr.Zero)return null; UAtmosphericFogComponent retValue = new UAtmosphericFogComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + AtmosphericFogComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + AtmosphericFogComponent__Offset, value._this.Get()); }
			
		}
		
		static AAtmosphericFog()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AtmosphericFog");
			AtmosphericFogComponent__Offset=GetPropertyOffset(NativeClassPtr,"AtmosphericFogComponent");
			
		}
		
	}
	
}
#endif
#endif
