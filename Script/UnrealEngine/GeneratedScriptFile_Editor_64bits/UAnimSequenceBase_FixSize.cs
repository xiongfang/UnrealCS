#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimSequenceBase
	{
		static readonly int Notifies__Offset;
		/// <summary>Animation notifies, sorted by time (earliest notification first).</summary>
		public TStructArray<FAnimNotifyEvent> Notifies
		{
			get{ CheckIsValid();return new TStructArray<FAnimNotifyEvent>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Notifies__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Notifies__Offset, false);}
			
		}
		
		static readonly int SequenceLength__Offset;
		/// <summary>Length (in seconds) of this AnimSequence if played back with a speed of 1.0.</summary>
		public float SequenceLength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SequenceLength__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SequenceLength__Offset, false);}
			
		}
		
		static readonly int RateScale__Offset;
		/// <summary>Number for tweaking playback rate of this animation globally.</summary>
		public float RateScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RateScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RateScale__Offset, false);}
			
		}
		
		static readonly int RawCurveData__Offset;
		/// <summary>Raw uncompressed float curve data</summary>
		public FRawCurveTracks RawCurveData
		{
			get{ CheckIsValid();return (FRawCurveTracks)Marshal.PtrToStructure(_this.Get()+RawCurveData__Offset, typeof(FRawCurveTracks));}
			
		}
		
		static readonly int AnimNotifyTracks__Offset;
		/// <summary>if you change Notifies array, this will need to be rebuilt</summary>
		public TStructArray<FAnimNotifyTrack> AnimNotifyTracks
		{
			get{ CheckIsValid();return new TStructArray<FAnimNotifyTrack>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AnimNotifyTracks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AnimNotifyTracks__Offset, false);}
			
		}
		
		static UAnimSequenceBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimSequenceBase");
			Notifies__Offset=GetPropertyOffset(NativeClassPtr,"Notifies");
			SequenceLength__Offset=GetPropertyOffset(NativeClassPtr,"SequenceLength");
			RateScale__Offset=GetPropertyOffset(NativeClassPtr,"RateScale");
			RawCurveData__Offset=GetPropertyOffset(NativeClassPtr,"RawCurveData");
			AnimNotifyTracks__Offset=GetPropertyOffset(NativeClassPtr,"AnimNotifyTracks");
			
		}
		
	}
	
}
#endif
#endif
