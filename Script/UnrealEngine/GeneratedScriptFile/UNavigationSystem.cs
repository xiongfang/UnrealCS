using System;
namespace UnrealEngine
{
	public partial class UNavigationSystem:UBlueprintFunctionLibrary
	{
		/// <summary>@todo document</summary>
		public extern void OnNavigationBoundsUpdated(ANavMeshBoundsVolume NavVolume);
		/// <summary>
		/// Removes given actor from the list of active navigation enforcers.
		///     @see RegisterNavigationInvoker for more details
		/// </summary>
		public extern void UnregisterNavigationInvoker(AActor Invoker);
		/// <summary>
		/// Registers given actor as a "navigation enforcer" which means navigation system will
		///     make sure navigation is being generated in specified radius around it.
		///     @note: you need NavigationSystem's GenerateNavigationOnlyAroundNavigationInvokers to be set to true
		///             to take advantage of this feature
		/// </summary>
		public extern void RegisterNavigationInvoker(AActor Invoker,float TileGenerationRadius=3000.000000f,float TileRemovalRadius=5000.000000f);
		/// <summary>Brings limit of simultaneous navmesh tile generation jobs back to Project Setting's default value</summary>
		public extern void ResetMaxSimultaneousTileGenerationJobsCount();
		/// <summary>
		/// will limit the number of simultaneously running navmesh tile generation jobs to specified number.
		///     @param MaxNumberOfJobs gets trimmed to be at least 1. You cannot use this function to pause navmesh generation
		/// </summary>
		public extern void SetMaxSimultaneousTileGenerationJobsCount(int MaxNumberOfJobs);
		/// <summary>
		/// Performs navigation raycast on NavigationData appropriate for given Querier.
		///     @param Querier if not passed default navigation data will be used
		///     @param HitLocation if line was obstructed this will be set to hit location. Otherwise it contains SegmentEnd
		///     @return true if line from RayStart to RayEnd was obstructed. Also, true when no navigation data present
		/// </summary>
		public extern static bool NavigationRaycast(UObject WorldContext,FVector RayStart,FVector RayEnd,out FVector HitLocation,TSubclassOf<UNavigationQueryFilter>  FilterClass,AController Querier);
		/// <summary>
		/// Finds path instantly, in a FindPath Synchronously. Main advantage over FindPathToLocationSynchronously is that
		///     the resulting path will automatically get updated if goal actor moves more than TetherDistance away from last path node
		///     @param PathfindingContext could be one of following: NavigationData (like Navmesh actor), Pawn or Controller. This parameter determines parameters of specific pathfinding query
		/// </summary>
		public extern static UNavigationPath FindPathToActorSynchronously(UObject WorldContext,FVector PathStart,AActor GoalActor,float TetherDistance=50.000000f,AActor PathfindingContext=default(AActor),TSubclassOf<UNavigationQueryFilter>  FilterClass=default(TSubclassOf<UNavigationQueryFilter> ));
		/// <summary>
		/// Finds path instantly, in a FindPath Synchronously.
		///     @param PathfindingContext could be one of following: NavigationData (like Navmesh actor), Pawn or Controller. This parameter determines parameters of specific pathfinding query
		/// </summary>
		public extern static UNavigationPath FindPathToLocationSynchronously(UObject WorldContext,FVector PathStart,FVector PathEnd,AActor PathfindingContext,TSubclassOf<UNavigationQueryFilter>  FilterClass);
		public extern static void SimpleMoveToLocation(AController Controller,FVector Goal);
		public extern static void SimpleMoveToActor(AController Controller,AActor Goal);
		public extern static bool IsNavigationBeingBuiltOrLocked(UObject WorldContext);
		public extern static bool IsNavigationBeingBuilt(UObject WorldContext);
		/// <summary>Potentially expensive. Use with caution</summary>
		public extern static ENavigationQueryResult GetPathLength(UObject WorldContext,FVector PathStart,FVector PathEnd,out float PathLength,ANavigationData NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass);
		/// <summary>Potentially expensive. Use with caution. Consider using UPathFollowingComponent::GetRemainingPathCost instead</summary>
		public extern static ENavigationQueryResult GetPathCost(UObject WorldContext,FVector PathStart,FVector PathEnd,out float PathCost,ANavigationData NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass);
		public extern static FVector GetRandomPointInNavigableRadius(UObject WorldContext,FVector Origin,float Radius,ANavigationData NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass);
		public extern static FVector GetRandomReachablePointInRadius(UObject WorldContext,FVector Origin,float Radius,ANavigationData NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass);
		/// <summary>Project a point onto the NavigationData</summary>
		public extern static FVector ProjectPointToNavigation(UObject WorldContext,FVector Point,ANavigationData NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass,FVector QueryExtent);
		/// <summary>Blueprint functions</summary>
		public extern static UNavigationSystem GetNavigationSystem(UObject WorldContext);
		public ANavigationData MainNavData;
		
		/// <summary>special navigation data for managing direct paths, not part of NavDataSet!</summary>
		public ANavigationData AbstractNavData;
		
		/// <summary>Should navigation system spawn default Navigation Data when there's none and there are navigation bounds present?</summary>
		public bool bAutoCreateNavigationData;
		
		public bool bAllowClientSideNavigation;
		
		/// <summary>
		/// gets set to true if gathering navigation data (like in navoctree) is required due to the need of navigation generation
		///     Is always true in Editor Mode. In other modes it depends on bRebuildAtRuntime of every required NavigationData class' CDO
		/// </summary>
		public bool bSupportRebuilding;
		
		/// <summary>
		/// if set to true will result navigation system not rebuild navigation until
		///     a call to ReleaseInitialBuildingLock() is called. Does not influence
		///     editor-time generation (i.e. does influence PIE and Game).
		///     Defaults to false.
		/// </summary>
		public bool bInitialBuildingLocked;
		
		/// <summary>
		/// false by default, if set to true will result in not caring about nav agent height
		///     when trying to match navigation data to passed in nav agent
		/// </summary>
		public bool bSkipAgentHeightCheckWhenPickingNavData;
		
		/// <summary>
		/// If set to true navigation will be generated only around registered "navigation enforcers"
		///      This has a range of consequences (including how navigation octree operates) so it needs to
		///      be a conscious decision.
		///      Once enabled results in whole world being navigable.
		///      @see RegisterNavigationInvoker
		/// </summary>
		public bool bGenerateNavigationOnlyAroundNavigationInvokers;
		
		/// <summary>Minimal time, in seconds, between active tiles set update</summary>
		public float ActiveTilesUpdateInterval;
		
		/// <summary>update frequency for dirty areas on navmesh</summary>
		public float DirtyAreasUpdateFreq;
		
		
	}
	
}
