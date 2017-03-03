#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// GameState is a subclass of GameStateBase that behaves like a multiplayer match-based game.
	/// It is tied to functionality in GameMode.
	/// </summary>
	public partial class AGameState
	{
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
		
		static AGameState()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("GameState");
			MatchState__Offset=GetPropertyOffset(NativeClassPtr,"MatchState");
			PreviousMatchState__Offset=GetPropertyOffset(NativeClassPtr,"PreviousMatchState");
			ElapsedTime__Offset=GetPropertyOffset(NativeClassPtr,"ElapsedTime");
			
		}
		
	}
	
}
#endif
#endif
