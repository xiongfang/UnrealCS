#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>GameState is replicated and is valid on servers and clients.</summary>
	public partial class AGameState
	{
		static readonly int GameModeClass__Offset;
		/// <summary>Class of the server's game mode, assigned by GameMode.</summary>
		public TSubclassOf<AGameMode>  GameModeClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameModeClass__Offset); return v; }
			
		}
		
		static readonly int AuthorityGameMode__Offset;
		/// <summary>Instance of the current game mode, exists only on the server. For non-authority clients, this will be NULL.</summary>
		public AGameMode AuthorityGameMode
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AuthorityGameMode__Offset); if (v == IntPtr.Zero)return null; AGameMode retValue = new AGameMode(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SpectatorClass__Offset;
		/// <summary>Class used by spectators, assigned by GameMode.</summary>
		public TSubclassOf<ASpectatorPawn>  SpectatorClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpectatorClass__Offset); return v; }
			
		}
		
		static readonly int MatchState__Offset;
		/// <summary>What match state we are currently in</summary>
		public FName MatchState
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+MatchState__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MatchState__Offset, false);}
			
		}
		
		static readonly int PreviousMatchState__Offset;
		/// <summary>Previous map state, used to handle if multiple transitions happen per frame</summary>
		public FName PreviousMatchState
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+PreviousMatchState__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PreviousMatchState__Offset, false);}
			
		}
		
		static readonly int ElapsedTime__Offset;
		/// <summary>Elapsed game time since match has started.</summary>
		public int ElapsedTime
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ElapsedTime__Offset, typeof(int));}
			
		}
		
		static readonly int PlayerArray__Offset;
		/// <summary>Array of all PlayerStates, maintained on both server and clients (PlayerStates are always relevant)</summary>
		public TObjectArray<APlayerState>  PlayerArray
		{
					get{ CheckIsValid();return new TObjectArray<APlayerState>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PlayerArray__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PlayerArray__Offset, false);}
			
		}
		
		static readonly int ReplicatedWorldTimeSeconds__Offset;
		/// <summary>Server TimeSeconds. Useful for syncing up animation and gameplay.</summary>
		public float ReplicatedWorldTimeSeconds
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ReplicatedWorldTimeSeconds__Offset, typeof(float));}
			
		}
		
		static readonly int ServerWorldTimeSecondsDelta__Offset;
		/// <summary>The difference from the local world's TimeSeconds and the server world's TimeSeconds.</summary>
		public float ServerWorldTimeSecondsDelta
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ServerWorldTimeSecondsDelta__Offset, typeof(float));}
			
		}
		
		static readonly int ServerWorldTimeSecondsUpdateFrequency__Offset;
		/// <summary>Frequency that the server updates the replicated TimeSeconds from the world. Set to zero to disable periodic updates.</summary>
		public float ServerWorldTimeSecondsUpdateFrequency
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ServerWorldTimeSecondsUpdateFrequency__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ServerWorldTimeSecondsUpdateFrequency__Offset, false);}
			
		}
		
		static AGameState()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("GameState");
			GameModeClass__Offset=GetPropertyOffset(NativeClassPtr,"GameModeClass");
			AuthorityGameMode__Offset=GetPropertyOffset(NativeClassPtr,"AuthorityGameMode");
			SpectatorClass__Offset=GetPropertyOffset(NativeClassPtr,"SpectatorClass");
			MatchState__Offset=GetPropertyOffset(NativeClassPtr,"MatchState");
			PreviousMatchState__Offset=GetPropertyOffset(NativeClassPtr,"PreviousMatchState");
			ElapsedTime__Offset=GetPropertyOffset(NativeClassPtr,"ElapsedTime");
			PlayerArray__Offset=GetPropertyOffset(NativeClassPtr,"PlayerArray");
			ReplicatedWorldTimeSeconds__Offset=GetPropertyOffset(NativeClassPtr,"ReplicatedWorldTimeSeconds");
			ServerWorldTimeSecondsDelta__Offset=GetPropertyOffset(NativeClassPtr,"ServerWorldTimeSecondsDelta");
			ServerWorldTimeSecondsUpdateFrequency__Offset=GetPropertyOffset(NativeClassPtr,"ServerWorldTimeSecondsUpdateFrequency");
			
		}
		
	}
	
}
#endif
#endif
