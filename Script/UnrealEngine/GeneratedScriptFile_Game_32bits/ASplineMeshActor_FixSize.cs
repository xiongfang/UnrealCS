#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ASplineMeshActor
	{
		static readonly int SplineMeshComponent__Offset;
		public USplineMeshComponent SplineMeshComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SplineMeshComponent__Offset); if (v == IntPtr.Zero)return null; USplineMeshComponent retValue = new USplineMeshComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SplineMeshComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SplineMeshComponent__Offset, value._this.Get()); }
			
		}
		
		static ASplineMeshActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SplineMeshActor");
			SplineMeshComponent__Offset=GetPropertyOffset(NativeClassPtr,"SplineMeshComponent");
			
		}
		
	}
	
}
#endif
#endif
