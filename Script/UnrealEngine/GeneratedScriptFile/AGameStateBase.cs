using System;
namespace UnrealEngine
{
	public partial class AGameStateBase:AInfo
	{
		/// <summary>Returns how much time needs to be spent before a player can respawn</summary>
		public extern virtual float GetPlayerRespawnDelay(AController Controller);
		/// <summary>Returns the time that should be used as when a player started</summary>
		public extern virtual float GetPlayerStartTime(AController Controller);
		/// <summary>Returns true if the world has started match (called MatchStarted callbacks)</summary>
		public extern virtual bool HasMatchStarted();
		/// <summary>Returns true if the world has started play (called BeginPlay on actors)</summary>
		public extern virtual bool HasBegunPlay();
		/// <summary>Returns the simulated TimeSeconds on the server, will be synchronized on client and server</summary>
		public extern virtual float GetServerWorldTimeSeconds();
		/// <summary>Class of the server's game mode, assigned by GameModeBase.</summary>
		public TSubclassOf<AGameModeBase>  GameModeClass;
		
		/// <summary>Instance of the current game mode, exists only on the server. For non-authority clients, this will be NULL.</summary>
		public AGameModeBase AuthorityGameMode;
		
		/// <summary>Class used by spectators, assigned by GameModeBase.</summary>
		public TSubclassOf<ASpectatorPawn>  SpectatorClass;
		
		/// <summary>Replicated when GameModeBase->StartPlay has been called so the client will also start play</summary>
		public bool bReplicatedHasBegunPlay;
		
		/// <summary>Server TimeSeconds. Useful for syncing up animation and gameplay.</summary>
		public float ReplicatedWorldTimeSeconds;
		
		/// <summary>The difference from the local world's TimeSeconds and the server world's TimeSeconds.</summary>
		public float ServerWorldTimeSecondsDelta;
		
		/// <summary>Frequency that the server updates the replicated TimeSeconds from the world. Set to zero to disable periodic updates.</summary>
		public float ServerWorldTimeSecondsUpdateFrequency;
		
		
	}
	
}
