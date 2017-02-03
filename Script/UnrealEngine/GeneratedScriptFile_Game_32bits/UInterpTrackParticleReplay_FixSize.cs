#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackParticleReplay
	{
		static readonly int TrackKeys__Offset;
		public TStructArray<FParticleReplayTrackKey> TrackKeys
		{
			get{ CheckIsValid();return new TStructArray<FParticleReplayTrackKey>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TrackKeys__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TrackKeys__Offset, false);}
			
		}
		
		static UInterpTrackParticleReplay()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackParticleReplay");
			TrackKeys__Offset=GetPropertyOffset(NativeClassPtr,"TrackKeys");
			
		}
		
	}
	
}
#endif
#endif
