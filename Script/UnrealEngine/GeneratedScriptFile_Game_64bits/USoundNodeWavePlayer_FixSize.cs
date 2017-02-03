#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundNodeWavePlayer
	{
		static readonly int SoundWave__Offset;
		public USoundWave SoundWave
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SoundWave__Offset); if (v == IntPtr.Zero)return null; USoundWave retValue = new USoundWave(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bLooping__Offset;
		public bool bLooping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLooping__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLooping__Offset, 1,0,2,2);}
			
		}
		
		static USoundNodeWavePlayer()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeWavePlayer");
			SoundWave__Offset=GetPropertyOffset(NativeClassPtr,"SoundWave");
			bLooping__Offset=GetPropertyOffset(NativeClassPtr,"bLooping");
			
		}
		
	}
	
}
#endif
#endif
