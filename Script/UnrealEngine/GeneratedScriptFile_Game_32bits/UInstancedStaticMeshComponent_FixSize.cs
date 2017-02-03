#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInstancedStaticMeshComponent
	{
		static readonly int PerInstanceSMData__Offset;
		public TStructArray<FInstancedStaticMeshInstanceData> PerInstanceSMData
		{
			get{ CheckIsValid();return new TStructArray<FInstancedStaticMeshInstanceData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PerInstanceSMData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PerInstanceSMData__Offset, false);}
			
		}
		
		static readonly int InstancingRandomSeed__Offset;
		public int InstancingRandomSeed
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+InstancingRandomSeed__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InstancingRandomSeed__Offset, false);}
			
		}
		
		static readonly int InstanceStartCullDistance__Offset;
		public int InstanceStartCullDistance
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+InstanceStartCullDistance__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InstanceStartCullDistance__Offset, false);}
			
		}
		
		static readonly int InstanceEndCullDistance__Offset;
		public int InstanceEndCullDistance
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+InstanceEndCullDistance__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InstanceEndCullDistance__Offset, false);}
			
		}
		
		static readonly int InstanceReorderTable__Offset;
		public TStructArray<int> InstanceReorderTable
		{
			get{ CheckIsValid();return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InstanceReorderTable__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InstanceReorderTable__Offset, false);}
			
		}
		
		static readonly int RemovedInstances__Offset;
		public TStructArray<int> RemovedInstances
		{
			get{ CheckIsValid();return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(_this.Get()+RemovedInstances__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+RemovedInstances__Offset, false);}
			
		}
		
		static readonly int PhysicsSerializer__Offset;
		public UPhysicsSerializer PhysicsSerializer
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PhysicsSerializer__Offset); if (v == IntPtr.Zero)return null; UPhysicsSerializer retValue = new UPhysicsSerializer(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NumPendingLightmaps__Offset;
		public int NumPendingLightmaps
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumPendingLightmaps__Offset, typeof(int));}
			
		}
		
		static readonly int CachedMappings__Offset;
		public TStructArray<FInstancedStaticMeshMappingInfo> CachedMappings
		{
			get{ CheckIsValid();return new TStructArray<FInstancedStaticMeshMappingInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CachedMappings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CachedMappings__Offset, false);}
			
		}
		
		static UInstancedStaticMeshComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InstancedStaticMeshComponent");
			PerInstanceSMData__Offset=GetPropertyOffset(NativeClassPtr,"PerInstanceSMData");
			InstancingRandomSeed__Offset=GetPropertyOffset(NativeClassPtr,"InstancingRandomSeed");
			InstanceStartCullDistance__Offset=GetPropertyOffset(NativeClassPtr,"InstanceStartCullDistance");
			InstanceEndCullDistance__Offset=GetPropertyOffset(NativeClassPtr,"InstanceEndCullDistance");
			InstanceReorderTable__Offset=GetPropertyOffset(NativeClassPtr,"InstanceReorderTable");
			RemovedInstances__Offset=GetPropertyOffset(NativeClassPtr,"RemovedInstances");
			PhysicsSerializer__Offset=GetPropertyOffset(NativeClassPtr,"PhysicsSerializer");
			NumPendingLightmaps__Offset=GetPropertyOffset(NativeClassPtr,"NumPendingLightmaps");
			CachedMappings__Offset=GetPropertyOffset(NativeClassPtr,"CachedMappings");
			
		}
		
	}
	
}
#endif
#endif
