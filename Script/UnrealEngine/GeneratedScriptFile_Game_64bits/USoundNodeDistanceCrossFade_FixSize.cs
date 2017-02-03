#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundNodeDistanceCrossFade
	{
		static readonly int CrossFadeInput__Offset;
		public TStructArray<FDistanceDatum> CrossFadeInput
		{
			get{ CheckIsValid();return new TStructArray<FDistanceDatum>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CrossFadeInput__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CrossFadeInput__Offset, false);}
			
		}
		
		static USoundNodeDistanceCrossFade()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeDistanceCrossFade");
			CrossFadeInput__Offset=GetPropertyOffset(NativeClassPtr,"CrossFadeInput");
			
		}
		
	}
	
}
#endif
#endif
