#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ANavigationTestingActor
	{
		static readonly int CapsuleComponent__Offset;
		public UCapsuleComponent CapsuleComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CapsuleComponent__Offset); if (v == IntPtr.Zero)return null; UCapsuleComponent retValue = new UCapsuleComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int InvokerComponent__Offset;
		public UNavigationInvokerComponent InvokerComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + InvokerComponent__Offset); if (v == IntPtr.Zero)return null; UNavigationInvokerComponent retValue = new UNavigationInvokerComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + InvokerComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + InvokerComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int bActAsNavigationInvoker__Offset;
		public bool bActAsNavigationInvoker
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bActAsNavigationInvoker__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bActAsNavigationInvoker__Offset, 1,0,1,1);}
			
		}
		
		static readonly int NavAgentProps__Offset;
		public FNavAgentProperties NavAgentProps
		{
			get{ CheckIsValid();return (FNavAgentProperties)Marshal.PtrToStructure(_this.Get()+NavAgentProps__Offset, typeof(FNavAgentProperties));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NavAgentProps__Offset, false);}
			
		}
		
		static readonly int QueryingExtent__Offset;
		public FVector QueryingExtent
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+QueryingExtent__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+QueryingExtent__Offset, false);}
			
		}
		
		static readonly int MyNavData__Offset;
		public ANavigationData MyNavData
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MyNavData__Offset); if (v == IntPtr.Zero)return null; ANavigationData retValue = new ANavigationData(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ProjectedLocation__Offset;
		public FVector ProjectedLocation
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+ProjectedLocation__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ProjectedLocation__Offset, false);}
			
		}
		
		static readonly int bProjectedLocationValid__Offset;
		public bool bProjectedLocationValid
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bProjectedLocationValid__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bProjectedLocationValid__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bSearchStart__Offset;
		public bool bSearchStart
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSearchStart__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSearchStart__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bUseHierarchicalPathfinding__Offset;
		public bool bUseHierarchicalPathfinding
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseHierarchicalPathfinding__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseHierarchicalPathfinding__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bGatherDetailedInfo__Offset;
		public bool bGatherDetailedInfo
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGatherDetailedInfo__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGatherDetailedInfo__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bDrawDistanceToWall__Offset;
		public bool bDrawDistanceToWall
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawDistanceToWall__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawDistanceToWall__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bShowNodePool__Offset;
		public bool bShowNodePool
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowNodePool__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShowNodePool__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bShowBestPath__Offset;
		public bool bShowBestPath
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowBestPath__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShowBestPath__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bShowDiffWithPreviousStep__Offset;
		public bool bShowDiffWithPreviousStep
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowDiffWithPreviousStep__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShowDiffWithPreviousStep__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bShouldBeVisibleInGame__Offset;
		public bool bShouldBeVisibleInGame
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldBeVisibleInGame__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShouldBeVisibleInGame__Offset, 1,0,1,1);}
			
		}
		
		static readonly int CostDisplayMode__Offset;
		public ENavCostDisplay CostDisplayMode
		{
			get{ CheckIsValid();return (ENavCostDisplay)Marshal.PtrToStructure(_this.Get()+CostDisplayMode__Offset, typeof(ENavCostDisplay));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CostDisplayMode__Offset, false);}
			
		}
		
		static readonly int TextCanvasOffset__Offset;
		public FVector2D TextCanvasOffset
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+TextCanvasOffset__Offset, typeof(FVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TextCanvasOffset__Offset, false);}
			
		}
		
		static readonly int bPathExist__Offset;
		public bool bPathExist
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPathExist__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPathExist__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bPathIsPartial__Offset;
		public bool bPathIsPartial
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPathIsPartial__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPathIsPartial__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bPathSearchOutOfNodes__Offset;
		public bool bPathSearchOutOfNodes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPathSearchOutOfNodes__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPathSearchOutOfNodes__Offset, 1,0,4,4);}
			
		}
		
		static readonly int PathfindingTime__Offset;
		public float PathfindingTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PathfindingTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PathfindingTime__Offset, false);}
			
		}
		
		static readonly int PathCost__Offset;
		public float PathCost
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PathCost__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PathCost__Offset, false);}
			
		}
		
		static readonly int PathfindingSteps__Offset;
		public int PathfindingSteps
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PathfindingSteps__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PathfindingSteps__Offset, false);}
			
		}
		
		static readonly int OtherActor__Offset;
		public ANavigationTestingActor OtherActor
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + OtherActor__Offset); if (v == IntPtr.Zero)return null; ANavigationTestingActor retValue = new ANavigationTestingActor(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + OtherActor__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + OtherActor__Offset, value._this.Get()); }
			
		}
		
		static readonly int FilterClass__Offset;
		public TSubclassOf<UNavigationQueryFilter>  FilterClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + FilterClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + FilterClass__Offset, value); }
			
		}
		
		static readonly int ShowStepIndex__Offset;
		public int ShowStepIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ShowStepIndex__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShowStepIndex__Offset, false);}
			
		}
		
		static readonly int OffsetFromCornersDistance__Offset;
		public float OffsetFromCornersDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OffsetFromCornersDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OffsetFromCornersDistance__Offset, false);}
			
		}
		
		static ANavigationTestingActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavigationTestingActor");
			CapsuleComponent__Offset=GetPropertyOffset(NativeClassPtr,"CapsuleComponent");
			InvokerComponent__Offset=GetPropertyOffset(NativeClassPtr,"InvokerComponent");
			bActAsNavigationInvoker__Offset=GetPropertyOffset(NativeClassPtr,"bActAsNavigationInvoker");
			NavAgentProps__Offset=GetPropertyOffset(NativeClassPtr,"NavAgentProps");
			QueryingExtent__Offset=GetPropertyOffset(NativeClassPtr,"QueryingExtent");
			MyNavData__Offset=GetPropertyOffset(NativeClassPtr,"MyNavData");
			ProjectedLocation__Offset=GetPropertyOffset(NativeClassPtr,"ProjectedLocation");
			bProjectedLocationValid__Offset=GetPropertyOffset(NativeClassPtr,"bProjectedLocationValid");
			bSearchStart__Offset=GetPropertyOffset(NativeClassPtr,"bSearchStart");
			bUseHierarchicalPathfinding__Offset=GetPropertyOffset(NativeClassPtr,"bUseHierarchicalPathfinding");
			bGatherDetailedInfo__Offset=GetPropertyOffset(NativeClassPtr,"bGatherDetailedInfo");
			bDrawDistanceToWall__Offset=GetPropertyOffset(NativeClassPtr,"bDrawDistanceToWall");
			bShowNodePool__Offset=GetPropertyOffset(NativeClassPtr,"bShowNodePool");
			bShowBestPath__Offset=GetPropertyOffset(NativeClassPtr,"bShowBestPath");
			bShowDiffWithPreviousStep__Offset=GetPropertyOffset(NativeClassPtr,"bShowDiffWithPreviousStep");
			bShouldBeVisibleInGame__Offset=GetPropertyOffset(NativeClassPtr,"bShouldBeVisibleInGame");
			CostDisplayMode__Offset=GetPropertyOffset(NativeClassPtr,"CostDisplayMode");
			TextCanvasOffset__Offset=GetPropertyOffset(NativeClassPtr,"TextCanvasOffset");
			bPathExist__Offset=GetPropertyOffset(NativeClassPtr,"bPathExist");
			bPathIsPartial__Offset=GetPropertyOffset(NativeClassPtr,"bPathIsPartial");
			bPathSearchOutOfNodes__Offset=GetPropertyOffset(NativeClassPtr,"bPathSearchOutOfNodes");
			PathfindingTime__Offset=GetPropertyOffset(NativeClassPtr,"PathfindingTime");
			PathCost__Offset=GetPropertyOffset(NativeClassPtr,"PathCost");
			PathfindingSteps__Offset=GetPropertyOffset(NativeClassPtr,"PathfindingSteps");
			OtherActor__Offset=GetPropertyOffset(NativeClassPtr,"OtherActor");
			FilterClass__Offset=GetPropertyOffset(NativeClassPtr,"FilterClass");
			ShowStepIndex__Offset=GetPropertyOffset(NativeClassPtr,"ShowStepIndex");
			OffsetFromCornersDistance__Offset=GetPropertyOffset(NativeClassPtr,"OffsetFromCornersDistance");
			
		}
		
	}
	
}
#endif
#endif
