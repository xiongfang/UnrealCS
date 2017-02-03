#if WITH_EDITOR
#if PLATFORM_64BITS
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
		
		static readonly int SpriteComponent__Offset;
		public UBillboardComponent SpriteComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpriteComponent__Offset); if (v == IntPtr.Zero)return null; UBillboardComponent retValue = new UBillboardComponent(); retValue._this = v; return retValue; }
			
		}
		
		static ARadialForceActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("RadialForceActor");
			ForceComponent__Offset=GetPropertyOffset(NativeClassPtr,"ForceComponent");
			SpriteComponent__Offset=GetPropertyOffset(NativeClassPtr,"SpriteComponent");
			
		}
		
	}
	
}
#endif
#endif
