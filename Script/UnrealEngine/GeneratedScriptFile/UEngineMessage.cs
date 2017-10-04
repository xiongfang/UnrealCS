using System;
namespace UnrealEngine
{
	public partial class UEngineMessage:ULocalMessage
	{
		/// <summary>Message displayed in message dialog when player pawn fails to spawn because no playerstart was available.</summary>
		public FString FailedPlaceMessage;
		
		/// <summary>Message when player join attempt is refused because the server is at capacity.</summary>
		public FString MaxedOutMessage;
		
		/// <summary>Message when a new player enters the game.</summary>
		public FString EnteredMessage;
		
		/// <summary>Message when a player leaves the game.</summary>
		public FString LeftMessage;
		
		/// <summary>Message when a player changes his name.</summary>
		public FString GlobalNameChange;
		
		/// <summary>Message when a new spectator enters the server (if spectator has a player name).</summary>
		public FString SpecEnteredMessage;
		
		/// <summary>Message when a new player enters the server (if player is unnamed).</summary>
		public FString NewPlayerMessage;
		
		/// <summary>Message when a new spectator enters the server (if spectator is unnamed).</summary>
		public FString NewSpecMessage;
		
		
	}
	
}
