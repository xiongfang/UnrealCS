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
		
		static readonly int bDelayedStart__Offset;
		public bool bDelayedStart
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDelayedStart__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDelayedStart__Offset, 1,0,1,1);}
			
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
		
		static readonly int NumTravellingPlayers__Offset;
		public int NumTravellingPlayers
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumTravellingPlayers__Offset, typeof(int));}
			
		}
		
		static readonly int EngineMessageClass__Offset;
		public TSubclassOf<ULocalMessage>  EngineMessageClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + EngineMessageClass__Offset); return v; }
			
		}
		
		static readonly int InactivePlayerArray__Offset;
		public TObjectArray<APlayerState>  InactivePlayerArray
		{
					get{ CheckIsValid();return new TObjectArray<APlayerState>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InactivePlayerArray__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InactivePlayerArray__Offset, false);}
			
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
