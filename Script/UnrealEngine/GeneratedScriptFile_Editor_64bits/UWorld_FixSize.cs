#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// The World is the top level object representing a map or a sandbox in which Actors and Components will exist and be rendered.
	/// A World can be a single Persistent Level with an optional list of streaming levels that are loaded and unloaded via volumes and blueprint functions
	/// or it can be a collection of levels organized with a World Composition.
	/// In a standalone game, generally only a single World exists except during seamless area transitions when both a destination and current world exists.
	/// In the editor many Worlds exist: The level being edited, each PIE instance, each editor tool which has an interactive rendered viewport, and many more.
	/// </summary>
	public partial class UWorld
	{
		static readonly int Layers__Offset;
		/// <summary>List of all the layers referenced by the world's actors</summary>
		public TObjectArray<ULayer>  Layers
		{
					get{ CheckIsValid();return new TObjectArray<ULayer>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Layers__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Layers__Offset, false);}
			
		}
		
		static readonly int ActiveGroupActors__Offset;
		/// <summary>Group actors currently "active"</summary>
		public TObjectArray<AActor>  ActiveGroupActors
		{
					get{ CheckIsValid();return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ActiveGroupActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ActiveGroupActors__Offset, false);}
			
		}
		
		static readonly int ThumbnailInfo__Offset;
		/// <summary>Information for thumbnail rendering</summary>
		public UThumbnailInfo ThumbnailInfo
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ThumbnailInfo__Offset); if (v == IntPtr.Zero)return null; UThumbnailInfo retValue = new UThumbnailInfo(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ThumbnailInfo__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ThumbnailInfo__Offset, value._this.Get()); }
			
		}
		
		static readonly int PersistentLevel__Offset;
		/// <summary>Persistent level containing the world info, default brush and actors spawned during gameplay among other things</summary>
		public ULevel PersistentLevel
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PersistentLevel__Offset); if (v == IntPtr.Zero)return null; ULevel retValue = new ULevel(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NetDriver__Offset;
		/// <summary>The NAME_GameNetDriver game connection(s) for client/server communication</summary>
		public UNetDriver NetDriver
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NetDriver__Offset); if (v == IntPtr.Zero)return null; UNetDriver retValue = new UNetDriver(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int LineBatcher__Offset;
		/// <summary>Line Batchers. All lines to be drawn in the world.</summary>
		public ULineBatchComponent LineBatcher
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LineBatcher__Offset); if (v == IntPtr.Zero)return null; ULineBatchComponent retValue = new ULineBatchComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PersistentLineBatcher__Offset;
		/// <summary>Persistent Line Batchers. They don't get flushed every frame.</summary>
		public ULineBatchComponent PersistentLineBatcher
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PersistentLineBatcher__Offset); if (v == IntPtr.Zero)return null; ULineBatchComponent retValue = new ULineBatchComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ForegroundLineBatcher__Offset;
		/// <summary>Foreground Line Batchers. This can't be Persistent.</summary>
		public ULineBatchComponent ForegroundLineBatcher
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ForegroundLineBatcher__Offset); if (v == IntPtr.Zero)return null; ULineBatchComponent retValue = new ULineBatchComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NetworkManager__Offset;
		/// <summary>Instance of this world's game-specific networking management</summary>
		public AGameNetworkManager NetworkManager
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NetworkManager__Offset); if (v == IntPtr.Zero)return null; AGameNetworkManager retValue = new AGameNetworkManager(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PhysicsCollisionHandler__Offset;
		/// <summary>Instance of this world's game-specific physics collision handler</summary>
		public UPhysicsCollisionHandler PhysicsCollisionHandler
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PhysicsCollisionHandler__Offset); if (v == IntPtr.Zero)return null; UPhysicsCollisionHandler retValue = new UPhysicsCollisionHandler(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ExtraReferencedObjects__Offset;
		/// <summary>Array of any additional objects that need to be referenced by this world, to make sure they aren't GC'd</summary>
		public TObjectArray<UObject>  ExtraReferencedObjects
		{
					get{ CheckIsValid();return new TObjectArray<UObject>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ExtraReferencedObjects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ExtraReferencedObjects__Offset, false);}
			
		}
		
		static readonly int PerModuleDataObjects__Offset;
		/// <summary>
		/// External modules can have additional data associated with this UWorld.
		/// This is a list of per module world data objects. These aren't
		/// loaded/saved by default.
		/// </summary>
		public TObjectArray<UObject>  PerModuleDataObjects
		{
					get{ CheckIsValid();return new TObjectArray<UObject>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PerModuleDataObjects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PerModuleDataObjects__Offset, false);}
			
		}
		
		static readonly int StreamingLevels__Offset;
		/// <summary>Level collection. ULevels are referenced by FName (Package name) to avoid serialized references. Also contains offsets in world units</summary>
		public TObjectArray<ULevelStreaming>  StreamingLevels
		{
					get{ CheckIsValid();return new TObjectArray<ULevelStreaming>((FScriptArray)Marshal.PtrToStructure(_this.Get()+StreamingLevels__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+StreamingLevels__Offset, false);}
			
		}
		
		static readonly int StreamingLevelsPrefix__Offset;
		/// <summary>Prefix we used to rename streaming levels, non empty in PIE and standalone preview</summary>
		public FString StreamingLevelsPrefix
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+StreamingLevelsPrefix__Offset, typeof(FString));}
			
		}
		
		static readonly int CurrentLevelPendingVisibility__Offset;
		/// <summary>Pointer to the current level in the queue to be made visible, NULL if none are pending.</summary>
		public ULevel CurrentLevelPendingVisibility
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CurrentLevelPendingVisibility__Offset); if (v == IntPtr.Zero)return null; ULevel retValue = new ULevel(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CurrentLevelPendingInvisibility__Offset;
		/// <summary>Pointer to the current level in the queue to be made invisible, NULL if none are pending.</summary>
		public ULevel CurrentLevelPendingInvisibility
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CurrentLevelPendingInvisibility__Offset); if (v == IntPtr.Zero)return null; ULevel retValue = new ULevel(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DemoNetDriver__Offset;
		/// <summary>Fake NetDriver for capturing network traffic to record demos</summary>
		public UDemoNetDriver DemoNetDriver
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DemoNetDriver__Offset); if (v == IntPtr.Zero)return null; UDemoNetDriver retValue = new UDemoNetDriver(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MyParticleEventManager__Offset;
		/// <summary>Particle event manager *</summary>
		public AParticleEventManager MyParticleEventManager
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MyParticleEventManager__Offset); if (v == IntPtr.Zero)return null; AParticleEventManager retValue = new AParticleEventManager(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DefaultPhysicsVolume__Offset;
		/// <summary>DefaultPhysicsVolume used for whole game *</summary>
		public APhysicsVolume DefaultPhysicsVolume
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultPhysicsVolume__Offset); if (v == IntPtr.Zero)return null; APhysicsVolume retValue = new APhysicsVolume(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NavigationSystem__Offset;
		/// <summary>The world's navmesh</summary>
		public UNavigationSystem NavigationSystem
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NavigationSystem__Offset); if (v == IntPtr.Zero)return null; UNavigationSystem retValue = new UNavigationSystem(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AuthorityGameMode__Offset;
		/// <summary>The current GameMode, valid only on the server</summary>
		public AGameModeBase AuthorityGameMode
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AuthorityGameMode__Offset); if (v == IntPtr.Zero)return null; AGameModeBase retValue = new AGameModeBase(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int GameState__Offset;
		/// <summary>The replicated actor which contains game state information that can be accessible to clients. Direct access is not allowed, use GetGameState<>()</summary>
		public AGameStateBase GameState
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameState__Offset); if (v == IntPtr.Zero)return null; AGameStateBase retValue = new AGameStateBase(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AISystem__Offset;
		/// <summary>The AI System handles generating pathing information and AI behavior</summary>
		public UAISystemBase AISystem
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AISystem__Offset); if (v == IntPtr.Zero)return null; UAISystemBase retValue = new UAISystemBase(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AvoidanceManager__Offset;
		/// <summary>RVO avoidance manager used by game</summary>
		public UAvoidanceManager AvoidanceManager
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AvoidanceManager__Offset); if (v == IntPtr.Zero)return null; UAvoidanceManager retValue = new UAvoidanceManager(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Levels__Offset;
		/// <summary>Array of levels currently in this world. Not serialized to disk to avoid hard references.</summary>
		public TObjectArray<ULevel>  Levels
		{
					get{ CheckIsValid();return new TObjectArray<ULevel>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Levels__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Levels__Offset, false);}
			
		}
		
		static readonly int LevelCollections__Offset;
		/// <summary>Array of level collections currently in this world.</summary>
		public TStructArray<FLevelCollection> LevelCollections
		{
			get{ CheckIsValid();return new TStructArray<FLevelCollection>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LevelCollections__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LevelCollections__Offset, false);}
			
		}
		
		static readonly int CurrentLevel__Offset;
		/// <summary>Pointer to the current level being edited. Level has to be in the Levels array and == PersistentLevel in the game.</summary>
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
		/// <summary>Parameter collection instances that hold parameter overrides for this world.</summary>
		public TObjectArray<UMaterialParameterCollectionInstance>  ParameterCollectionInstances
		{
					get{ CheckIsValid();return new TObjectArray<UMaterialParameterCollectionInstance>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ParameterCollectionInstances__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ParameterCollectionInstances__Offset, false);}
			
		}
		
		static readonly int CanvasForRenderingToTarget__Offset;
		/// <summary>
		/// Canvas object used for drawing to render targets from blueprint functions eg DrawMaterialToRenderTarget.
		/// This is cached as UCanvas creation takes >100ms.
		/// </summary>
		public UCanvas CanvasForRenderingToTarget
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CanvasForRenderingToTarget__Offset); if (v == IntPtr.Zero)return null; UCanvas retValue = new UCanvas(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CanvasForDrawMaterialToRenderTarget__Offset;
		public UCanvas CanvasForDrawMaterialToRenderTarget
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CanvasForDrawMaterialToRenderTarget__Offset); if (v == IntPtr.Zero)return null; UCanvas retValue = new UCanvas(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int EditorViews__Offset;
		/// <summary>Saved editor viewport states - one for each view type. Indexed using ELevelViewportType from UnrealEdTypes.h.</summary>
		public TStructArray<FLevelViewportInfo> EditorViews
		{
			get{ CheckIsValid();return new TStructArray<FLevelViewportInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+EditorViews__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+EditorViews__Offset, false);}
			
		}
		
		static readonly int SelectedLevels__Offset;
		/// <summary>Array of selected levels currently in this world. Not serialized to disk to avoid hard references.</summary>
		public TObjectArray<ULevel>  SelectedLevels
		{
					get{ CheckIsValid();return new TObjectArray<ULevel>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SelectedLevels__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SelectedLevels__Offset, false);}
			
		}
		
		static readonly int WorldComposition__Offset;
		/// <summary>All levels information from which our world is composed</summary>
		public UWorldComposition WorldComposition
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + WorldComposition__Offset); if (v == IntPtr.Zero)return null; UWorldComposition retValue = new UWorldComposition(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bAreConstraintsDirty__Offset;
		/// <summary>Keeps track whether actors moved via PostEditMove and therefore constraint syncup should be performed.</summary>
		public bool bAreConstraintsDirty
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAreConstraintsDirty__Offset, 1, 0, 1, 1);}
			
		}
		
		static UWorld()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("World");
			Layers__Offset=GetPropertyOffset(NativeClassPtr,"Layers");
			ActiveGroupActors__Offset=GetPropertyOffset(NativeClassPtr,"ActiveGroupActors");
			ThumbnailInfo__Offset=GetPropertyOffset(NativeClassPtr,"ThumbnailInfo");
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
			EditorViews__Offset=GetPropertyOffset(NativeClassPtr,"EditorViews");
			SelectedLevels__Offset=GetPropertyOffset(NativeClassPtr,"SelectedLevels");
			WorldComposition__Offset=GetPropertyOffset(NativeClassPtr,"WorldComposition");
			bAreConstraintsDirty__Offset=GetPropertyOffset(NativeClassPtr,"bAreConstraintsDirty");
			
		}
		
	}
	
}
#endif
#endif
