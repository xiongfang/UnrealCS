#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackInstFloatProp
	{
		static readonly int ResetFloat__Offset;
		public float ResetFloat
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ResetFloat__Offset, typeof(float));}
			
		}
		
		static UInterpTrackInstFloatProp()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackInstFloatProp");
			ResetFloat__Offset=GetPropertyOffset(NativeClassPtr,"ResetFloat");
			
		}
		
	}
	
}
#endif
#endif
