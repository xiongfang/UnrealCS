#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// The GameMode defines the game being played. It governs the game rules, scoring, what actors
	/// are allowed to exist in this game type, and who may enter the game.
	/// It is only instanced on the server and will never exist on the client.
	/// A GameMode actor is instantiated when the level is initialized for gameplay in
	/// C++ UGameEngine::LoadMap().
	/// The class of this GameMode actor is determined by (in order) either the URL ?game=xxx,
	/// the GameMode Override value set in the World Settings, or the DefaultGameMode entry set
	/// in the game's Project Settings.
	/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Framework/GameMode/index.html
	/// </summary>
	public partial class AGameMode
	{
		static readonly int MatchState__Offset;
		/// <summary>What match state we are currently in</summary>
		public FName MatchState
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+MatchState__Offset, typeof(FName));}
			
		}
		
		static readonly int bUseSeamlessTravel__Offset;
		/// <summary>
		/// perform map travels using SeamlessTravel() which loads in the background and doesn't disconnect clients
		/// @see World::SeamlessTravel()
		/// </summary>
		public bool bUseSeamlessTravel
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseSeamlessTravel__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseSeamlessTravel__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bPauseable__Offset;
		/// <summary>Whether the game is pauseable.</summary>
		public bool bPauseable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPauseable__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPauseable__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bStartPlayersAsSpectators__Offset;
		/// <summary>Whether players should immediately spawn when logging in, or stay as spectators until they manually spawn</summary>
		public bool bStartPlayersAsSpectators
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStartPlayersAsSpectators__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bStartPlayersAsSpectators__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bDelayedStart__Offset;
		/// <summary>Whether the game should immediately start when the first player logs in. Affects the default behavior of ReadyToStartMatch</summary>
		public bool bDelayedStart
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDelayedStart__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDelayedStart__Offset, 1,0,8,8);}
			
		}
		
		static readonly int OptionsString__Offset;
		/// <summary>Save options string and parse it when needed</summary>
		public FString OptionsString
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+OptionsString__Offset, typeof(FString));}
			
		}
		
		static readonly int DefaultPawnClass__Offset;
		/// <summary>The default pawn class used by players.</summary>
		public TSubclassOf<APawn>  DefaultPawnClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultPawnClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + DefaultPawnClass__Offset, value); }
			
		}
		
		static readonly int HUDClass__Offset;
		/// <summary>HUD class this game uses.</summary>
		public TSubclassOf<AHUD>  HUDClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + HUDClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + HUDClass__Offset, value); }
			
		}
		
		static readonly int NumSpectators__Offset;
		/// <summary>Current number of spectators.</summary>
		public int NumSpectators
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumSpectators__Offset, typeof(int));}
			
		}
		
		static readonly int NumPlayers__Offset;
		/// <summary>Current number of human players.</summary>
		public int NumPlayers
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumPlayers__Offset, typeof(int));}
			
		}
		
		static readonly int NumBots__Offset;
		/// <summary>number of non-human players (AI controlled but participating as a player).</summary>
		public int NumBots
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumBots__Offset, typeof(int));}
			
		}
		
		static readonly int MinRespawnDelay__Offset;
		/// <summary>Minimum time before player can respawn after dying.</summary>
		public float MinRespawnDelay
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinRespawnDelay__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinRespawnDelay__Offset, false);}
			
		}
		
		static readonly int GameSession__Offset;
		/// <summary>Game Session handles login approval, arbitration, online game interface</summary>
		public AGameSession GameSession
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameSession__Offset); if (v == IntPtr.Zero)return null; AGameSession retValue = new AGameSession(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NumTravellingPlayers__Offset;
		/// <summary>Number of players that are still traveling from a previous map</summary>
		public int NumTravellingPlayers
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumTravellingPlayers__Offset, typeof(int));}
			
		}
		
		static readonly int DefaultPlayerName__Offset;
		/// <summary>The default player name assigned to players that join with no name specified.</summary>
		public string DefaultPlayerName
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+DefaultPlayerName__Offset, typeof(FText))).ToString();}
			set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+DefaultPlayerName__Offset, false);}
			
		}
		
		static readonly int EngineMessageClass__Offset;
		/// <summary>Contains strings describing localized game agnostic messages.</summary>
		public TSubclassOf<ULocalMessage>  EngineMessageClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + EngineMessageClass__Offset); return v; }
			
		}
		
		static readonly int PlayerControllerClass__Offset;
		/// <summary>The class of PlayerController to spawn for players logging in.</summary>
		public TSubclassOf<APlayerController>  PlayerControllerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlayerControllerClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + PlayerControllerClass__Offset, value); }
			
		}
		
		static readonly int SpectatorClass__Offset;
		/// <summary>The pawn class used by the PlayerController for players when spectating.</summary>
		public TSubclassOf<ASpectatorPawn>  SpectatorClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpectatorClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + SpectatorClass__Offset, value); }
			
		}
		
		static readonly int ReplaySpectatorPlayerControllerClass__Offset;
		/// <summary>The PlayerController class used when spectating a network replay.</summary>
		public TSubclassOf<APlayerController>  ReplaySpectatorPlayerControllerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ReplaySpectatorPlayerControllerClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + ReplaySpectatorPlayerControllerClass__Offset, value); }
			
		}
		
		static readonly int PlayerStateClass__Offset;
		/// <summary>A PlayerState of this class will be associated with every player to replicate relevant player information to all clients.</summary>
		public TSubclassOf<APlayerState>  PlayerStateClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlayerStateClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + PlayerStateClass__Offset, value); }
			
		}
		
		static readonly int GameStateClass__Offset;
		/// <summary>Class of GameState associated with this GameMode.</summary>
		public TSubclassOf<AGameState>  GameStateClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameStateClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + GameStateClass__Offset, value); }
			
		}
		
		static readonly int GameState__Offset;
		/// <summary>GameState is used to replicate game state relevant properties to all clients.</summary>
		public AGameState GameState
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameState__Offset); if (v == IntPtr.Zero)return null; AGameState retValue = new AGameState(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int InactivePlayerArray__Offset;
		/// <summary>PlayerStates of players who have disconnected from the server (saved in case they reconnect)</summary>
		public TObjectArray<APlayerState>  InactivePlayerArray
		{
					get{ CheckIsValid();return new TObjectArray<APlayerState>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InactivePlayerArray__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InactivePlayerArray__Offset, false);}
			
		}
		
		static readonly int GameModeClassAliases__Offset;
		/// <summary>Handy alternate short names for GameMode classes (e.g. "DM" could be an alias for "MyProject.MyGameModeMP_DM".</summary>
		public TStructArray<FGameClassShortName> GameModeClassAliases
		{
			get{ CheckIsValid();return new TStructArray<FGameClassShortName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+GameModeClassAliases__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+GameModeClassAliases__Offset, false);}
			
		}
		
		static readonly int InactivePlayerStateLifeSpan__Offset;
		/// <summary>Time a playerstate will stick around in an inactive state after a player logout</summary>
		public float InactivePlayerStateLifeSpan
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InactivePlayerStateLifeSpan__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InactivePlayerStateLifeSpan__Offset, false);}
			
		}
		
		static readonly int bHandleDedicatedServerReplays__Offset;
		/// <summary>If true, dedicated servers will record replays when HandleMatchHasStarted/HandleMatchHasStopped is called</summary>
		public bool bHandleDedicatedServerReplays
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHandleDedicatedServerReplays__Offset, 1, 0, 1, 255);}
			
		}
		
		static AGameMode()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("GameMode");
			MatchState__Offset=GetPropertyOffset(NativeClassPtr,"MatchState");
			bUseSeamlessTravel__Offset=GetPropertyOffset(NativeClassPtr,"bUseSeamlessTravel");
			bPauseable__Offset=GetPropertyOffset(NativeClassPtr,"bPauseable");
			bStartPlayersAsSpectators__Offset=GetPropertyOffset(NativeClassPtr,"bStartPlayersAsSpectators");
			bDelayedStart__Offset=GetPropertyOffset(NativeClassPtr,"bDelayedStart");
			OptionsString__Offset=GetPropertyOffset(NativeClassPtr,"OptionsString");
			DefaultPawnClass__Offset=GetPropertyOffset(NativeClassPtr,"DefaultPawnClass");
			HUDClass__Offset=GetPropertyOffset(NativeClassPtr,"HUDClass");
			NumSpectators__Offset=GetPropertyOffset(NativeClassPtr,"NumSpectators");
			NumPlayers__Offset=GetPropertyOffset(NativeClassPtr,"NumPlayers");
			NumBots__Offset=GetPropertyOffset(NativeClassPtr,"NumBots");
			MinRespawnDelay__Offset=GetPropertyOffset(NativeClassPtr,"MinRespawnDelay");
			GameSession__Offset=GetPropertyOffset(NativeClassPtr,"GameSession");
			NumTravellingPlayers__Offset=GetPropertyOffset(NativeClassPtr,"NumTravellingPlayers");
			DefaultPlayerName__Offset=GetPropertyOffset(NativeClassPtr,"DefaultPlayerName");
			EngineMessageClass__Offset=GetPropertyOffset(NativeClassPtr,"EngineMessageClass");
			PlayerControllerClass__Offset=GetPropertyOffset(NativeClassPtr,"PlayerControllerClass");
			SpectatorClass__Offset=GetPropertyOffset(NativeClassPtr,"SpectatorClass");
			ReplaySpectatorPlayerControllerClass__Offset=GetPropertyOffset(NativeClassPtr,"ReplaySpectatorPlayerControllerClass");
			PlayerStateClass__Offset=GetPropertyOffset(NativeClassPtr,"PlayerStateClass");
			GameStateClass__Offset=GetPropertyOffset(NativeClassPtr,"GameStateClass");
			GameState__Offset=GetPropertyOffset(NativeClassPtr,"GameState");
			InactivePlayerArray__Offset=GetPropertyOffset(NativeClassPtr,"InactivePlayerArray");
			GameModeClassAliases__Offset=GetPropertyOffset(NativeClassPtr,"GameModeClassAliases");
			InactivePlayerStateLifeSpan__Offset=GetPropertyOffset(NativeClassPtr,"InactivePlayerStateLifeSpan");
			bHandleDedicatedServerReplays__Offset=GetPropertyOffset(NativeClassPtr,"bHandleDedicatedServerReplays");
			
		}
		
	}
	
}
#endif
#endif
