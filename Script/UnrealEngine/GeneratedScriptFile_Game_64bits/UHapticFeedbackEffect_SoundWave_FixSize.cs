#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UHapticFeedbackEffect_SoundWave
	{
		static readonly int SoundWave__Offset;
		public USoundWave SoundWave
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SoundWave__Offset); if (v == IntPtr.Zero)return null; USoundWave retValue = new USoundWave(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SoundWave__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SoundWave__Offset, value._this.Get()); }
			
		}
		
		static UHapticFeedbackEffect_SoundWave()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("HapticFeedbackEffect_SoundWave");
			SoundWave__Offset=GetPropertyOffset(NativeClassPtr,"SoundWave");
			
		}
		
	}
	
}
#endif
#endif
