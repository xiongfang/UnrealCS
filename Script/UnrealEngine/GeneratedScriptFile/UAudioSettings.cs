using System;
namespace UnrealEngine
{
	public partial class UAudioSettings:UDeveloperSettings
	{
		/// <summary>The SoundClass assigned to newly created sounds</summary>
		public FStringAssetReference DefaultSoundClassName;
		
		/// <summary>The SoundConcurrency assigned to newly created sounds</summary>
		public FStringAssetReference DefaultSoundConcurrencyName;
		
		/// <summary>The SoundMix to use as base when no other system has specified a Base SoundMix</summary>
		public FStringAssetReference DefaultBaseSoundMix;
		
		/// <summary>Sound class to be used for the VOIP audio component</summary>
		public FStringAssetReference VoiPSoundClass;
		
		public float LowPassFilterResonance;
		
		/// <summary>How many streaming sounds can be played at the same time (if more are played they will be sorted by priority)</summary>
		public int MaximumConcurrentStreams;
		
		/// <summary>Allows sounds to play at 0 volume.</summary>
		public bool bAllowVirtualizedSounds;
		
		/// <summary>Disables master EQ effect in the audio DSP graph.</summary>
		public bool bDisableMasterEQ;
		
		/// <summary>Disables master reverb effect in the audio DSP graph.</summary>
		public bool bDisableMasterReverb;
		
		/// <summary>Enables the surround sound spatialization calculations to include the center channel.</summary>
		public bool bAllowCenterChannel3DPanning;
		
		/// <summary>
		/// The format string to use when generating the filename for contexts within dialogue waves. This must generate unique names for your project.
		/// Available format markers:
		///   * {DialogueGuid} - The GUID of the dialogue wave. Guaranteed to be unique and stable against asset renames.
		///   * {DialogueHash} - The hash of the dialogue wave. Not guaranteed to be unique or stable against asset renames, however may be unique enough if combined with the dialogue name.
		///   * {DialogueName} - The name of the dialogue wave. Not guaranteed to be unique or stable against asset renames, however may be unique enough if combined with the dialogue hash.
		///   * {ContextId}    - The ID of the context. Guaranteed to be unique within its dialogue wave. Not guaranteed to be stable against changes to the context.
		///   * {ContextIndex} - The index of the context within its parent dialogue wave. Guaranteed to be unique within its dialogue wave. Not guaranteed to be stable against contexts being removed.
		/// </summary>
		public FString DialogueFilenameFormat;
		
		
	}
	
}
