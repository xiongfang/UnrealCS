#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A PlayerState is created for every player on a server (or in a standalone game).
	/// PlayerStates are replicated to all clients, and contain network game relevant information about the player, such as playername, score, etc.
	/// </summary>
	public partial class APlayerState
	{
		static readonly int Score__Offset;
		/// <summary>Player's current score.</summary>
		public float Score
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Score__Offset, typeof(float));}
			
		}
		
		static readonly int Ping__Offset;
		/// <summary>Replicated compressed ping for this player (holds ping in msec divided by 4)</summary>
		public byte Ping
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+Ping__Offset, typeof(byte));}
			
		}
		
		static readonly int PlayerName__Offset;
		/// <summary>Player name, or blank if none.</summary>
		public FString PlayerName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+PlayerName__Offset, typeof(FString));}
			
		}
		
		static readonly int PlayerId__Offset;
		/// <summary>Unique net id number. Actual value varies based on current online subsystem, use it only as a guaranteed unique number per player.</summary>
		public int PlayerId
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PlayerId__Offset, typeof(int));}
			
		}
		
		static readonly int bIsSpectator__Offset;
		/// <summary>Whether this player is currently a spectator</summary>
		public bool bIsSpectator
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsSpectator__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bOnlySpectator__Offset;
		/// <summary>Whether this player can only ever be a spectator</summary>
		public bool bOnlySpectator
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOnlySpectator__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bIsABot__Offset;
		/// <summary>True if this PlayerState is associated with an AIController</summary>
		public bool bIsABot
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsABot__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bIsInactive__Offset;
		/// <summary>Means this PlayerState came from the GameMode's InactivePlayerArray</summary>
		public bool bIsInactive
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsInactive__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bFromPreviousLevel__Offset;
		/// <summary>
		/// indicates this is a PlayerState from the previous level of a seamless travel,
		/// waiting for the player to finish the transition before creating a new one
		/// this is used to avoid preserving the PlayerState in the InactivePlayerArray if the player leaves
		/// </summary>
		public bool bFromPreviousLevel
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFromPreviousLevel__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int StartTime__Offset;
		/// <summary>Elapsed time on server when this PlayerState was first created.</summary>
		public int StartTime
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+StartTime__Offset, typeof(int));}
			
		}
		
		static readonly int EngineMessageClass__Offset;
		/// <summary>This is used for sending game agnostic messages that can be localized</summary>
		public TSubclassOf<ULocalMessage>  EngineMessageClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + EngineMessageClass__Offset); return v; }
			
		}
		
		static readonly int SavedNetworkAddress__Offset;
		/// <summary>Used to match up InactivePlayerState with rejoining playercontroller.</summary>
		public FString SavedNetworkAddress
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SavedNetworkAddress__Offset, typeof(FString));}
			
		}
		
		static readonly int UniqueId__Offset;
		/// <summary>
		/// The id used by the network to uniquely identify a player.
		/// NOTE: the internals of this property should *never* be exposed to the player as it's transient
		/// and opaque in meaning (ie it might mean date/time followed by something else).
		/// It is OK to use and pass around this property, though.
		/// </summary>
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
