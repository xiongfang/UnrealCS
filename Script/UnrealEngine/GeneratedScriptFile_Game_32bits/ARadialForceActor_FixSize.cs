#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ARadialForceActor
	{
		static readonly int ForceComponent__Offset;
		public URadialForceComponent ForceComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ForceComponent__Offset); if (v == IntPtr.Zero)return null; URadialForceComponent retValue = new URadialForceComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ForceComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ForceComponent__Offset, value._this.Get()); }
			
		}
		
		static ARadialForceActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("RadialForceActor");
			ForceComponent__Offset=GetPropertyOffset(NativeClassPtr,"ForceComponent");
			
		}
		
	}
	
}
#endif
#endif
