using System;
namespace UnrealEngine
{
	public partial class AGameModeBase:AInfo
	{
		/// <summary>Tries to spawn the player's pawn at a specific location</summary>
		public extern virtual void RestartPlayerAtTransform(AController NewPlayer,FTransform SpawnTransform);
		/// <summary>Tries to spawn the player's pawn at the specified actor's location</summary>
		public extern virtual void RestartPlayerAtPlayerStart(AController NewPlayer,AActor StartSpot);
		/// <summary>Tries to spawn the player's pawn, at the location returned by FindPlayerStart</summary>
		public extern virtual void RestartPlayer(AController NewPlayer);
		/// <summary>
		/// Return the specific player start actor that should be used for the next spawn
		/// This will either use a previously saved startactor, or calls ChoosePlayerStart
		/// @param Player The AController for whom we are choosing a Player Start
		/// @param IncomingName Specifies the tag of a Player Start to use
		/// @returns Actor chosen as player start (usually a PlayerStart)
		/// </summary>
		public extern AActor K2_FindPlayerStart(AController Player,FString IncomingName);
		/// <summary>
		/// Sets the name for a controller
		/// @param Controller    The controller of the player to change the name of
		/// @param NewName               The name to set the player to
		/// @param bNameChange   Whether the name is changing or if this is the first time it has been set
		/// </summary>
		public extern virtual void ChangeName(AController Controller,FString NewName,bool bNameChange);
		/// <summary>Return to main menu, and disconnect any players</summary>
		public extern virtual void ReturnToMainMenuHost();
		/// <summary>
		/// Overridable function called when resetting level. This is used to reset the game state while staying in the same map
		/// Default implementation calls Reset() on all actors except GameMode and Controllers
		/// </summary>
		public extern virtual void ResetLevel();
		/// <summary>Returns true if the match start callbacks have been called</summary>
		public extern virtual bool HasMatchStarted();
		/// <summary>Transitions to calls BeginPlay on actors.</summary>
		public extern virtual void StartPlay();
		/// <summary>Returns number of human players currently spectating</summary>
		public extern virtual int GetNumSpectators();
		/// <summary>Returns number of active human players, excluding spectators</summary>
		public extern virtual int GetNumPlayers();
		/// <summary>Save options string and parse it when needed</summary>
		public FString OptionsString;
		
		/// <summary>Class of GameSession, which handles login approval and online game interface</summary>
		public TSubclassOf<AGameSession>  GameSessionClass;
		
		/// <summary>Class of GameState associated with this GameMode.</summary>
		public TSubclassOf<AGameStateBase>  GameStateClass;
		
		/// <summary>The class of PlayerController to spawn for players logging in.</summary>
		public TSubclassOf<APlayerController>  PlayerControllerClass;
		
		/// <summary>A PlayerState of this class will be associated with every player to replicate relevant player information to all clients.</summary>
		public TSubclassOf<APlayerState>  PlayerStateClass;
		
		/// <summary>HUD class this game uses.</summary>
		public TSubclassOf<AHUD>  HUDClass;
		
		/// <summary>The default pawn class used by players.</summary>
		public TSubclassOf<APawn>  DefaultPawnClass;
		
		/// <summary>The pawn class used by the PlayerController for players when spectating.</summary>
		public TSubclassOf<ASpectatorPawn>  SpectatorClass;
		
		/// <summary>The PlayerController class used when spectating a network replay.</summary>
		public TSubclassOf<APlayerController>  ReplaySpectatorPlayerControllerClass;
		
		/// <summary>Game Session handles login approval, arbitration, online game interface</summary>
		public AGameSession GameSession;
		
		/// <summary>GameState is used to replicate game state relevant properties to all clients.</summary>
		public AGameStateBase GameState;
		
		/// <summary>The default player name assigned to players that join with no name specified.</summary>
		public FText DefaultPlayerName;
		
		/// <summary>Whether the game perform map travels using SeamlessTravel() which loads in the background and doesn't disconnect clients</summary>
		public bool bUseSeamlessTravel;
		
		/// <summary>Whether players should immediately spawn when logging in, or stay as spectators until they manually spawn</summary>
		public bool bStartPlayersAsSpectators;
		
		/// <summary>Whether the game is pauseable.</summary>
		public bool bPauseable;
		
		
	}
	
}
