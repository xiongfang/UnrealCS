using System;
namespace UnrealEngine
{
	public partial class ANavigationTestingActor:AActor
	{
		public UCapsuleComponent CapsuleComponent;
		
		public UNavTestRenderingComponent EdRenderComp;
		
		public UNavigationInvokerComponent InvokerComponent;
		
		public bool bActAsNavigationInvoker;
		
		/// <summary>@todo document</summary>
		public FNavAgentProperties NavAgentProps;
		
		public FVector QueryingExtent;
		
		public ANavigationData MyNavData;
		
		public FVector ProjectedLocation;
		
		public bool bProjectedLocationValid;
		
		public bool bSearchStart;
		
		public bool bUseHierarchicalPathfinding;
		
		/// <summary>if set, all steps of A* algorithm will be accessible for debugging</summary>
		public bool bGatherDetailedInfo;
		
		public bool bDrawDistanceToWall;
		
		/// <summary>show polys from open (orange) and closed (yellow) sets</summary>
		public bool bShowNodePool;
		
		/// <summary>show current best path</summary>
		public bool bShowBestPath;
		
		/// <summary>show which nodes were modified in current A* step</summary>
		public bool bShowDiffWithPreviousStep;
		
		public bool bShouldBeVisibleInGame;
		
		/// <summary>determines which cost will be shown</summary>
		public ENavCostDisplay CostDisplayMode;
		
		/// <summary>text canvas offset to apply</summary>
		public FVector2D TextCanvasOffset;
		
		public bool bPathExist;
		
		public bool bPathIsPartial;
		
		public bool bPathSearchOutOfNodes;
		
		/// <summary>Time in micro seconds</summary>
		public float PathfindingTime;
		
		public float PathCost;
		
		public int PathfindingSteps;
		
		public ANavigationTestingActor OtherActor;
		
		/// <summary>"None" will result in default filter being used</summary>
		public TSubclassOf<UNavigationQueryFilter>  FilterClass;
		
		public int ShowStepIndex;
		
		public float OffsetFromCornersDistance;
		
		
	}
	
}
