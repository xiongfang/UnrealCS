#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Audio settings.</summary>
	public partial class UAudioSettings
	{
		static readonly int DefaultSoundClassName__Offset;
		/// <summary>The SoundClass assigned to newly created sounds</summary>
		public FStringAssetReference DefaultSoundClassName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+DefaultSoundClassName__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultSoundClassName__Offset, false);}
			
		}
		
		static readonly int DefaultSoundConcurrencyName__Offset;
		/// <summary>The SoundConcurrency assigned to newly created sounds</summary>
		public FStringAssetReference DefaultSoundConcurrencyName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+DefaultSoundConcurrencyName__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultSoundConcurrencyName__Offset, false);}
			
		}
		
		static readonly int DefaultBaseSoundMix__Offset;
		/// <summary>The SoundMix to use as base when no other system has specified a Base SoundMix</summary>
		public FStringAssetReference DefaultBaseSoundMix
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+DefaultBaseSoundMix__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultBaseSoundMix__Offset, false);}
			
		}
		
		static readonly int VoiPSoundClass__Offset;
		/// <summary>Sound class to be used for the VOIP audio component</summary>
		public FStringAssetReference VoiPSoundClass
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+VoiPSoundClass__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VoiPSoundClass__Offset, false);}
			
		}
		
		static readonly int LowPassFilterResonance__Offset;
		public float LowPassFilterResonance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LowPassFilterResonance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LowPassFilterResonance__Offset, false);}
			
		}
		
		static readonly int MaximumConcurrentStreams__Offset;
		/// <summary>How many streaming sounds can be played at the same time (if more are played they will be sorted by priority)</summary>
		public int MaximumConcurrentStreams
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaximumConcurrentStreams__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaximumConcurrentStreams__Offset, false);}
			
		}
		
		static readonly int QualityLevels__Offset;
		public TStructArray<FAudioQualitySettings> QualityLevels
		{
			get{ CheckIsValid();return new TStructArray<FAudioQualitySettings>((FScriptArray)Marshal.PtrToStructure(_this.Get()+QualityLevels__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+QualityLevels__Offset, false);}
			
		}
		
		static readonly int bAllowVirtualizedSounds__Offset;
		/// <summary>Allows sounds to play at 0 volume.</summary>
		public bool bAllowVirtualizedSounds
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowVirtualizedSounds__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowVirtualizedSounds__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bDisableMasterEQ__Offset;
		/// <summary>Disables master EQ effect in the audio DSP graph.</summary>
		public bool bDisableMasterEQ
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableMasterEQ__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableMasterEQ__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bDisableMasterReverb__Offset;
		/// <summary>Disables master reverb effect in the audio DSP graph.</summary>
		public bool bDisableMasterReverb
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableMasterReverb__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableMasterReverb__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bAllowCenterChannel3DPanning__Offset;
		/// <summary>Enables the surround sound spatialization calculations to include the center channel.</summary>
		public bool bAllowCenterChannel3DPanning
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowCenterChannel3DPanning__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowCenterChannel3DPanning__Offset, 1,0,8,8);}
			
		}
		
		static readonly int DialogueFilenameFormat__Offset;
		/// <summary>
		/// The format string to use when generating the filename for contexts within dialogue waves. This must generate unique names for your project.
		/// Available format markers:
		///   * {DialogueGuid} - The GUID of the dialogue wave. Guaranteed to be unique and stable against asset renames.
		///   * {DialogueHash} - The hash of the dialogue wave. Not guaranteed to be unique or stable against asset renames, however may be unique enough if combined with the dialogue name.
		///   * {DialogueName} - The name of the dialogue wave. Not guaranteed to be unique or stable against asset renames, however may be unique enough if combined with the dialogue hash.
		///   * {ContextId}    - The ID of the context. Guaranteed to be unique within its dialogue wave. Not guaranteed to be stable against changes to the context.
		///   * {ContextIndex} - The index of the context within its parent dialogue wave. Guaranteed to be unique within its dialogue wave. Not guaranteed to be stable against contexts being removed.
		/// </summary>
		public FString DialogueFilenameFormat
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+DialogueFilenameFormat__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DialogueFilenameFormat__Offset, false);}
			
		}
		
		static UAudioSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AudioSettings");
			DefaultSoundClassName__Offset=GetPropertyOffset(NativeClassPtr,"DefaultSoundClassName");
			DefaultSoundConcurrencyName__Offset=GetPropertyOffset(NativeClassPtr,"DefaultSoundConcurrencyName");
			DefaultBaseSoundMix__Offset=GetPropertyOffset(NativeClassPtr,"DefaultBaseSoundMix");
			VoiPSoundClass__Offset=GetPropertyOffset(NativeClassPtr,"VoiPSoundClass");
			LowPassFilterResonance__Offset=GetPropertyOffset(NativeClassPtr,"LowPassFilterResonance");
			MaximumConcurrentStreams__Offset=GetPropertyOffset(NativeClassPtr,"MaximumConcurrentStreams");
			QualityLevels__Offset=GetPropertyOffset(NativeClassPtr,"QualityLevels");
			bAllowVirtualizedSounds__Offset=GetPropertyOffset(NativeClassPtr,"bAllowVirtualizedSounds");
			bDisableMasterEQ__Offset=GetPropertyOffset(NativeClassPtr,"bDisableMasterEQ");
			bDisableMasterReverb__Offset=GetPropertyOffset(NativeClassPtr,"bDisableMasterReverb");
			bAllowCenterChannel3DPanning__Offset=GetPropertyOffset(NativeClassPtr,"bAllowCenterChannel3DPanning");
			DialogueFilenameFormat__Offset=GetPropertyOffset(NativeClassPtr,"DialogueFilenameFormat");
			
		}
		
	}
	
}
#endif
#endif
