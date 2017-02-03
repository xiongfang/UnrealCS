#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// GameStateBase is a class that manages the game's global state, and is spawned by GameModeBase.
	/// It exists on both the client and the server and is fully replicated.
	/// </summary>
	public partial class AGameStateBase
	{
		static readonly int GameModeClass__Offset;
		/// <summary>Class of the server's game mode, assigned by GameModeBase.</summary>
		public TSubclassOf<AGameModeBase>  GameModeClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameModeClass__Offset); return v; }
			
		}
		
		static readonly int AuthorityGameMode__Offset;
		/// <summary>Instance of the current game mode, exists only on the server. For non-authority clients, this will be NULL.</summary>
		public AGameModeBase AuthorityGameMode
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AuthorityGameMode__Offset); if (v == IntPtr.Zero)return null; AGameModeBase retValue = new AGameModeBase(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SpectatorClass__Offset;
		/// <summary>Class used by spectators, assigned by GameModeBase.</summary>
		public TSubclassOf<ASpectatorPawn>  SpectatorClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpectatorClass__Offset); return v; }
			
		}
		
		static readonly int PlayerArray__Offset;
		/// <summary>Array of all PlayerStates, maintained on both server and clients (PlayerStates are always relevant)</summary>
		public TObjectArray<APlayerState>  PlayerArray
		{
					get{ CheckIsValid();return new TObjectArray<APlayerState>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PlayerArray__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PlayerArray__Offset, false);}
			
		}
		
		static readonly int bReplicatedHasBegunPlay__Offset;
		/// <summary>Replicated when GameModeBase->StartPlay has been called so the client will also start play</summary>
		public bool bReplicatedHasBegunPlay
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReplicatedHasBegunPlay__Offset, 1, 0, 1, 255);}
			
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
		
		static AGameStateBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("GameStateBase");
			GameModeClass__Offset=GetPropertyOffset(NativeClassPtr,"GameModeClass");
			AuthorityGameMode__Offset=GetPropertyOffset(NativeClassPtr,"AuthorityGameMode");
			SpectatorClass__Offset=GetPropertyOffset(NativeClassPtr,"SpectatorClass");
			PlayerArray__Offset=GetPropertyOffset(NativeClassPtr,"PlayerArray");
			bReplicatedHasBegunPlay__Offset=GetPropertyOffset(NativeClassPtr,"bReplicatedHasBegunPlay");
			ReplicatedWorldTimeSeconds__Offset=GetPropertyOffset(NativeClassPtr,"ReplicatedWorldTimeSeconds");
			ServerWorldTimeSecondsDelta__Offset=GetPropertyOffset(NativeClassPtr,"ServerWorldTimeSecondsDelta");
			ServerWorldTimeSecondsUpdateFrequency__Offset=GetPropertyOffset(NativeClassPtr,"ServerWorldTimeSecondsUpdateFrequency");
			
		}
		
	}
	
}
#endif
#endif
