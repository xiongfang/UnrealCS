#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAudioComponent
	{
		static readonly int Sound__Offset;
		public USoundBase Sound
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Sound__Offset); if (v == IntPtr.Zero)return null; USoundBase retValue = new USoundBase(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Sound__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Sound__Offset, value._this.Get()); }
			
		}
		
		static readonly int InstanceParameters__Offset;
		public TStructArray<FAudioComponentParam> InstanceParameters
		{
			get{ CheckIsValid();return new TStructArray<FAudioComponentParam>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InstanceParameters__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InstanceParameters__Offset, false);}
			
		}
		
		static readonly int SoundClassOverride__Offset;
		public USoundClass SoundClassOverride
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SoundClassOverride__Offset); if (v == IntPtr.Zero)return null; USoundClass retValue = new USoundClass(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SoundClassOverride__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SoundClassOverride__Offset, value._this.Get()); }
			
		}
		
		static readonly int bAutoDestroy__Offset;
		public bool bAutoDestroy
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoDestroy__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bStopWhenOwnerDestroyed__Offset;
		public bool bStopWhenOwnerDestroyed
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStopWhenOwnerDestroyed__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bShouldRemainActiveIfDropped__Offset;
		public bool bShouldRemainActiveIfDropped
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldRemainActiveIfDropped__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bAllowSpatialization__Offset;
		public bool bAllowSpatialization
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowSpatialization__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowSpatialization__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bOverrideAttenuation__Offset;
		public bool bOverrideAttenuation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideAttenuation__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideAttenuation__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bOverrideSubtitlePriority__Offset;
		public bool bOverrideSubtitlePriority
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideSubtitlePriority__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideSubtitlePriority__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bIsUISound__Offset;
		public bool bIsUISound
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsUISound__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsUISound__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bEnableLowPassFilter__Offset;
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
		public bool bSuppressSubtitles
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSuppressSubtitles__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSuppressSubtitles__Offset, 1,0,8,8);}
			
		}
		
		static readonly int PitchModulationMin__Offset;
		public float PitchModulationMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PitchModulationMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PitchModulationMin__Offset, false);}
			
		}
		
		static readonly int PitchModulationMax__Offset;
		public float PitchModulationMax
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PitchModulationMax__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PitchModulationMax__Offset, false);}
			
		}
		
		static readonly int VolumeModulationMin__Offset;
		public float VolumeModulationMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VolumeModulationMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VolumeModulationMin__Offset, false);}
			
		}
		
		static readonly int VolumeModulationMax__Offset;
		public float VolumeModulationMax
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VolumeModulationMax__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VolumeModulationMax__Offset, false);}
			
		}
		
		static readonly int VolumeMultiplier__Offset;
		public float VolumeMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VolumeMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VolumeMultiplier__Offset, false);}
			
		}
		
		static readonly int Priority__Offset;
		public float Priority
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Priority__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Priority__Offset, false);}
			
		}
		
		static readonly int SubtitlePriority__Offset;
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
		public float LowPassFilterFrequency
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LowPassFilterFrequency__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LowPassFilterFrequency__Offset, false);}
			
		}
		
		static readonly int AttenuationSettings__Offset;
		public USoundAttenuation AttenuationSettings
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AttenuationSettings__Offset); if (v == IntPtr.Zero)return null; USoundAttenuation retValue = new USoundAttenuation(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + AttenuationSettings__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + AttenuationSettings__Offset, value._this.Get()); }
			
		}
		
		static readonly int AttenuationOverrides__Offset;
		public FSoundAttenuationSettings AttenuationOverrides
		{
			get{ CheckIsValid();return (FSoundAttenuationSettings)Marshal.PtrToStructure(_this.Get()+AttenuationOverrides__Offset, typeof(FSoundAttenuationSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AttenuationOverrides__Offset, false);}
			
		}
		
		static readonly int ConcurrencySettings__Offset;
		public USoundConcurrency ConcurrencySettings
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConcurrencySettings__Offset); if (v == IntPtr.Zero)return null; USoundConcurrency retValue = new USoundConcurrency(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ConcurrencySettings__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ConcurrencySettings__Offset, value._this.Get()); }
			
		}
		
		static readonly int OnAudioFinished__Offset;
		public FMulticastScriptDelegate OnAudioFinished
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnAudioFinished__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnAudioFinished__Offset, false);}
			
		}
		
		static readonly int OnAudioPlaybackPercent__Offset;
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
