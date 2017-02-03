#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Subdivision Surface Component (Experimental, Early work in progress)</summary>
	public partial class USubDSurfaceComponent
	{
		static readonly int Mesh__Offset;
		public USubDSurface Mesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Mesh__Offset); if (v == IntPtr.Zero)return null; USubDSurface retValue = new USubDSurface(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Mesh__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Mesh__Offset, value._this.Get()); }
			
		}
		
		static readonly int DebugLevel__Offset;
		/// <summary>Refinement Level of the SubD mesh</summary>
		public int DebugLevel
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+DebugLevel__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DebugLevel__Offset, false);}
			
		}
		
		static readonly int DisplayMeshComponent__Offset;
		public UStaticMeshComponent DisplayMeshComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DisplayMeshComponent__Offset); if (v == IntPtr.Zero)return null; UStaticMeshComponent retValue = new UStaticMeshComponent(); retValue._this = v; return retValue; }
			
		}
		
		static USubDSurfaceComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SubDSurfaceComponent");
			Mesh__Offset=GetPropertyOffset(NativeClassPtr,"Mesh");
			DebugLevel__Offset=GetPropertyOffset(NativeClassPtr,"DebugLevel");
			DisplayMeshComponent__Offset=GetPropertyOffset(NativeClassPtr,"DisplayMeshComponent");
			
		}
		
	}
	
}
#endif
#endif
