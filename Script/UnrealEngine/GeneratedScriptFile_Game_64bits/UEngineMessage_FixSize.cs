#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UEngineMessage
	{
		static readonly int FailedPlaceMessage__Offset;
		public FString FailedPlaceMessage
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+FailedPlaceMessage__Offset, typeof(FString));}
			
		}
		
		static readonly int MaxedOutMessage__Offset;
		public FString MaxedOutMessage
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+MaxedOutMessage__Offset, typeof(FString));}
			
		}
		
		static readonly int EnteredMessage__Offset;
		public FString EnteredMessage
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+EnteredMessage__Offset, typeof(FString));}
			
		}
		
		static readonly int LeftMessage__Offset;
		public FString LeftMessage
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+LeftMessage__Offset, typeof(FString));}
			
		}
		
		static readonly int GlobalNameChange__Offset;
		public FString GlobalNameChange
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+GlobalNameChange__Offset, typeof(FString));}
			
		}
		
		static readonly int SpecEnteredMessage__Offset;
		public FString SpecEnteredMessage
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SpecEnteredMessage__Offset, typeof(FString));}
			
		}
		
		static readonly int NewPlayerMessage__Offset;
		public FString NewPlayerMessage
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+NewPlayerMessage__Offset, typeof(FString));}
			
		}
		
		static readonly int NewSpecMessage__Offset;
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
