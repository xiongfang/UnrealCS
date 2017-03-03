#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AGameModeBase
	{
		static readonly int OptionsString__Offset;
		public FString OptionsString
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+OptionsString__Offset, typeof(FString));}
			
		}
		
		static readonly int GameSessionClass__Offset;
		public TSubclassOf<AGameSession>  GameSessionClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameSessionClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + GameSessionClass__Offset, value); }
			
		}
		
		static readonly int GameStateClass__Offset;
		public TSubclassOf<AGameStateBase>  GameStateClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameStateClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + GameStateClass__Offset, value); }
			
		}
		
		static readonly int PlayerControllerClass__Offset;
		public TSubclassOf<APlayerController>  PlayerControllerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlayerControllerClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + PlayerControllerClass__Offset, value); }
			
		}
		
		static readonly int PlayerStateClass__Offset;
		public TSubclassOf<APlayerState>  PlayerStateClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlayerStateClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + PlayerStateClass__Offset, value); }
			
		}
		
		static readonly int HUDClass__Offset;
		public TSubclassOf<AHUD>  HUDClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + HUDClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + HUDClass__Offset, value); }
			
		}
		
		static readonly int DefaultPawnClass__Offset;
		public TSubclassOf<APawn>  DefaultPawnClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultPawnClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + DefaultPawnClass__Offset, value); }
			
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
		
		static readonly int GameSession__Offset;
		public AGameSession GameSession
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameSession__Offset); if (v == IntPtr.Zero)return null; AGameSession retValue = new AGameSession(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int GameState__Offset;
		public AGameStateBase GameState
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameState__Offset); if (v == IntPtr.Zero)return null; AGameStateBase retValue = new AGameStateBase(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DefaultPlayerName__Offset;
		public string DefaultPlayerName
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+DefaultPlayerName__Offset, typeof(FText))).ToString();}
			set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+DefaultPlayerName__Offset, false);}
			
		}
		
		static readonly int bUseSeamlessTravel__Offset;
		public bool bUseSeamlessTravel
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseSeamlessTravel__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseSeamlessTravel__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bStartPlayersAsSpectators__Offset;
		public bool bStartPlayersAsSpectators
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStartPlayersAsSpectators__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bStartPlayersAsSpectators__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bPauseable__Offset;
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
