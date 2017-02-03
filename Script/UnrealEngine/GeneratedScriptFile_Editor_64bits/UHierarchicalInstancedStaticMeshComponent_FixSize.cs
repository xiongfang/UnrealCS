#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UHierarchicalInstancedStaticMeshComponent
	{
		static readonly int SortedInstances__Offset;
		/// <summary>Table for remaping instances from cluster tree to PerInstanceSMData order</summary>
		public TStructArray<int> SortedInstances
		{
			get{ CheckIsValid();return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SortedInstances__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SortedInstances__Offset, false);}
			
		}
		
		static readonly int NumBuiltInstances__Offset;
		/// <summary>The number of instances in the ClusterTree. Subsequent instances will always be rendered.</summary>
		public int NumBuiltInstances
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumBuiltInstances__Offset, typeof(int));}
			
		}
		
		static readonly int BuiltInstanceBounds__Offset;
		/// <summary>Bounding box of any built instances (cached from the ClusterTree)</summary>
		public FBox BuiltInstanceBounds
		{
			get{ CheckIsValid();return (FBox)Marshal.PtrToStructure(_this.Get()+BuiltInstanceBounds__Offset, typeof(FBox));}
			
		}
		
		static readonly int UnbuiltInstanceBounds__Offset;
		/// <summary>Bounding box of any unbuilt instances</summary>
		public FBox UnbuiltInstanceBounds
		{
			get{ CheckIsValid();return (FBox)Marshal.PtrToStructure(_this.Get()+UnbuiltInstanceBounds__Offset, typeof(FBox));}
			
		}
		
		static readonly int UnbuiltInstanceBoundsList__Offset;
		/// <summary>Bounds of each individual unbuilt instance, used for LOD calculation</summary>
		public TStructArray<FBox> UnbuiltInstanceBoundsList
		{
			get{ CheckIsValid();return new TStructArray<FBox>((FScriptArray)Marshal.PtrToStructure(_this.Get()+UnbuiltInstanceBoundsList__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+UnbuiltInstanceBoundsList__Offset, false);}
			
		}
		
		static readonly int bEnableDensityScaling__Offset;
		/// <summary>
		/// Enable for detail meshes that don't really affect the game. Disable for anything important.
		/// Typically, this will be enabled for small meshes without collision (e.g. grass) and disabled for large meshes with collision (e.g. trees)
		/// </summary>
		public bool bEnableDensityScaling
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableDensityScaling__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int OcclusionLayerNumNodes__Offset;
		/// <summary>The number of nodes in the occlusion layer</summary>
		public int OcclusionLayerNumNodes
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+OcclusionLayerNumNodes__Offset, typeof(int));}
			
		}
		
		static readonly int bDisableCollision__Offset;
		public bool bDisableCollision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableCollision__Offset, 1, 0, 1, 255);}
			
		}
		
		static UHierarchicalInstancedStaticMeshComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("HierarchicalInstancedStaticMeshComponent");
			SortedInstances__Offset=GetPropertyOffset(NativeClassPtr,"SortedInstances");
			NumBuiltInstances__Offset=GetPropertyOffset(NativeClassPtr,"NumBuiltInstances");
			BuiltInstanceBounds__Offset=GetPropertyOffset(NativeClassPtr,"BuiltInstanceBounds");
			UnbuiltInstanceBounds__Offset=GetPropertyOffset(NativeClassPtr,"UnbuiltInstanceBounds");
			UnbuiltInstanceBoundsList__Offset=GetPropertyOffset(NativeClassPtr,"UnbuiltInstanceBoundsList");
			bEnableDensityScaling__Offset=GetPropertyOffset(NativeClassPtr,"bEnableDensityScaling");
			OcclusionLayerNumNodes__Offset=GetPropertyOffset(NativeClassPtr,"OcclusionLayerNumNodes");
			bDisableCollision__Offset=GetPropertyOffset(NativeClassPtr,"bDisableCollision");
			
		}
		
	}
	
}
#endif
#endif
