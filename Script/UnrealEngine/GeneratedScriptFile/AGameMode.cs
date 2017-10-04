using System;
namespace UnrealEngine
{
	public partial class AGameMode:AGameModeBase
	{
		/// <summary>Alters the synthetic bandwidth limit for a running game.</summary>
		public extern virtual void SetBandwidthLimit(float AsyncIOBandwidthLimit);
		/// <summary>Exec command to broadcast a string to all players</summary>
		public extern virtual void Say(FString Msg);
		/// <summary>Report that a match has failed due to unrecoverable error</summary>
		public extern virtual void AbortMatch();
		/// <summary>Restart the game, by default travel to the current map</summary>
		public extern virtual void RestartGame();
		/// <summary>Transition from InProgress to WaitingPostMatch. You can call this manually, will also get called if ReadyToEndMatch returns true</summary>
		public extern virtual void EndMatch();
		/// <summary>Transition from WaitingToStart to InProgress. You can call this manually, will also get called if ReadyToStartMatch returns true</summary>
		public extern virtual void StartMatch();
		/// <summary>Returns true if the match state is WaitingPostMatch or later</summary>
		public extern virtual bool HasMatchEnded();
		/// <summary>Returns true if the match state is InProgress or other gameplay state</summary>
		public extern virtual bool IsMatchInProgress();
		/// <summary>Returns the current match state, this is an accessor to protect the state machine flow</summary>
		public extern FName GetMatchState();
		/// <summary>What match state we are currently in</summary>
		public FName MatchState;
		
		/// <summary>Whether the game should immediately start when the first player logs in. Affects the default behavior of ReadyToStartMatch</summary>
		public bool bDelayedStart;
		
		/// <summary>Current number of spectators.</summary>
		public int NumSpectators;
		
		/// <summary>Current number of human players.</summary>
		public int NumPlayers;
		
		/// <summary>number of non-human players (AI controlled but participating as a player).</summary>
		public int NumBots;
		
		/// <summary>Minimum time before player can respawn after dying.</summary>
		public float MinRespawnDelay;
		
		/// <summary>Number of players that are still traveling from a previous map</summary>
		public int NumTravellingPlayers;
		
		/// <summary>Contains strings describing localized game agnostic messages.</summary>
		public TSubclassOf<ULocalMessage>  EngineMessageClass;
		
		/// <summary>Time a playerstate will stick around in an inactive state after a player logout</summary>
		public float InactivePlayerStateLifeSpan;
		
		/// <summary>If true, dedicated servers will record replays when HandleMatchHasStarted/HandleMatchHasStopped is called</summary>
		public bool bHandleDedicatedServerReplays;
		
		
	}
	
}
