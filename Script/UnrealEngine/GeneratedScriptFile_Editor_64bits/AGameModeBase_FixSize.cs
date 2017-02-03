#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// The GameModeBase defines the game being played. It governs the game rules, scoring, what actors
	/// are allowed to exist in this game type, and who may enter the game.
	/// It is only instanced on the server and will never exist on the client.
	/// A GameModeBase actor is instantiated when the level is initialized for gameplay in
	/// C++ UGameEngine::LoadMap().
	/// The class of this GameMode actor is determined by (in order) either the URL ?game=xxx,
	/// the GameMode Override value set in the World Settings, or the DefaultGameMode entry set
	/// in the game's Project Settings.
	/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Framework/GameMode/index.html
	/// </summary>
	public partial class AGameModeBase
	{
		static readonly int OptionsString__Offset;
		/// <summary>Save options string and parse it when needed</summary>
		public FString OptionsString
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+OptionsString__Offset, typeof(FString));}
			
		}
		
		static readonly int GameSessionClass__Offset;
		/// <summary>Class of GameSession, which handles login approval and online game interface</summary>
		public TSubclassOf<AGameSession>  GameSessionClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameSessionClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + GameSessionClass__Offset, value); }
			
		}
		
		static readonly int GameStateClass__Offset;
		/// <summary>Class of GameState associated with this GameMode.</summary>
		public TSubclassOf<AGameStateBase>  GameStateClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameStateClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + GameStateClass__Offset, value); }
			
		}
		
		static readonly int PlayerControllerClass__Offset;
		/// <summary>The class of PlayerController to spawn for players logging in.</summary>
		public TSubclassOf<APlayerController>  PlayerControllerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlayerControllerClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + PlayerControllerClass__Offset, value); }
			
		}
		
		static readonly int PlayerStateClass__Offset;
		/// <summary>A PlayerState of this class will be associated with every player to replicate relevant player information to all clients.</summary>
		public TSubclassOf<APlayerState>  PlayerStateClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlayerStateClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + PlayerStateClass__Offset, value); }
			
		}
		
		static readonly int HUDClass__Offset;
		/// <summary>HUD class this game uses.</summary>
		public TSubclassOf<AHUD>  HUDClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + HUDClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + HUDClass__Offset, value); }
			
		}
		
		static readonly int DefaultPawnClass__Offset;
		/// <summary>The default pawn class used by players.</summary>
		public TSubclassOf<APawn>  DefaultPawnClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultPawnClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + DefaultPawnClass__Offset, value); }
			
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
		
		static readonly int GameSession__Offset;
		/// <summary>Game Session handles login approval, arbitration, online game interface</summary>
		public AGameSession GameSession
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameSession__Offset); if (v == IntPtr.Zero)return null; AGameSession retValue = new AGameSession(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int GameState__Offset;
		/// <summary>GameState is used to replicate game state relevant properties to all clients.</summary>
		public AGameStateBase GameState
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameState__Offset); if (v == IntPtr.Zero)return null; AGameStateBase retValue = new AGameStateBase(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DefaultPlayerName__Offset;
		/// <summary>The default player name assigned to players that join with no name specified.</summary>
		public string DefaultPlayerName
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+DefaultPlayerName__Offset, typeof(FText))).ToString();}
			set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+DefaultPlayerName__Offset, false);}
			
		}
		
		static readonly int bUseSeamlessTravel__Offset;
		/// <summary>Whether the game perform map travels using SeamlessTravel() which loads in the background and doesn't disconnect clients</summary>
		public bool bUseSeamlessTravel
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseSeamlessTravel__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseSeamlessTravel__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bStartPlayersAsSpectators__Offset;
		/// <summary>Whether players should immediately spawn when logging in, or stay as spectators until they manually spawn</summary>
		public bool bStartPlayersAsSpectators
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStartPlayersAsSpectators__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bStartPlayersAsSpectators__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bPauseable__Offset;
		/// <summary>Whether the game is pauseable.</summary>
		public bool bPauseable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPauseable__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPauseable__Offset, 1,0,4,4);}
			
		}
		
		static AGameModeBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("GameModeBase");
			OptionsString__Offset=GetPropertyOffset(NativeClassPtr,"OptionsString");
			GameSessionClass__Offset=GetPropertyOffset(NativeClassPtr,"GameSessionClass");
			GameStateClass__Offset=GetPropertyOffset(NativeClassPtr,"GameStateClass");
			PlayerControllerClass__Offset=GetPropertyOffset(NativeClassPtr,"PlayerControllerClass");
			PlayerStateClass__Offset=GetPropertyOffset(NativeClassPtr,"PlayerStateClass");
			HUDClass__Offset=GetPropertyOffset(NativeClassPtr,"HUDClass");
			DefaultPawnClass__Offset=GetPropertyOffset(NativeClassPtr,"DefaultPawnClass");
			SpectatorClass__Offset=GetPropertyOffset(NativeClassPtr,"SpectatorClass");
			ReplaySpectatorPlayerControllerClass__Offset=GetPropertyOffset(NativeClassPtr,"ReplaySpectatorPlayerControllerClass");
			GameSession__Offset=GetPropertyOffset(NativeClassPtr,"GameSession");
			GameState__Offset=GetPropertyOffset(NativeClassPtr,"GameState");
			DefaultPlayerName__Offset=GetPropertyOffset(NativeClassPtr,"DefaultPlayerName");
			bUseSeamlessTravel__Offset=GetPropertyOffset(NativeClassPtr,"bUseSeamlessTravel");
			bStartPlayersAsSpectators__Offset=GetPropertyOffset(NativeClassPtr,"bStartPlayersAsSpectators");
			bPauseable__Offset=GetPropertyOffset(NativeClassPtr,"bPauseable");
			
		}
		
	}
	
}
#endif
#endif
