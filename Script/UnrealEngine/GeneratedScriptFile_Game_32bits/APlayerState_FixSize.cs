#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class APlayerState
	{
		static readonly int Score__Offset;
		public float Score
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Score__Offset, typeof(float));}
			
		}
		
		static readonly int Ping__Offset;
		public byte Ping
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+Ping__Offset, typeof(byte));}
			
		}
		
		static readonly int PlayerName__Offset;
		public FString PlayerName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+PlayerName__Offset, typeof(FString));}
			
		}
		
		static readonly int PlayerId__Offset;
		public int PlayerId
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PlayerId__Offset, typeof(int));}
			
		}
		
		static readonly int bIsSpectator__Offset;
		public bool bIsSpectator
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsSpectator__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bOnlySpectator__Offset;
		public bool bOnlySpectator
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOnlySpectator__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bIsABot__Offset;
		public bool bIsABot
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsABot__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bIsInactive__Offset;
		public bool bIsInactive
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsInactive__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bFromPreviousLevel__Offset;
		public bool bFromPreviousLevel
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFromPreviousLevel__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int StartTime__Offset;
		public int StartTime
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+StartTime__Offset, typeof(int));}
			
		}
		
		static readonly int EngineMessageClass__Offset;
		public TSubclassOf<ULocalMessage>  EngineMessageClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + EngineMessageClass__Offset); return v; }
			
		}
		
		static readonly int SavedNetworkAddress__Offset;
		public FString SavedNetworkAddress
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SavedNetworkAddress__Offset, typeof(FString));}
			
		}
		
		static readonly int UniqueId__Offset;
		public FUniqueNetIdRepl UniqueId
		{
			get{ CheckIsValid();return (FUniqueNetIdRepl)Marshal.PtrToStructure(_this.Get()+UniqueId__Offset, typeof(FUniqueNetIdRepl));}
			
		}
		
		static APlayerState()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PlayerState");
			Score__Offset=GetPropertyOffset(NativeClassPtr,"Score");
			Ping__Offset=GetPropertyOffset(NativeClassPtr,"Ping");
			PlayerName__Offset=GetPropertyOffset(NativeClassPtr,"PlayerName");
			PlayerId__Offset=GetPropertyOffset(NativeClassPtr,"PlayerId");
			bIsSpectator__Offset=GetPropertyOffset(NativeClassPtr,"bIsSpectator");
			bOnlySpectator__Offset=GetPropertyOffset(NativeClassPtr,"bOnlySpectator");
			bIsABot__Offset=GetPropertyOffset(NativeClassPtr,"bIsABot");
			bIsInactive__Offset=GetPropertyOffset(NativeClassPtr,"bIsInactive");
			bFromPreviousLevel__Offset=GetPropertyOffset(NativeClassPtr,"bFromPreviousLevel");
			StartTime__Offset=GetPropertyOffset(NativeClassPtr,"StartTime");
			EngineMessageClass__Offset=GetPropertyOffset(NativeClassPtr,"EngineMessageClass");
			SavedNetworkAddress__Offset=GetPropertyOffset(NativeClassPtr,"SavedNetworkAddress");
			UniqueId__Offset=GetPropertyOffset(NativeClassPtr,"UniqueId");
			
		}
		
	}
	
}
#endif
#endif
