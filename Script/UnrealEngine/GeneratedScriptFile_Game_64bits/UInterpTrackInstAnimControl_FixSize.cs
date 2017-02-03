#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackInstAnimControl
	{
		static readonly int LastUpdatePosition__Offset;
		public float LastUpdatePosition
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastUpdatePosition__Offset, typeof(float));}
			
		}
		
		static UInterpTrackInstAnimControl()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackInstAnimControl");
			LastUpdatePosition__Offset=GetPropertyOffset(NativeClassPtr,"LastUpdatePosition");
			
		}
		
	}
	
}
#endif
#endif
