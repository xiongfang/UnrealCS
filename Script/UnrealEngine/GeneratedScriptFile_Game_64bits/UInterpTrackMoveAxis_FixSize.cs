#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackMoveAxis
	{
		static readonly int MoveAxis__Offset;
		public EInterpMoveAxis MoveAxis
		{
			get{ CheckIsValid();return (EInterpMoveAxis)Marshal.PtrToStructure(_this.Get()+MoveAxis__Offset, typeof(EInterpMoveAxis));}
			
		}
		
		static readonly int LookupTrack__Offset;
		public FInterpLookupTrack LookupTrack
		{
			get{ CheckIsValid();return (FInterpLookupTrack)Marshal.PtrToStructure(_this.Get()+LookupTrack__Offset, typeof(FInterpLookupTrack));}
			
		}
		
		static UInterpTrackMoveAxis()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackMoveAxis");
			MoveAxis__Offset=GetPropertyOffset(NativeClassPtr,"MoveAxis");
			LookupTrack__Offset=GetPropertyOffset(NativeClassPtr,"LookupTrack");
			
		}
		
	}
	
}
#endif
#endif
