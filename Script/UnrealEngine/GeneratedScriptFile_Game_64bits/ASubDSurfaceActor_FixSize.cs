#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ASubDSurfaceActor
	{
		static readonly int SubDSurface__Offset;
		public USubDSurfaceComponent SubDSurface
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SubDSurface__Offset); if (v == IntPtr.Zero)return null; USubDSurfaceComponent retValue = new USubDSurfaceComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SubDSurface__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SubDSurface__Offset, value._this.Get()); }
			
		}
		
		static readonly int DisplayMeshComponent__Offset;
		public UStaticMeshComponent DisplayMeshComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DisplayMeshComponent__Offset); if (v == IntPtr.Zero)return null; UStaticMeshComponent retValue = new UStaticMeshComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + DisplayMeshComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + DisplayMeshComponent__Offset, value._this.Get()); }
			
		}
		
		static ASubDSurfaceActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SubDSurfaceActor");
			SubDSurface__Offset=GetPropertyOffset(NativeClassPtr,"SubDSurface");
			DisplayMeshComponent__Offset=GetPropertyOffset(NativeClassPtr,"DisplayMeshComponent");
			
		}
		
	}
	
}
#endif
#endif
