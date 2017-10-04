using System;
namespace UnrealEngine
{
	public partial class UWorld:UObject
	{
		/// <summary>Information for thumbnail rendering</summary>
		public UThumbnailInfo ThumbnailInfo;
		
		/// <summary>Persistent level containing the world info, default brush and actors spawned during gameplay among other things</summary>
		public ULevel PersistentLevel;
		
		/// <summary>The NAME_GameNetDriver game connection(s) for client/server communication</summary>
		public UNetDriver NetDriver;
		
		/// <summary>Line Batchers. All lines to be drawn in the world.</summary>
		public ULineBatchComponent LineBatcher;
		
		/// <summary>Persistent Line Batchers. They don't get flushed every frame.</summary>
		public ULineBatchComponent PersistentLineBatcher;
		
		/// <summary>Foreground Line Batchers. This can't be Persistent.</summary>
		public ULineBatchComponent ForegroundLineBatcher;
		
		/// <summary>Instance of this world's game-specific networking management</summary>
		public AGameNetworkManager NetworkManager;
		
		/// <summary>Instance of this world's game-specific physics collision handler</summary>
		public UPhysicsCollisionHandler PhysicsCollisionHandler;
		
		/// <summary>Prefix we used to rename streaming levels, non empty in PIE and standalone preview</summary>
		public FString StreamingLevelsPrefix;
		
		/// <summary>Pointer to the current level in the queue to be made visible, NULL if none are pending.</summary>
		public ULevel CurrentLevelPendingVisibility;
		
		/// <summary>Pointer to the current level in the queue to be made invisible, NULL if none are pending.</summary>
		public ULevel CurrentLevelPendingInvisibility;
		
		/// <summary>Fake NetDriver for capturing network traffic to record demos</summary>
		public UDemoNetDriver DemoNetDriver;
		
		/// <summary>Particle event manager *</summary>
		public AParticleEventManager MyParticleEventManager;
		
		/// <summary>DefaultPhysicsVolume used for whole game *</summary>
		public APhysicsVolume DefaultPhysicsVolume;
		
		/// <summary>The world's navmesh</summary>
		public UNavigationSystem NavigationSystem;
		
		/// <summary>The current GameMode, valid only on the server</summary>
		public AGameModeBase AuthorityGameMode;
		
		/// <summary>The replicated actor which contains game state information that can be accessible to clients. Direct access is not allowed, use GetGameState<>()</summary>
		public AGameStateBase GameState;
		
		/// <summary>The AI System handles generating pathing information and AI behavior</summary>
		public UAISystemBase AISystem;
		
		/// <summary>RVO avoidance manager used by game</summary>
		public UAvoidanceManager AvoidanceManager;
		
		/// <summary>Pointer to the current level being edited. Level has to be in the Levels array and == PersistentLevel in the game.</summary>
		public ULevel CurrentLevel;
		
		public UGameInstance OwningGameInstance;
		
		/// <summary>
		/// Canvas object used for drawing to render targets from blueprint functions eg DrawMaterialToRenderTarget.
		/// This is cached as UCanvas creation takes >100ms.
		/// </summary>
		public UCanvas CanvasForRenderingToTarget;
		
		public UCanvas CanvasForDrawMaterialToRenderTarget;
		
		/// <summary>All levels information from which our world is composed</summary>
		public UWorldComposition WorldComposition;
		
		/// <summary>Keeps track whether actors moved via PostEditMove and therefore constraint syncup should be performed.</summary>
		public bool bAreConstraintsDirty;
		
		
	}
	
}
