using System;
namespace UnrealEngine
{
	public partial class UDialogueWave:UObject
	{
		/// <summary>true if this dialogue is considered to contain mature/adult content.</summary>
		public bool bMature;
		
		public bool bOverride_SubtitleOverride;
		
		/// <summary>A localized version of the text that is actually spoken phonetically in the audio.</summary>
		public FString SpokenText;
		
		/// <summary>A localized version of the subtitle text that should be displayed for this audio. By default this will be the same as the Spoken Text.</summary>
		public FString SubtitleOverride;
		
		/// <summary>Provides general notes to the voice actor intended to direct their performance, as well as contextual information to the translator.</summary>
		public FString VoiceActorDirection;
		
		public FGuid LocalizationGUID;
		
		
	}
	
}
