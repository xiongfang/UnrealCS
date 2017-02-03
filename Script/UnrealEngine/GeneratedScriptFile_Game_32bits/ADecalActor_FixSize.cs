#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ADecalActor
	{
		static readonly int Decal__Offset;
		public UDecalComponent Decal
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Decal__Offset); if (v == IntPtr.Zero)return null; UDecalComponent retValue = new UDecalComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Decal__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Decal__Offset, value._this.Get()); }
			
		}
		
		static ADecalActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DecalActor");
			Decal__Offset=GetPropertyOffset(NativeClassPtr,"Decal");
			
		}
		
	}
	
}
#endif
#endif
