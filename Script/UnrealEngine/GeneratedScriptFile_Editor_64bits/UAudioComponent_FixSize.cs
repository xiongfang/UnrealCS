#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// AudioComponent is used to play a Sound
	/// @see https://docs.unrealengine.com/latest/INT/Audio/Overview/index.html
	/// @see USoundBase
	/// </summary>
	public partial class UAudioComponent
	{
		static readonly int Sound__Offset;
		/// <summary>The sound to be played</summary>
		public USoundBase Sound
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Sound__Offset); if (v == IntPtr.Zero)return null; USoundBase retValue = new USoundBase(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Sound__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Sound__Offset, value._this.Get()); }
			
		}
		
		static readonly int InstanceParameters__Offset;
		/// <summary>Array of per-instance parameters for this AudioComponent.</summary>
		public TStructArray<FAudioComponentParam> InstanceParameters
		{
			get{ CheckIsValid();return new TStructArray<FAudioComponentParam>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InstanceParameters__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InstanceParameters__Offset, false);}
			
		}
		
		static readonly int SoundClassOverride__Offset;
		/// <summary>Optional sound group this AudioComponent belongs to</summary>
		public USoundClass SoundClassOverride
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SoundClassOverride__Offset); if (v == IntPtr.Zero)return null; USoundClass retValue = new USoundClass(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SoundClassOverride__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SoundClassOverride__Offset, value._this.Get()); }
			
		}
		
		static readonly int bAutoDestroy__Offset;
		/// <summary>Auto destroy this component on completion</summary>
		public bool bAutoDestroy
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoDestroy__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bStopWhenOwnerDestroyed__Offset;
		/// <summary>Stop sound when owner is destroyed</summary>
		public bool bStopWhenOwnerDestroyed
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStopWhenOwnerDestroyed__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bShouldRemainActiveIfDropped__Offset;
		/// <summary>Whether the wave instances should remain active if they're dropped by the prioritization code. Useful for e.g. vehicle sounds that shouldn't cut out.</summary>
		public bool bShouldRemainActiveIfDropped
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldRemainActiveIfDropped__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bAllowSpatialization__Offset;
		/// <summary>Is this audio component allowed to be spatialized?</summary>
		public bool bAllowSpatialization
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowSpatialization__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowSpatialization__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bOverrideAttenuation__Offset;
		/// <summary>Should the Attenuation Settings asset be used (false) or should the properties set directly on the component be used for attenuation properties</summary>
		public bool bOverrideAttenuation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideAttenuation__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideAttenuation__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bOverrideSubtitlePriority__Offset;
		/// <summary>Whether or not to override the sound's subtitle priority.</summary>
		public bool bOverrideSubtitlePriority
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideSubtitlePriority__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideSubtitlePriority__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bIsUISound__Offset;
		/// <summary>Whether or not this sound plays when the game is paused in the UI</summary>
		public bool bIsUISound
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsUISound__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsUISound__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bEnableLowPassFilter__Offset;
		/// <summary>Whether or not to apply a low-pass filter to the sound that plays in this audio component.</summary>
		public bool bEnableLowPassFilter
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableLowPassFilter__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableLowPassFilter__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bOverridePriority__Offset;
		public bool bOverridePriority
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverridePriority__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverridePriority__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bSuppressSubtitles__Offset;
		/// <summary>If true, subtitles in the sound data will be ignored.</summary>
		public bool bSuppressSubtitles
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSuppressSubtitles__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSuppressSubtitles__Offset, 1,0,8,8);}
			
		}
		
		static readonly int PitchModulationMin__Offset;
		/// <summary>The lower bound to use when randomly determining a pitch multiplier</summary>
		public float PitchModulationMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PitchModulationMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PitchModulationMin__Offset, false);}
			
		}
		
		static readonly int PitchModulationMax__Offset;
		/// <summary>The upper bound to use when randomly determining a pitch multiplier</summary>
		public float PitchModulationMax
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PitchModulationMax__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PitchModulationMax__Offset, false);}
			
		}
		
		static readonly int VolumeModulationMin__Offset;
		/// <summary>The lower bound to use when randomly determining a volume multiplier</summary>
		public float VolumeModulationMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VolumeModulationMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VolumeModulationMin__Offset, false);}
			
		}
		
		static readonly int VolumeModulationMax__Offset;
		/// <summary>The upper bound to use when randomly determining a volume multiplier</summary>
		public float VolumeModulationMax
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VolumeModulationMax__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VolumeModulationMax__Offset, false);}
			
		}
		
		static readonly int VolumeMultiplier__Offset;
		/// <summary>A volume multiplier to apply to sounds generated by this component</summary>
		public float VolumeMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VolumeMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VolumeMultiplier__Offset, false);}
			
		}
		
		static readonly int Priority__Offset;
		/// <summary>A priority value that is used for sounds that play on this component that scales against final output volume.</summary>
		public float Priority
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Priority__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Priority__Offset, false);}
			
		}
		
		static readonly int SubtitlePriority__Offset;
		/// <summary>Used by the subtitle manager to prioritize subtitles wave instances spawned by this component.</summary>
		public float SubtitlePriority
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SubtitlePriority__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SubtitlePriority__Offset, false);}
			
		}
		
		static readonly int VolumeWeightedPriorityScale__Offset;
		public float VolumeWeightedPriorityScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VolumeWeightedPriorityScale__Offset, typeof(float));}
			
		}
		
		static readonly int PitchMultiplier__Offset;
		/// <summary>A pitch multiplier to apply to sounds generated by this component</summary>
		public float PitchMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PitchMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PitchMultiplier__Offset, false);}
			
		}
		
		static readonly int HighFrequencyGainMultiplier__Offset;
		public float HighFrequencyGainMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+HighFrequencyGainMultiplier__Offset, typeof(float));}
			
		}
		
		static readonly int LowPassFilterFrequency__Offset;
		/// <summary>The frequency of the lowpass filter (in hertz) to apply to this voice. A frequency of 0.0 is the device sample rate and will bypass the filter.</summary>
		public float LowPassFilterFrequency
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LowPassFilterFrequency__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LowPassFilterFrequency__Offset, false);}
			
		}
		
		static readonly int AttenuationSettings__Offset;
		/// <summary>If bOverrideSettings is false, the asset to use to determine attenuation properties for sounds generated by this component</summary>
		public USoundAttenuation AttenuationSettings
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AttenuationSettings__Offset); if (v == IntPtr.Zero)return null; USoundAttenuation retValue = new USoundAttenuation(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + AttenuationSettings__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + AttenuationSettings__Offset, value._this.Get()); }
			
		}
		
		static readonly int AttenuationOverrides__Offset;
		/// <summary>If bOverrideSettings is true, the attenuation properties to use for sounds generated by this component</summary>
		public FSoundAttenuationSettings AttenuationOverrides
		{
			get{ CheckIsValid();return (FSoundAttenuationSettings)Marshal.PtrToStructure(_this.Get()+AttenuationOverrides__Offset, typeof(FSoundAttenuationSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AttenuationOverrides__Offset, false);}
			
		}
		
		static readonly int ConcurrencySettings__Offset;
		/// <summary>What sound concurrency to use for sounds generated by this audio component</summary>
		public USoundConcurrency ConcurrencySettings
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConcurrencySettings__Offset); if (v == IntPtr.Zero)return null; USoundConcurrency retValue = new USoundConcurrency(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ConcurrencySettings__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ConcurrencySettings__Offset, value._this.Get()); }
			
		}
		
		static readonly int OnAudioFinished__Offset;
		/// <summary>called when we finish playing audio, either because it played to completion or because a Stop() call turned it off early</summary>
		public FMulticastScriptDelegate OnAudioFinished
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnAudioFinished__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnAudioFinished__Offset, false);}
			
		}
		
		static readonly int OnAudioPlaybackPercent__Offset;
		/// <summary>called when we finish playing audio, either because it played to completion or because a Stop() call turned it off early</summary>
		public FMulticastScriptDelegate OnAudioPlaybackPercent
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnAudioPlaybackPercent__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnAudioPlaybackPercent__Offset, false);}
			
		}
		
		static UAudioComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AudioComponent");
			Sound__Offset=GetPropertyOffset(NativeClassPtr,"Sound");
			InstanceParameters__Offset=GetPropertyOffset(NativeClassPtr,"InstanceParameters");
			SoundClassOverride__Offset=GetPropertyOffset(NativeClassPtr,"SoundClassOverride");
			bAutoDestroy__Offset=GetPropertyOffset(NativeClassPtr,"bAutoDestroy");
			bStopWhenOwnerDestroyed__Offset=GetPropertyOffset(NativeClassPtr,"bStopWhenOwnerDestroyed");
			bShouldRemainActiveIfDropped__Offset=GetPropertyOffset(NativeClassPtr,"bShouldRemainActiveIfDropped");
			bAllowSpatialization__Offset=GetPropertyOffset(NativeClassPtr,"bAllowSpatialization");
			bOverrideAttenuation__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideAttenuation");
			bOverrideSubtitlePriority__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideSubtitlePriority");
			bIsUISound__Offset=GetPropertyOffset(NativeClassPtr,"bIsUISound");
			bEnableLowPassFilter__Offset=GetPropertyOffset(NativeClassPtr,"bEnableLowPassFilter");
			bOverridePriority__Offset=GetPropertyOffset(NativeClassPtr,"bOverridePriority");
			bSuppressSubtitles__Offset=GetPropertyOffset(NativeClassPtr,"bSuppressSubtitles");
			PitchModulationMin__Offset=GetPropertyOffset(NativeClassPtr,"PitchModulationMin");
			PitchModulationMax__Offset=GetPropertyOffset(NativeClassPtr,"PitchModulationMax");
			VolumeModulationMin__Offset=GetPropertyOffset(NativeClassPtr,"VolumeModulationMin");
			VolumeModulationMax__Offset=GetPropertyOffset(NativeClassPtr,"VolumeModulationMax");
			VolumeMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"VolumeMultiplier");
			Priority__Offset=GetPropertyOffset(NativeClassPtr,"Priority");
			SubtitlePriority__Offset=GetPropertyOffset(NativeClassPtr,"SubtitlePriority");
			VolumeWeightedPriorityScale__Offset=GetPropertyOffset(NativeClassPtr,"VolumeWeightedPriorityScale");
			PitchMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"PitchMultiplier");
			HighFrequencyGainMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"HighFrequencyGainMultiplier");
			LowPassFilterFrequency__Offset=GetPropertyOffset(NativeClassPtr,"LowPassFilterFrequency");
			AttenuationSettings__Offset=GetPropertyOffset(NativeClassPtr,"AttenuationSettings");
			AttenuationOverrides__Offset=GetPropertyOffset(NativeClassPtr,"AttenuationOverrides");
			ConcurrencySettings__Offset=GetPropertyOffset(NativeClassPtr,"ConcurrencySettings");
			OnAudioFinished__Offset=GetPropertyOffset(NativeClassPtr,"OnAudioFinished");
			OnAudioPlaybackPercent__Offset=GetPropertyOffset(NativeClassPtr,"OnAudioPlaybackPercent");
			
		}
		
	}
	
}
#endif
#endif
