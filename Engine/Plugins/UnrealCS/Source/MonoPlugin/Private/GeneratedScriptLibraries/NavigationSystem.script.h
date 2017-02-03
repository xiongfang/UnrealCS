#pragma once

namespace UnrealEngine
{
	class _UNavigationSystem
	{
		static void OnNavigationBoundsUpdated(UNavigationSystem* _this,ANavMeshBoundsVolume* NavVolume)
		{
			_this->OnNavigationBoundsUpdated(NavVolume);
			
		}
		static void SetGeometryGatheringMode(UNavigationSystem* _this,int32 NewMode)
		{
			_this->SetGeometryGatheringMode((TEnumAsByte<ENavDataGatheringModeConfig>)NewMode);
			
		}
		static void UnregisterNavigationInvoker(UNavigationSystem* _this,AActor* Invoker)
		{
			_this->UnregisterNavigationInvoker(Invoker);
			
		}
		static void RegisterNavigationInvoker(UNavigationSystem* _this,AActor* Invoker,float TileGenerationRadius,float TileRemovalRadius)
		{
			_this->RegisterNavigationInvoker(Invoker,TileGenerationRadius,TileRemovalRadius);
			
		}
		static void ResetMaxSimultaneousTileGenerationJobsCount(UNavigationSystem* _this)
		{
			_this->ResetMaxSimultaneousTileGenerationJobsCount();
			
		}
		static void SetMaxSimultaneousTileGenerationJobsCount(UNavigationSystem* _this,int32 MaxNumberOfJobs)
		{
			_this->SetMaxSimultaneousTileGenerationJobsCount(MaxNumberOfJobs);
			
		}
		static int32 NavigationRaycast(UNavigationSystem* _this,UObject* WorldContext,FVector* RayStart,FVector* RayEnd,FVector* HitLocation,TSubclassOf<UNavigationQueryFilter>  FilterClass,AController* Querier)
		{
			bool ___ret = _this->NavigationRaycast(WorldContext,*RayStart,*RayEnd,*HitLocation,FilterClass,Querier);
			return ___ret?1:0;
			
		}
		static UNavigationPath* FindPathToActorSynchronously(UNavigationSystem* _this,UObject* WorldContext,FVector* PathStart,AActor* GoalActor,float TetherDistance,AActor* PathfindingContext,TSubclassOf<UNavigationQueryFilter>  FilterClass)
		{
			UNavigationPath* ___ret = _this->FindPathToActorSynchronously(WorldContext,*PathStart,GoalActor,TetherDistance,PathfindingContext,FilterClass);
			return ___ret;
			
		}
		static UNavigationPath* FindPathToLocationSynchronously(UNavigationSystem* _this,UObject* WorldContext,FVector* PathStart,FVector* PathEnd,AActor* PathfindingContext,TSubclassOf<UNavigationQueryFilter>  FilterClass)
		{
			UNavigationPath* ___ret = _this->FindPathToLocationSynchronously(WorldContext,*PathStart,*PathEnd,PathfindingContext,FilterClass);
			return ___ret;
			
		}
		static void SimpleMoveToLocation(UNavigationSystem* _this,AController* Controller,FVector* Goal)
		{
			_this->SimpleMoveToLocation(Controller,*Goal);
			
		}
		static void SimpleMoveToActor(UNavigationSystem* _this,AController* Controller,AActor* Goal)
		{
			_this->SimpleMoveToActor(Controller,Goal);
			
		}
		static int32 IsNavigationBeingBuiltOrLocked(UNavigationSystem* _this,UObject* WorldContext)
		{
			bool ___ret = _this->IsNavigationBeingBuiltOrLocked(WorldContext);
			return ___ret?1:0;
			
		}
		static int32 IsNavigationBeingBuilt(UNavigationSystem* _this,UObject* WorldContext)
		{
			bool ___ret = _this->IsNavigationBeingBuilt(WorldContext);
			return ___ret?1:0;
			
		}
		static int32 GetPathLength(UNavigationSystem* _this,UObject* WorldContext,FVector* PathStart,FVector* PathEnd,float* PathLength,ANavigationData* NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass)
		{
			TEnumAsByte<ENavigationQueryResult::Type> ___ret = _this->GetPathLength(WorldContext,*PathStart,*PathEnd,*PathLength,NavData,FilterClass);
			return (int)___ret.GetValue();
			
		}
		static int32 GetPathCost(UNavigationSystem* _this,UObject* WorldContext,FVector* PathStart,FVector* PathEnd,float* PathCost,ANavigationData* NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass)
		{
			TEnumAsByte<ENavigationQueryResult::Type> ___ret = _this->GetPathCost(WorldContext,*PathStart,*PathEnd,*PathCost,NavData,FilterClass);
			return (int)___ret.GetValue();
			
		}
		static FVector GetRandomPointInNavigableRadius(UNavigationSystem* _this,UObject* WorldContext,FVector* Origin,float Radius,ANavigationData* NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass)
		{
			FVector ___ret = _this->GetRandomPointInNavigableRadius(WorldContext,*Origin,Radius,NavData,FilterClass);
			return ___ret;
			
		}
		static FVector GetRandomReachablePointInRadius(UNavigationSystem* _this,UObject* WorldContext,FVector* Origin,float Radius,ANavigationData* NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass)
		{
			FVector ___ret = _this->GetRandomReachablePointInRadius(WorldContext,*Origin,Radius,NavData,FilterClass);
			return ___ret;
			
		}
		static FVector ProjectPointToNavigation(UNavigationSystem* _this,UObject* WorldContext,FVector* Point,ANavigationData* NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass,FVector* QueryExtent)
		{
			FVector ___ret = _this->ProjectPointToNavigation(WorldContext,*Point,NavData,FilterClass,*QueryExtent);
			return ___ret;
			
		}
		static UNavigationSystem* GetNavigationSystem(UNavigationSystem* _this,UObject* WorldContext)
		{
			UNavigationSystem* ___ret = _this->GetNavigationSystem(WorldContext);
			return ___ret;
			
		}
		static UClass* StaticClass(){return UNavigationSystem::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavigationSystem::OnNavigationBoundsUpdated",(const void*)OnNavigationBoundsUpdated);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::SetGeometryGatheringMode",(const void*)SetGeometryGatheringMode);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::UnregisterNavigationInvoker",(const void*)UnregisterNavigationInvoker);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::RegisterNavigationInvoker",(const void*)RegisterNavigationInvoker);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::ResetMaxSimultaneousTileGenerationJobsCount",(const void*)ResetMaxSimultaneousTileGenerationJobsCount);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::SetMaxSimultaneousTileGenerationJobsCount",(const void*)SetMaxSimultaneousTileGenerationJobsCount);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::NavigationRaycast",(const void*)NavigationRaycast);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::FindPathToActorSynchronously",(const void*)FindPathToActorSynchronously);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::FindPathToLocationSynchronously",(const void*)FindPathToLocationSynchronously);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::SimpleMoveToLocation",(const void*)SimpleMoveToLocation);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::SimpleMoveToActor",(const void*)SimpleMoveToActor);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::IsNavigationBeingBuiltOrLocked",(const void*)IsNavigationBeingBuiltOrLocked);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::IsNavigationBeingBuilt",(const void*)IsNavigationBeingBuilt);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::GetPathLength",(const void*)GetPathLength);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::GetPathCost",(const void*)GetPathCost);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::GetRandomPointInNavigableRadius",(const void*)GetRandomPointInNavigableRadius);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::GetRandomReachablePointInRadius",(const void*)GetRandomReachablePointInRadius);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::ProjectPointToNavigation",(const void*)ProjectPointToNavigation);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::GetNavigationSystem",(const void*)GetNavigationSystem);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
