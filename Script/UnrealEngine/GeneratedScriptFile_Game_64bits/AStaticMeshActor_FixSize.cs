#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AStaticMeshActor
	{
		static readonly int StaticMeshComponent__Offset;
		public UStaticMeshComponent StaticMeshComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + StaticMeshComponent__Offset); if (v == IntPtr.Zero)return null; UStaticMeshComponent retValue = new UStaticMeshComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + StaticMeshComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + StaticMeshComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int bStaticMeshReplicateMovement__Offset;
		public bool bStaticMeshReplicateMovement
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStaticMeshReplicateMovement__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bStaticMeshReplicateMovement__Offset, 1,0,1,255);}
			
		}
		
		static readonly int NavigationGeometryGatheringMode__Offset;
		public ENavDataGatheringMode NavigationGeometryGatheringMode
		{
			get{ CheckIsValid();return (ENavDataGatheringMode)Marshal.PtrToStructure(_this.Get()+NavigationGeometryGatheringMode__Offset, typeof(ENavDataGatheringMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NavigationGeometryGatheringMode__Offset, false);}
			
		}
		
		static AStaticMeshActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("StaticMeshActor");
			StaticMeshComponent__Offset=GetPropertyOffset(NativeClassPtr,"StaticMeshComponent");
			bStaticMeshReplicateMovement__Offset=GetPropertyOffset(NativeClassPtr,"bStaticMeshReplicateMovement");
			NavigationGeometryGatheringMode__Offset=GetPropertyOffset(NativeClassPtr,"NavigationGeometryGatheringMode");
			
		}
		
	}
	
}
#endif
#endif
