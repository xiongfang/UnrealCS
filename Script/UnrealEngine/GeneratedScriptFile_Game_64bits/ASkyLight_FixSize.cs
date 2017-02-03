#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ASkyLight
	{
		static readonly int LightComponent__Offset;
		public USkyLightComponent LightComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LightComponent__Offset); if (v == IntPtr.Zero)return null; USkyLightComponent retValue = new USkyLightComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + LightComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + LightComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int bEnabled__Offset;
		public bool bEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnabled__Offset, 1, 0, 1, 1);}
			
		}
		
		static ASkyLight()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SkyLight");
			LightComponent__Offset=GetPropertyOffset(NativeClassPtr,"LightComponent");
			bEnabled__Offset=GetPropertyOffset(NativeClassPtr,"bEnabled");
			
		}
		
	}
	
}
#endif
#endif
