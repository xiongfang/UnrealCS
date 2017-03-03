#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Audio section, for use in the master audio, or by attached audio objects</summary>
	public partial class UMovieSceneAudioSection
	{
		static readonly int Sound__Offset;
		/// <summary>The sound cue or wave that this section plays</summary>
		public USoundBase Sound
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Sound__Offset); if (v == IntPtr.Zero)return null; USoundBase retValue = new USoundBase(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Sound__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Sound__Offset, value._this.Get()); }
			
		}
		
		static readonly int StartOffset__Offset;
		/// <summary>The offset into the beginning of the audio clip</summary>
		public float StartOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StartOffset__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartOffset__Offset, false);}
			
		}
		
		static readonly int AudioStartTime__Offset;
		/// <summary>The absolute time that the sound starts playing at</summary>
		public float AudioStartTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AudioStartTime__Offset, typeof(float));}
			
		}
		
		static readonly int AudioDilationFactor__Offset;
		/// <summary>The amount which this audio is time dilated by</summary>
		public float AudioDilationFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AudioDilationFactor__Offset, typeof(float));}
			
		}
		
		static readonly int AudioVolume__Offset;
		/// <summary>The volume the sound will be played with.</summary>
		public float AudioVolume
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AudioVolume__Offset, typeof(float));}
			
		}
		
		static readonly int SoundVolume__Offset;
		/// <summary>The volume the sound will be played with.</summary>
		public FRichCurve SoundVolume
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+SoundVolume__Offset, typeof(FRichCurve));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SoundVolume__Offset, false);}
			
		}
		
		static readonly int PitchMultiplier__Offset;
		/// <summary>The pitch multiplier the sound will be played with.</summary>
		public FRichCurve PitchMultiplier
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+PitchMultiplier__Offset, typeof(FRichCurve));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PitchMultiplier__Offset, false);}
			
		}
		
		static readonly int bShowIntensity__Offset;
		/// <summary>Whether to show the actual intensity of the wave on the thumbnail, as well as the smoothed RMS</summary>
		public bool bShowIntensity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowIntensity__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShowIntensity__Offset, 1,0,1,255);}
			
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
			bShowIntensity__Offset=GetPropertyOffset(NativeClassPtr,"bShowIntensity");
			bSuppressSubtitles__Offset=GetPropertyOffset(NativeClassPtr,"bSuppressSubtitles");
			
		}
		
	}
	
}
#endif
#endif
