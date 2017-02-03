#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ASubDSurfaceActor
	{
		static readonly int SubDSurface__Offset;
		/// <summary>Component to render the actor, used GetSubDSurface() to access</summary>
		public USubDSurfaceComponent SubDSurface
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SubDSurface__Offset); if (v == IntPtr.Zero)return null; USubDSurfaceComponent retValue = new USubDSurfaceComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SubDSurface__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SubDSurface__Offset, value._this.Get()); }
			
		}
		
		static readonly int DisplayMeshComponent__Offset;
		/// <summary>later this all will be done by USubDSurfaceComponent</summary>
		public UStaticMeshComponent DisplayMeshComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DisplayMeshComponent__Offset); if (v == IntPtr.Zero)return null; UStaticMeshComponent retValue = new UStaticMeshComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + DisplayMeshComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + DisplayMeshComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int SpriteComponent__Offset;
		/// <summary>Reference to the billboard component</summary>
		public UBillboardComponent SpriteComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpriteComponent__Offset); if (v == IntPtr.Zero)return null; UBillboardComponent retValue = new UBillboardComponent(); retValue._this = v; return retValue; }
			
		}
		
		static ASubDSurfaceActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SubDSurfaceActor");
			SubDSurface__Offset=GetPropertyOffset(NativeClassPtr,"SubDSurface");
			DisplayMeshComponent__Offset=GetPropertyOffset(NativeClassPtr,"DisplayMeshComponent");
			SpriteComponent__Offset=GetPropertyOffset(NativeClassPtr,"SpriteComponent");
			
		}
		
	}
	
}
#endif
#endif
