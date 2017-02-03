#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ALightmassPortal
	{
		static readonly int PortalComponent__Offset;
		public ULightmassPortalComponent PortalComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PortalComponent__Offset); if (v == IntPtr.Zero)return null; ULightmassPortalComponent retValue = new ULightmassPortalComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PortalComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PortalComponent__Offset, value._this.Get()); }
			
		}
		
		static ALightmassPortal()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("LightmassPortal");
			PortalComponent__Offset=GetPropertyOffset(NativeClassPtr,"PortalComponent");
			
		}
		
	}
	
}
#endif
#endif
