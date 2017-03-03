#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AGameState
	{
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
