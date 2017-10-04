using System;
namespace UnrealEngine
{
	public partial class APlayerState:AInfo
	{
		public extern virtual void OnRep_UniqueId();
		public extern virtual void OnRep_bIsInactive();
		public extern virtual void OnRep_PlayerName();
		/// <summary>Replication Notification Callbacks</summary>
		public extern virtual void OnRep_Score();
		/// <summary>Player's current score.</summary>
		public float Score;
		
		/// <summary>Replicated compressed ping for this player (holds ping in msec divided by 4)</summary>
		public byte Ping;
		
		/// <summary>Player name, or blank if none.</summary>
		public FString PlayerName;
		
		/// <summary>Unique net id number. Actual value varies based on current online subsystem, use it only as a guaranteed unique number per player.</summary>
		public int PlayerId;
		
		/// <summary>Whether this player is currently a spectator</summary>
		public bool bIsSpectator;
		
		/// <summary>Whether this player can only ever be a spectator</summary>
		public bool bOnlySpectator;
		
		/// <summary>True if this PlayerState is associated with an AIController</summary>
		public bool bIsABot;
		
		/// <summary>Means this PlayerState came from the GameMode's InactivePlayerArray</summary>
		public bool bIsInactive;
		
		/// <summary>
		/// indicates this is a PlayerState from the previous level of a seamless travel,
		/// waiting for the player to finish the transition before creating a new one
		/// this is used to avoid preserving the PlayerState in the InactivePlayerArray if the player leaves
		/// </summary>
		public bool bFromPreviousLevel;
		
		/// <summary>Elapsed time on server when this PlayerState was first created.</summary>
		public int StartTime;
		
		/// <summary>This is used for sending game agnostic messages that can be localized</summary>
		public TSubclassOf<ULocalMessage>  EngineMessageClass;
		
		/// <summary>Used to match up InactivePlayerState with rejoining playercontroller.</summary>
		public FString SavedNetworkAddress;
		
		/// <summary>
		/// The id used by the network to uniquely identify a player.
		/// NOTE: the internals of this property should *never* be exposed to the player as it's transient
		/// and opaque in meaning (ie it might mean date/time followed by something else).
		/// It is OK to use and pass around this property, though.
		/// </summary>
		public FUniqueNetIdRepl UniqueId;
		
		
	}
	
}
