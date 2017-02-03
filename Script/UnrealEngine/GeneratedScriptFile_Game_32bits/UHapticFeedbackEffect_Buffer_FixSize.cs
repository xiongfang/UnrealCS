#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UHapticFeedbackEffect_Buffer
	{
		static readonly int Amplitudes__Offset;
		public TStructArray<byte> Amplitudes
		{
			get{ CheckIsValid();return new TStructArray<byte>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Amplitudes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Amplitudes__Offset, false);}
			
		}
		
		static readonly int SampleRate__Offset;
		public int SampleRate
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SampleRate__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SampleRate__Offset, false);}
			
		}
		
		static UHapticFeedbackEffect_Buffer()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("HapticFeedbackEffect_Buffer");
			Amplitudes__Offset=GetPropertyOffset(NativeClassPtr,"Amplitudes");
			SampleRate__Offset=GetPropertyOffset(NativeClassPtr,"SampleRate");
			
		}
		
	}
	
}
#endif
#endif
