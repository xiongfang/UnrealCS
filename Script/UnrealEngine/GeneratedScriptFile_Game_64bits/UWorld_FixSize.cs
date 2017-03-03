#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UWorld
	{
		static readonly int PersistentLevel__Offset;
		public ULevel PersistentLevel
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PersistentLevel__Offset); if (v == IntPtr.Zero)return null; ULevel retValue = new ULevel(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NetDriver__Offset;
		public UNetDriver NetDriver
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NetDriver__Offset); if (v == IntPtr.Zero)return null; UNetDriver retValue = new UNetDriver(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int LineBatcher__Offset;
		public ULineBatchComponent LineBatcher
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LineBatcher__Offset); if (v == IntPtr.Zero)return null; ULineBatchComponent retValue = new ULineBatchComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PersistentLineBatcher__Offset;
		public ULineBatchComponent PersistentLineBatcher
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PersistentLineBatcher__Offset); if (v == IntPtr.Zero)return null; ULineBatchComponent retValue = new ULineBatchComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ForegroundLineBatcher__Offset;
		public ULineBatchComponent ForegroundLineBatcher
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ForegroundLineBatcher__Offset); if (v == IntPtr.Zero)return null; ULineBatchComponent retValue = new ULineBatchComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NetworkManager__Offset;
		public AGameNetworkManager NetworkManager
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NetworkManager__Offset); if (v == IntPtr.Zero)return null; AGameNetworkManager retValue = new AGameNetworkManager(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PhysicsCollisionHandler__Offset;
		public UPhysicsCollisionHandler PhysicsCollisionHandler
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PhysicsCollisionHandler__Offset); if (v == IntPtr.Zero)return null; UPhysicsCollisionHandler retValue = new UPhysicsCollisionHandler(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ExtraReferencedObjects__Offset;
		public TObjectArray<UObject>  ExtraReferencedObjects
		{
					get{ CheckIsValid();return new TObjectArray<UObject>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ExtraReferencedObjects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ExtraReferencedObjects__Offset, false);}
			
		}
		
		static readonly int PerModuleDataObjects__Offset;
		public TObjectArray<UObject>  PerModuleDataObjects
		{
					get{ CheckIsValid();return new TObjectArray<UObject>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PerModuleDataObjects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PerModuleDataObjects__Offset, false);}
			
		}
		
		static readonly int StreamingLevels__Offset;
		public TObjectArray<ULevelStreaming>  StreamingLevels
		{
					get{ CheckIsValid();return new TObjectArray<ULevelStreaming>((FScriptArray)Marshal.PtrToStructure(_this.Get()+StreamingLevels__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+StreamingLevels__Offset, false);}
			
		}
		
		static readonly int StreamingLevelsPrefix__Offset;
		public FString StreamingLevelsPrefix
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+StreamingLevelsPrefix__Offset, typeof(FString));}
			
		}
		
		static readonly int CurrentLevelPendingVisibility__Offset;
		public ULevel CurrentLevelPendingVisibility
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CurrentLevelPendingVisibility__Offset); if (v == IntPtr.Zero)return null; ULevel retValue = new ULevel(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CurrentLevelPendingInvisibility__Offset;
		public ULevel CurrentLevelPendingInvisibility
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CurrentLevelPendingInvisibility__Offset); if (v == IntPtr.Zero)return null; ULevel retValue = new ULevel(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DemoNetDriver__Offset;
		public UDemoNetDriver DemoNetDriver
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DemoNetDriver__Offset); if (v == IntPtr.Zero)return null; UDemoNetDriver retValue = new UDemoNetDriver(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MyParticleEventManager__Offset;
		public AParticleEventManager MyParticleEventManager
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MyParticleEventManager__Offset); if (v == IntPtr.Zero)return null; AParticleEventManager retValue = new AParticleEventManager(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DefaultPhysicsVolume__Offset;
		public APhysicsVolume DefaultPhysicsVolume
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultPhysicsVolume__Offset); if (v == IntPtr.Zero)return null; APhysicsVolume retValue = new APhysicsVolume(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NavigationSystem__Offset;
		public UNavigationSystem NavigationSystem
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NavigationSystem__Offset); if (v == IntPtr.Zero)return null; UNavigationSystem retValue = new UNavigationSystem(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AuthorityGameMode__Offset;
		public AGameModeBase AuthorityGameMode
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AuthorityGameMode__Offset); if (v == IntPtr.Zero)return null; AGameModeBase retValue = new AGameModeBase(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int GameState__Offset;
		public AGameStateBase GameState
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameState__Offset); if (v == IntPtr.Zero)return null; AGameStateBase retValue = new AGameStateBase(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AISystem__Offset;
		public UAISystemBase AISystem
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AISystem__Offset); if (v == IntPtr.Zero)return null; UAISystemBase retValue = new UAISystemBase(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AvoidanceManager__Offset;
		public UAvoidanceManager AvoidanceManager
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AvoidanceManager__Offset); if (v == IntPtr.Zero)return null; UAvoidanceManager retValue = new UAvoidanceManager(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Levels__Offset;
		public TObjectArray<ULevel>  Levels
		{
					get{ CheckIsValid();return new TObjectArray<ULevel>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Levels__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Levels__Offset, false);}
			
		}
		
		static readonly int LevelCollections__Offset;
		public TStructArray<FLevelCollection> LevelCollections
		{
			get{ CheckIsValid();return new TStructArray<FLevelCollection>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LevelCollections__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LevelCollections__Offset, false);}
			
		}
		
		static readonly int CurrentLevel__Offset;
		public ULevel CurrentLevel
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CurrentLevel__Offset); if (v == IntPtr.Zero)return null; ULevel retValue = new ULevel(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int OwningGameInstance__Offset;
		public UGameInstance OwningGameInstance
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + OwningGameInstance__Offset); if (v == IntPtr.Zero)return null; UGameInstance retValue = new UGameInstance(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ParameterCollectionInstances__Offset;
		public TObjectArray<UMaterialParameterCollectionInstance>  ParameterCollectionInstances
		{
					get{ CheckIsValid();return new TObjectArray<UMaterialParameterCollectionInstance>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ParameterCollectionInstances__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ParameterCollectionInstances__Offset, false);}
			
		}
		
		static readonly int CanvasForRenderingToTarget__Offset;
		public UCanvas CanvasForRenderingToTarget
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CanvasForRenderingToTarget__Offset); if (v == IntPtr.Zero)return null; UCanvas retValue = new UCanvas(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CanvasForDrawMaterialToRenderTarget__Offset;
		public UCanvas CanvasForDrawMaterialToRenderTarget
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CanvasForDrawMaterialToRenderTarget__Offset); if (v == IntPtr.Zero)return null; UCanvas retValue = new UCanvas(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int WorldComposition__Offset;
		public UWorldComposition WorldComposition
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + WorldComposition__Offset); if (v == IntPtr.Zero)return null; UWorldComposition retValue = new UWorldComposition(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bAreConstraintsDirty__Offset;
		public bool bAreConstraintsDirty
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAreConstraintsDirty__Offset, 1, 0, 1, 1);}
			
		}
		
		static UWorld()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("World");
			PersistentLevel__Offset=GetPropertyOffset(NativeClassPtr,"PersistentLevel");
			NetDriver__Offset=GetPropertyOffset(NativeClassPtr,"NetDriver");
			LineBatcher__Offset=GetPropertyOffset(NativeClassPtr,"LineBatcher");
			PersistentLineBatcher__Offset=GetPropertyOffset(NativeClassPtr,"PersistentLineBatcher");
			ForegroundLineBatcher__Offset=GetPropertyOffset(NativeClassPtr,"ForegroundLineBatcher");
			NetworkManager__Offset=GetPropertyOffset(NativeClassPtr,"NetworkManager");
			PhysicsCollisionHandler__Offset=GetPropertyOffset(NativeClassPtr,"PhysicsCollisionHandler");
			ExtraReferencedObjects__Offset=GetPropertyOffset(NativeClassPtr,"ExtraReferencedObjects");
			PerModuleDataObjects__Offset=GetPropertyOffset(NativeClassPtr,"PerModuleDataObjects");
			StreamingLevels__Offset=GetPropertyOffset(NativeClassPtr,"StreamingLevels");
			StreamingLevelsPrefix__Offset=GetPropertyOffset(NativeClassPtr,"StreamingLevelsPrefix");
			CurrentLevelPendingVisibility__Offset=GetPropertyOffset(NativeClassPtr,"CurrentLevelPendingVisibility");
			CurrentLevelPendingInvisibility__Offset=GetPropertyOffset(NativeClassPtr,"CurrentLevelPendingInvisibility");
			DemoNetDriver__Offset=GetPropertyOffset(NativeClassPtr,"DemoNetDriver");
			MyParticleEventManager__Offset=GetPropertyOffset(NativeClassPtr,"MyParticleEventManager");
			DefaultPhysicsVolume__Offset=GetPropertyOffset(NativeClassPtr,"DefaultPhysicsVolume");
			NavigationSystem__Offset=GetPropertyOffset(NativeClassPtr,"NavigationSystem");
			AuthorityGameMode__Offset=GetPropertyOffset(NativeClassPtr,"AuthorityGameMode");
			GameState__Offset=GetPropertyOffset(NativeClassPtr,"GameState");
			AISystem__Offset=GetPropertyOffset(NativeClassPtr,"AISystem");
			AvoidanceManager__Offset=GetPropertyOffset(NativeClassPtr,"AvoidanceManager");
			Levels__Offset=GetPropertyOffset(NativeClassPtr,"Levels");
			LevelCollections__Offset=GetPropertyOffset(NativeClassPtr,"LevelCollections");
			CurrentLevel__Offset=GetPropertyOffset(NativeClassPtr,"CurrentLevel");
			OwningGameInstance__Offset=GetPropertyOffset(NativeClassPtr,"OwningGameInstance");
			ParameterCollectionInstances__Offset=GetPropertyOffset(NativeClassPtr,"ParameterCollectionInstances");
			CanvasForRenderingToTarget__Offset=GetPropertyOffset(NativeClassPtr,"CanvasForRenderingToTarget");
			CanvasForDrawMaterialToRenderTarget__Offset=GetPropertyOffset(NativeClassPtr,"CanvasForDrawMaterialToRenderTarget");
			WorldComposition__Offset=GetPropertyOffset(NativeClassPtr,"WorldComposition");
			bAreConstraintsDirty__Offset=GetPropertyOffset(NativeClassPtr,"bAreConstraintsDirty");
			
		}
		
	}
	
}
#endif
#endif
