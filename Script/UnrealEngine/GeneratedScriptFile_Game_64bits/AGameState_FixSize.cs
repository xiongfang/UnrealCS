#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AGameState
	{
		static readonly int GameModeClass__Offset;
		public TSubclassOf<AGameMode>  GameModeClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameModeClass__Offset); return v; }
			
		}
		
		static readonly int AuthorityGameMode__Offset;
		public AGameMode AuthorityGameMode
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AuthorityGameMode__Offset); if (v == IntPtr.Zero)return null; AGameMode retValue = new AGameMode(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SpectatorClass__Offset;
		public TSubclassOf<ASpectatorPawn>  SpectatorClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpectatorClass__Offset); return v; }
			
		}
		
		static readonly int MatchState__Offset;
		public FName MatchState
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+MatchState__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MatchState__Offset, false);}
			
		}
		
		static readonly int PreviousMatchState__Offset;
		public FName PreviousMatchState
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+PreviousMatchState__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PreviousMatchState__Offset, false);}
			
		}
		
		static readonly int ElapsedTime__Offset;
		public int ElapsedTime
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ElapsedTime__Offset, typeof(int));}
			
		}
		
		static readonly int PlayerArray__Offset;
		public TObjectArray<APlayerState>  PlayerArray
		{
					get{ CheckIsValid();return new TObjectArray<APlayerState>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PlayerArray__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PlayerArray__Offset, false);}
			
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
