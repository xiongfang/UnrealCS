#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UEngineMessage
	{
		static readonly int FailedPlaceMessage__Offset;
		/// <summary>Message displayed in message dialog when player pawn fails to spawn because no playerstart was available.</summary>
		public FString FailedPlaceMessage
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+FailedPlaceMessage__Offset, typeof(FString));}
			
		}
		
		static readonly int MaxedOutMessage__Offset;
		/// <summary>Message when player join attempt is refused because the server is at capacity.</summary>
		public FString MaxedOutMessage
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+MaxedOutMessage__Offset, typeof(FString));}
			
		}
		
		static readonly int EnteredMessage__Offset;
		/// <summary>Message when a new player enters the game.</summary>
		public FString EnteredMessage
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+EnteredMessage__Offset, typeof(FString));}
			
		}
		
		static readonly int LeftMessage__Offset;
		/// <summary>Message when a player leaves the game.</summary>
		public FString LeftMessage
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+LeftMessage__Offset, typeof(FString));}
			
		}
		
		static readonly int GlobalNameChange__Offset;
		/// <summary>Message when a player changes his name.</summary>
		public FString GlobalNameChange
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+GlobalNameChange__Offset, typeof(FString));}
			
		}
		
		static readonly int SpecEnteredMessage__Offset;
		/// <summary>Message when a new spectator enters the server (if spectator has a player name).</summary>
		public FString SpecEnteredMessage
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SpecEnteredMessage__Offset, typeof(FString));}
			
		}
		
		static readonly int NewPlayerMessage__Offset;
		/// <summary>Message when a new player enters the server (if player is unnamed).</summary>
		public FString NewPlayerMessage
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+NewPlayerMessage__Offset, typeof(FString));}
			
		}
		
		static readonly int NewSpecMessage__Offset;
		/// <summary>Message when a new spectator enters the server (if spectator is unnamed).</summary>
		public FString NewSpecMessage
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+NewSpecMessage__Offset, typeof(FString));}
			
		}
		
		static UEngineMessage()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("EngineMessage");
			FailedPlaceMessage__Offset=GetPropertyOffset(NativeClassPtr,"FailedPlaceMessage");
			MaxedOutMessage__Offset=GetPropertyOffset(NativeClassPtr,"MaxedOutMessage");
			EnteredMessage__Offset=GetPropertyOffset(NativeClassPtr,"EnteredMessage");
			LeftMessage__Offset=GetPropertyOffset(NativeClassPtr,"LeftMessage");
			GlobalNameChange__Offset=GetPropertyOffset(NativeClassPtr,"GlobalNameChange");
			SpecEnteredMessage__Offset=GetPropertyOffset(NativeClassPtr,"SpecEnteredMessage");
			NewPlayerMessage__Offset=GetPropertyOffset(NativeClassPtr,"NewPlayerMessage");
			NewSpecMessage__Offset=GetPropertyOffset(NativeClassPtr,"NewSpecMessage");
			
		}
		
	}
	
}
#endif
#endif
