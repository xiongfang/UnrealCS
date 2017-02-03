#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackInstMove
	{
		static readonly int ResetLocation__Offset;
		public FVector ResetLocation
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+ResetLocation__Offset, typeof(FVector));}
			
		}
		
		static readonly int ResetRotation__Offset;
		public FRotator ResetRotation
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+ResetRotation__Offset, typeof(FRotator));}
			
		}
		
		static UInterpTrackInstMove()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackInstMove");
			ResetLocation__Offset=GetPropertyOffset(NativeClassPtr,"ResetLocation");
			ResetRotation__Offset=GetPropertyOffset(NativeClassPtr,"ResetRotation");
			
		}
		
	}
	
}
#endif
#endif
