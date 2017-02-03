using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UNavigationSystem:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnNavigationBoundsUpdated(IntPtr _this,IntPtr NavVolume);
/// <summary>@todo document</summary>
public  void OnNavigationBoundsUpdated(ANavMeshBoundsVolume NavVolume)
{
	CheckIsValid();
	OnNavigationBoundsUpdated(_this.Get(),NavVolume);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetGeometryGatheringMode(IntPtr _this,int NewMode);
public  void SetGeometryGatheringMode(ENavDataGatheringModeConfig NewMode)
{
	CheckIsValid();
	SetGeometryGatheringMode(_this.Get(),(int)NewMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void UnregisterNavigationInvoker(IntPtr _this,IntPtr Invoker);
/// <summary>
/// Removes given actor from the list of active navigation enforcers.
///     @see RegisterNavigationInvoker for more details
/// </summary>
public  void UnregisterNavigationInvoker(AActor Invoker)
{
	CheckIsValid();
	UnregisterNavigationInvoker(_this.Get(),Invoker);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RegisterNavigationInvoker(IntPtr _this,IntPtr Invoker,float TileGenerationRadius,float TileRemovalRadius);
/// <summary>
/// Registers given actor as a "navigation enforcer" which means navigation system will
///     make sure navigation is being generated in specified radius around it.
///     @note: you need NavigationSystem's GenerateNavigationOnlyAroundNavigationInvokers to be set to true
///             to take advantage of this feature
/// </summary>
public  void RegisterNavigationInvoker(AActor Invoker,float TileGenerationRadius=3000.000000f,float TileRemovalRadius=5000.000000f)
{
	CheckIsValid();
	RegisterNavigationInvoker(_this.Get(),Invoker,TileGenerationRadius,TileRemovalRadius);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetMaxSimultaneousTileGenerationJobsCount(IntPtr _this);
/// <summary>Brings limit of simultaneous navmesh tile generation jobs back to Project Setting's default value</summary>
public  void ResetMaxSimultaneousTileGenerationJobsCount()
{
	CheckIsValid();
	ResetMaxSimultaneousTileGenerationJobsCount(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMaxSimultaneousTileGenerationJobsCount(IntPtr _this,int MaxNumberOfJobs);
/// <summary>
/// will limit the number of simultaneously running navmesh tile generation jobs to specified number.
///     @param MaxNumberOfJobs gets trimmed to be at least 1. You cannot use this function to pause navmesh generation
/// </summary>
public  void SetMaxSimultaneousTileGenerationJobsCount(int MaxNumberOfJobs)
{
	CheckIsValid();
	SetMaxSimultaneousTileGenerationJobsCount(_this.Get(),MaxNumberOfJobs);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NavigationRaycast(IntPtr _this,IntPtr WorldContext,ref FVector RayStart,ref FVector RayEnd,out FVector HitLocation,IntPtr FilterClass,IntPtr Querier);
/// <summary>
/// Performs navigation raycast on NavigationData appropriate for given Querier.
///     @param Querier if not passed default navigation data will be used
///     @param HitLocation if line was obstructed this will be set to hit location. Otherwise it contains SegmentEnd
///     @return true if line from RayStart to RayEnd was obstructed. Also, true when no navigation data present
/// </summary>
public static bool NavigationRaycast(UObject WorldContext,FVector RayStart,FVector RayEnd,out FVector HitLocation,TSubclassOf<UNavigationQueryFilter>  FilterClass,AController Querier)
{
	int ___ret = NavigationRaycast(IntPtr.Zero,WorldContext,ref RayStart,ref RayEnd,out HitLocation,FilterClass.NativeClass,Querier);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr FindPathToActorSynchronously(IntPtr _this,IntPtr WorldContext,ref FVector PathStart,IntPtr GoalActor,float TetherDistance,IntPtr PathfindingContext,IntPtr FilterClass);
/// <summary>
/// Finds path instantly, in a FindPath Synchronously. Main advantage over FindPathToLocationSynchronously is that
///     the resulting path will automatically get updated if goal actor moves more than TetherDistance away from last path node
///     @param PathfindingContext could be one of following: NavigationData (like Navmesh actor), Pawn or Controller. This parameter determines parameters of specific pathfinding query
/// </summary>
public static UNavigationPath FindPathToActorSynchronously(UObject WorldContext,FVector PathStart,AActor GoalActor,float TetherDistance=50.000000f,AActor PathfindingContext=default(AActor),TSubclassOf<UNavigationQueryFilter>  FilterClass=default(TSubclassOf<UNavigationQueryFilter> ))
{
	IntPtr ___ret = FindPathToActorSynchronously(IntPtr.Zero,WorldContext,ref PathStart,GoalActor,TetherDistance,PathfindingContext,FilterClass.NativeClass);
	if(___ret==IntPtr.Zero) return null; UNavigationPath ___ret2= new UNavigationPath(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr FindPathToLocationSynchronously(IntPtr _this,IntPtr WorldContext,ref FVector PathStart,ref FVector PathEnd,IntPtr PathfindingContext,IntPtr FilterClass);
/// <summary>
/// Finds path instantly, in a FindPath Synchronously.
///     @param PathfindingContext could be one of following: NavigationData (like Navmesh actor), Pawn or Controller. This parameter determines parameters of specific pathfinding query
/// </summary>
public static UNavigationPath FindPathToLocationSynchronously(UObject WorldContext,FVector PathStart,FVector PathEnd,AActor PathfindingContext,TSubclassOf<UNavigationQueryFilter>  FilterClass)
{
	IntPtr ___ret = FindPathToLocationSynchronously(IntPtr.Zero,WorldContext,ref PathStart,ref PathEnd,PathfindingContext,FilterClass.NativeClass);
	if(___ret==IntPtr.Zero) return null; UNavigationPath ___ret2= new UNavigationPath(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SimpleMoveToLocation(IntPtr _this,IntPtr Controller,ref FVector Goal);
public static void SimpleMoveToLocation(AController Controller,FVector Goal)
{
	SimpleMoveToLocation(IntPtr.Zero,Controller,ref Goal);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SimpleMoveToActor(IntPtr _this,IntPtr Controller,IntPtr Goal);
public static void SimpleMoveToActor(AController Controller,AActor Goal)
{
	SimpleMoveToActor(IntPtr.Zero,Controller,Goal);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsNavigationBeingBuiltOrLocked(IntPtr _this,IntPtr WorldContext);
public static bool IsNavigationBeingBuiltOrLocked(UObject WorldContext)
{
	int ___ret = IsNavigationBeingBuiltOrLocked(IntPtr.Zero,WorldContext);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsNavigationBeingBuilt(IntPtr _this,IntPtr WorldContext);
public static bool IsNavigationBeingBuilt(UObject WorldContext)
{
	int ___ret = IsNavigationBeingBuilt(IntPtr.Zero,WorldContext);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetPathLength(IntPtr _this,IntPtr WorldContext,ref FVector PathStart,ref FVector PathEnd,out float PathLength,IntPtr NavData,IntPtr FilterClass);
/// <summary>Potentially expensive. Use with caution</summary>
public static ENavigationQueryResult GetPathLength(UObject WorldContext,FVector PathStart,FVector PathEnd,out float PathLength,ANavigationData NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass)
{
	int ___ret = GetPathLength(IntPtr.Zero,WorldContext,ref PathStart,ref PathEnd,out PathLength,NavData,FilterClass.NativeClass);
	return (ENavigationQueryResult)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetPathCost(IntPtr _this,IntPtr WorldContext,ref FVector PathStart,ref FVector PathEnd,out float PathCost,IntPtr NavData,IntPtr FilterClass);
/// <summary>Potentially expensive. Use with caution. Consider using UPathFollowingComponent::GetRemainingPathCost instead</summary>
public static ENavigationQueryResult GetPathCost(UObject WorldContext,FVector PathStart,FVector PathEnd,out float PathCost,ANavigationData NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass)
{
	int ___ret = GetPathCost(IntPtr.Zero,WorldContext,ref PathStart,ref PathEnd,out PathCost,NavData,FilterClass.NativeClass);
	return (ENavigationQueryResult)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetRandomPointInNavigableRadius(IntPtr _this,IntPtr WorldContext,ref FVector Origin,float Radius,IntPtr NavData,IntPtr FilterClass);
public static FVector GetRandomPointInNavigableRadius(UObject WorldContext,FVector Origin,float Radius,ANavigationData NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass)
{
	FVector ___ret = GetRandomPointInNavigableRadius(IntPtr.Zero,WorldContext,ref Origin,Radius,NavData,FilterClass.NativeClass);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetRandomReachablePointInRadius(IntPtr _this,IntPtr WorldContext,ref FVector Origin,float Radius,IntPtr NavData,IntPtr FilterClass);
public static FVector GetRandomReachablePointInRadius(UObject WorldContext,FVector Origin,float Radius,ANavigationData NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass)
{
	FVector ___ret = GetRandomReachablePointInRadius(IntPtr.Zero,WorldContext,ref Origin,Radius,NavData,FilterClass.NativeClass);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector ProjectPointToNavigation(IntPtr _this,IntPtr WorldContext,ref FVector Point,IntPtr NavData,IntPtr FilterClass,ref FVector QueryExtent);
/// <summary>Project a point onto the NavigationData</summary>
public static FVector ProjectPointToNavigation(UObject WorldContext,FVector Point,ANavigationData NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass,FVector QueryExtent)
{
	FVector ___ret = ProjectPointToNavigation(IntPtr.Zero,WorldContext,ref Point,NavData,FilterClass.NativeClass,ref QueryExtent);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetNavigationSystem(IntPtr _this,IntPtr WorldContext);
/// <summary>Blueprint functions</summary>
public static UNavigationSystem GetNavigationSystem(UObject WorldContext)
{
	IntPtr ___ret = GetNavigationSystem(IntPtr.Zero,WorldContext);
	if(___ret==IntPtr.Zero) return null; UNavigationSystem ___ret2= new UNavigationSystem(){ _this = ___ret }; return ___ret2;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
