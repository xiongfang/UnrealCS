#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackParticleReplay
	{
		static readonly int TrackKeys__Offset;
		/// <summary>Array of keys</summary>
		public TStructArray<FParticleReplayTrackKey> TrackKeys
		{
			get{ CheckIsValid();return new TStructArray<FParticleReplayTrackKey>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TrackKeys__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TrackKeys__Offset, false);}
			
		}
		
		static readonly int bIsCapturingReplay__Offset;
		/// <summary>True in the editor if track should be used to capture replay frames instead of play them back</summary>
		public bool bIsCapturingReplay
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsCapturingReplay__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int FixedTimeStep__Offset;
		/// <summary>Current replay fixed time quantum between frames (one over frame rate)</summary>
		public float FixedTimeStep
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FixedTimeStep__Offset, typeof(float));}
			
		}
		
		static UInterpTrackParticleReplay()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackParticleReplay");
			TrackKeys__Offset=GetPropertyOffset(NativeClassPtr,"TrackKeys");
			bIsCapturingReplay__Offset=GetPropertyOffset(NativeClassPtr,"bIsCapturingReplay");
			FixedTimeStep__Offset=GetPropertyOffset(NativeClassPtr,"FixedTimeStep");
			
		}
		
	}
	
}
#endif
#endif
