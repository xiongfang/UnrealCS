#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ALight
	{
		static readonly int LightComponent__Offset;
		public ULightComponent LightComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LightComponent__Offset); if (v == IntPtr.Zero)return null; ULightComponent retValue = new ULightComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + LightComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + LightComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int bEnabled__Offset;
		/// <summary>replicated copy of LightComponent's bEnabled property</summary>
		public bool bEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnabled__Offset, 1, 0, 1, 1);}
			
		}
		
		static ALight()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Light");
			LightComponent__Offset=GetPropertyOffset(NativeClassPtr,"LightComponent");
			bEnabled__Offset=GetPropertyOffset(NativeClassPtr,"bEnabled");
			
		}
		
	}
	
}
#endif
#endif
