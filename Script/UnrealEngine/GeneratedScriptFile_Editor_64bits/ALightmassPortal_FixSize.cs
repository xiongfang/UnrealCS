#if WITH_EDITOR
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
		
		static readonly int SpriteComponent__Offset;
		public UBillboardComponent SpriteComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpriteComponent__Offset); if (v == IntPtr.Zero)return null; UBillboardComponent retValue = new UBillboardComponent(); retValue._this = v; return retValue; }
			
		}
		
		static ALightmassPortal()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("LightmassPortal");
			PortalComponent__Offset=GetPropertyOffset(NativeClassPtr,"PortalComponent");
			SpriteComponent__Offset=GetPropertyOffset(NativeClassPtr,"SpriteComponent");
			
		}
		
	}
	
}
#endif
#endif
