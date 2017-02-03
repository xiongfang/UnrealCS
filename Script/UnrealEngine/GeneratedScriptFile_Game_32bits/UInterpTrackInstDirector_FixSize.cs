#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackInstDirector
	{
		static readonly int OldViewTarget__Offset;
		public AActor OldViewTarget
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + OldViewTarget__Offset); if (v == IntPtr.Zero)return null; AActor retValue = new AActor(); retValue._this = v; return retValue; }
			
		}
		
		static UInterpTrackInstDirector()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackInstDirector");
			OldViewTarget__Offset=GetPropertyOffset(NativeClassPtr,"OldViewTarget");
			
		}
		
	}
	
}
#endif
#endif
