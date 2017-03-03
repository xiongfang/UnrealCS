#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// GameMode is a subclass of GameModeBase that behaves like a multiplayer match-based game.
	/// It has default behavior for picking spawn points and match state.
	/// If you want a simpler base, inherit from GameModeBase instead.
	/// </summary>
	public partial class AGameMode
	{
		static readonly int MatchState__Offset;
		/// <summary>What match state we are currently in</summary>
		public FName MatchState
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+MatchState__Offset, typeof(FName));}
			
		}
		
		static readonly int bDelayedStart__Offset;
		/// <summary>Whether the game should immediately start when the first player logs in. Affects the default behavior of ReadyToStartMatch</summary>
		public bool bDelayedStart
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDelayedStart__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDelayedStart__Offset, 1,0,1,1);}
			
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
		
		static readonly int NumTravellingPlayers__Offset;
		/// <summary>Number of players that are still traveling from a previous map</summary>
		public int NumTravellingPlayers
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumTravellingPlayers__Offset, typeof(int));}
			
		}
		
		static readonly int EngineMessageClass__Offset;
		/// <summary>Contains strings describing localized game agnostic messages.</summary>
		public TSubclassOf<ULocalMessage>  EngineMessageClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + EngineMessageClass__Offset); return v; }
			
		}
		
		static readonly int InactivePlayerArray__Offset;
		/// <summary>PlayerStates of players who have disconnected from the server (saved in case they reconnect)</summary>
		public TObjectArray<APlayerState>  InactivePlayerArray
		{
					get{ CheckIsValid();return new TObjectArray<APlayerState>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InactivePlayerArray__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InactivePlayerArray__Offset, false);}
			
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
			bDelayedStart__Offset=GetPropertyOffset(NativeClassPtr,"bDelayedStart");
			NumSpectators__Offset=GetPropertyOffset(NativeClassPtr,"NumSpectators");
			NumPlayers__Offset=GetPropertyOffset(NativeClassPtr,"NumPlayers");
			NumBots__Offset=GetPropertyOffset(NativeClassPtr,"NumBots");
			MinRespawnDelay__Offset=GetPropertyOffset(NativeClassPtr,"MinRespawnDelay");
			NumTravellingPlayers__Offset=GetPropertyOffset(NativeClassPtr,"NumTravellingPlayers");
			EngineMessageClass__Offset=GetPropertyOffset(NativeClassPtr,"EngineMessageClass");
			InactivePlayerArray__Offset=GetPropertyOffset(NativeClassPtr,"InactivePlayerArray");
			InactivePlayerStateLifeSpan__Offset=GetPropertyOffset(NativeClassPtr,"InactivePlayerStateLifeSpan");
			bHandleDedicatedServerReplays__Offset=GetPropertyOffset(NativeClassPtr,"bHandleDedicatedServerReplays");
			
		}
		
	}
	
}
#endif
#endif
