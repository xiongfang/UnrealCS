#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UHierarchicalInstancedStaticMeshComponent
	{
		static readonly int SortedInstances__Offset;
		public TStructArray<int> SortedInstances
		{
			get{ CheckIsValid();return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SortedInstances__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SortedInstances__Offset, false);}
			
		}
		
		static readonly int NumBuiltInstances__Offset;
		public int NumBuiltInstances
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumBuiltInstances__Offset, typeof(int));}
			
		}
		
		static readonly int BuiltInstanceBounds__Offset;
		public FBox BuiltInstanceBounds
		{
			get{ CheckIsValid();return (FBox)Marshal.PtrToStructure(_this.Get()+BuiltInstanceBounds__Offset, typeof(FBox));}
			
		}
		
		static readonly int UnbuiltInstanceBounds__Offset;
		public FBox UnbuiltInstanceBounds
		{
			get{ CheckIsValid();return (FBox)Marshal.PtrToStructure(_this.Get()+UnbuiltInstanceBounds__Offset, typeof(FBox));}
			
		}
		
		static readonly int UnbuiltInstanceBoundsList__Offset;
		public TStructArray<FBox> UnbuiltInstanceBoundsList
		{
			get{ CheckIsValid();return new TStructArray<FBox>((FScriptArray)Marshal.PtrToStructure(_this.Get()+UnbuiltInstanceBoundsList__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+UnbuiltInstanceBoundsList__Offset, false);}
			
		}
		
		static readonly int bEnableDensityScaling__Offset;
		public bool bEnableDensityScaling
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableDensityScaling__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int OcclusionLayerNumNodes__Offset;
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
