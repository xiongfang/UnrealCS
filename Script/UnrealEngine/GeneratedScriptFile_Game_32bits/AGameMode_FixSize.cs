#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AGameMode
	{
		static readonly int MatchState__Offset;
		public FName MatchState
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+MatchState__Offset, typeof(FName));}
			
		}
		
		static readonly int bUseSeamlessTravel__Offset;
		public bool bUseSeamlessTravel
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseSeamlessTravel__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseSeamlessTravel__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bPauseable__Offset;
		public bool bPauseable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPauseable__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPauseable__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bStartPlayersAsSpectators__Offset;
		public bool bStartPlayersAsSpectators
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStartPlayersAsSpectators__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bStartPlayersAsSpectators__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bDelayedStart__Offset;
		public bool bDelayedStart
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDelayedStart__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDelayedStart__Offset, 1,0,8,8);}
			
		}
		
		static readonly int OptionsString__Offset;
		public FString OptionsString
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+OptionsString__Offset, typeof(FString));}
			
		}
		
		static readonly int DefaultPawnClass__Offset;
		public TSubclassOf<APawn>  DefaultPawnClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultPawnClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + DefaultPawnClass__Offset, value); }
			
		}
		
		static readonly int HUDClass__Offset;
		public TSubclassOf<AHUD>  HUDClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + HUDClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + HUDClass__Offset, value); }
			
		}
		
		static readonly int NumSpectators__Offset;
		public int NumSpectators
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumSpectators__Offset, typeof(int));}
			
		}
		
		static readonly int NumPlayers__Offset;
		public int NumPlayers
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumPlayers__Offset, typeof(int));}
			
		}
		
		static readonly int NumBots__Offset;
		public int NumBots
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumBots__Offset, typeof(int));}
			
		}
		
		static readonly int MinRespawnDelay__Offset;
		public float MinRespawnDelay
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinRespawnDelay__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinRespawnDelay__Offset, false);}
			
		}
		
		static readonly int GameSession__Offset;
		public AGameSession GameSession
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameSession__Offset); if (v == IntPtr.Zero)return null; AGameSession retValue = new AGameSession(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NumTravellingPlayers__Offset;
		public int NumTravellingPlayers
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumTravellingPlayers__Offset, typeof(int));}
			
		}
		
		static readonly int DefaultPlayerName__Offset;
		public string DefaultPlayerName
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+DefaultPlayerName__Offset, typeof(FText))).ToString();}
			set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+DefaultPlayerName__Offset, false);}
			
		}
		
		static readonly int EngineMessageClass__Offset;
		public TSubclassOf<ULocalMessage>  EngineMessageClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + EngineMessageClass__Offset); return v; }
			
		}
		
		static readonly int PlayerControllerClass__Offset;
		public TSubclassOf<APlayerController>  PlayerControllerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlayerControllerClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + PlayerControllerClass__Offset, value); }
			
		}
		
		static readonly int SpectatorClass__Offset;
		public TSubclassOf<ASpectatorPawn>  SpectatorClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpectatorClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + SpectatorClass__Offset, value); }
			
		}
		
		static readonly int ReplaySpectatorPlayerControllerClass__Offset;
		public TSubclassOf<APlayerController>  ReplaySpectatorPlayerControllerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ReplaySpectatorPlayerControllerClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + ReplaySpectatorPlayerControllerClass__Offset, value); }
			
		}
		
		static readonly int PlayerStateClass__Offset;
		public TSubclassOf<APlayerState>  PlayerStateClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlayerStateClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + PlayerStateClass__Offset, value); }
			
		}
		
		static readonly int GameStateClass__Offset;
		public TSubclassOf<AGameState>  GameStateClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameStateClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + GameStateClass__Offset, value); }
			
		}
		
		static readonly int GameState__Offset;
		public AGameState GameState
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameState__Offset); if (v == IntPtr.Zero)return null; AGameState retValue = new AGameState(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int InactivePlayerArray__Offset;
		public TObjectArray<APlayerState>  InactivePlayerArray
		{
					get{ CheckIsValid();return new TObjectArray<APlayerState>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InactivePlayerArray__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InactivePlayerArray__Offset, false);}
			
		}
		
		static readonly int GameModeClassAliases__Offset;
		public TStructArray<FGameClassShortName> GameModeClassAliases
		{
			get{ CheckIsValid();return new TStructArray<FGameClassShortName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+GameModeClassAliases__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+GameModeClassAliases__Offset, false);}
			
		}
		
		static readonly int InactivePlayerStateLifeSpan__Offset;
		public float InactivePlayerStateLifeSpan
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InactivePlayerStateLifeSpan__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InactivePlayerStateLifeSpan__Offset, false);}
			
		}
		
		static readonly int bHandleDedicatedServerReplays__Offset;
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
