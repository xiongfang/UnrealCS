using System;
namespace UnrealEngine
{
	public partial struct FDialogueContextMapping
	{
		/// <summary>The context of the dialogue.</summary>
		public FDialogueContext Context;
		/// <summary>The soundwave to play for this dialogue.</summary>
		public USoundWave SoundWave;
		/// <summary>
		/// The format string to use when generating the localization key for this context. This must be unique within the owner dialogue wave.
		/// Available format markers:
		///   * {ContextHash} - A hash generated from the speaker and target voices.
		/// </summary>
		public FString LocalizationKeyFormat;
		/// <summary>Cached object for playing the soundwave with subtitle information included.</summary>
		public UDialogueSoundWaveProxy Proxy;
		
	}
	
}
