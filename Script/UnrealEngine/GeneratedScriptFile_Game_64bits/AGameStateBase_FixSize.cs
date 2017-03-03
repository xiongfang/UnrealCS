#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AGameStateBase
	{
		static readonly int GameModeClass__Offset;
		public TSubclassOf<AGameModeBase>  GameModeClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameModeClass__Offset); return v; }
			
		}
		
		static readonly int AuthorityGameMode__Offset;
		public AGameModeBase AuthorityGameMode
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AuthorityGameMode__Offset); if (v == IntPtr.Zero)return null; AGameModeBase retValue = new AGameModeBase(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SpectatorClass__Offset;
		public TSubclassOf<ASpectatorPawn>  SpectatorClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpectatorClass__Offset); return v; }
			
		}
		
		static readonly int PlayerArray__Offset;
		public TObjectArray<APlayerState>  PlayerArray
		{
					get{ CheckIsValid();return new TObjectArray<APlayerState>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PlayerArray__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PlayerArray__Offset, false);}
			
		}
		
		static readonly int bReplicatedHasBegunPlay__Offset;
		public bool bReplicatedHasBegunPlay
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReplicatedHasBegunPlay__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int ReplicatedWorldTimeSeconds__Offset;
		public float ReplicatedWorldTimeSeconds
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ReplicatedWorldTimeSeconds__Offset, typeof(float));}
			
		}
		
		static readonly int ServerWorldTimeSecondsDelta__Offset;
		public float ServerWorldTimeSecondsDelta
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ServerWorldTimeSecondsDelta__Offset, typeof(float));}
			
		}
		
		static readonly int ServerWorldTimeSecondsUpdateFrequency__Offset;
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
