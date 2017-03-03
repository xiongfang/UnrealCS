#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneAudioSection
	{
		static readonly int Sound__Offset;
		public USoundBase Sound
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Sound__Offset); if (v == IntPtr.Zero)return null; USoundBase retValue = new USoundBase(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Sound__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Sound__Offset, value._this.Get()); }
			
		}
		
		static readonly int StartOffset__Offset;
		public float StartOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StartOffset__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartOffset__Offset, false);}
			
		}
		
		static readonly int AudioStartTime__Offset;
		public float AudioStartTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AudioStartTime__Offset, typeof(float));}
			
		}
		
		static readonly int AudioDilationFactor__Offset;
		public float AudioDilationFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AudioDilationFactor__Offset, typeof(float));}
			
		}
		
		static readonly int AudioVolume__Offset;
		public float AudioVolume
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AudioVolume__Offset, typeof(float));}
			
		}
		
		static readonly int SoundVolume__Offset;
		public FRichCurve SoundVolume
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+SoundVolume__Offset, typeof(FRichCurve));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SoundVolume__Offset, false);}
			
		}
		
		static readonly int PitchMultiplier__Offset;
		public FRichCurve PitchMultiplier
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+PitchMultiplier__Offset, typeof(FRichCurve));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PitchMultiplier__Offset, false);}
			
		}
		
		static readonly int bSuppressSubtitles__Offset;
		public bool bSuppressSubtitles
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSuppressSubtitles__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSuppressSubtitles__Offset, 1,0,1,255);}
			
		}
		
		static UMovieSceneAudioSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneAudioSection");
			Sound__Offset=GetPropertyOffset(NativeClassPtr,"Sound");
			StartOffset__Offset=GetPropertyOffset(NativeClassPtr,"StartOffset");
			AudioStartTime__Offset=GetPropertyOffset(NativeClassPtr,"AudioStartTime");
			AudioDilationFactor__Offset=GetPropertyOffset(NativeClassPtr,"AudioDilationFactor");
			AudioVolume__Offset=GetPropertyOffset(NativeClassPtr,"AudioVolume");
			SoundVolume__Offset=GetPropertyOffset(NativeClassPtr,"SoundVolume");
			PitchMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"PitchMultiplier");
			bSuppressSubtitles__Offset=GetPropertyOffset(NativeClassPtr,"bSuppressSubtitles");
			
		}
		
	}
	
}
#endif
#endif
