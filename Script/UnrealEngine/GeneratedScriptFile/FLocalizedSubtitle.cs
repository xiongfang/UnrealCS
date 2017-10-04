using System;
namespace UnrealEngine
{
	/// <summary>A subtitle localized to a specific language.</summary>
	public partial struct FLocalizedSubtitle
	{
		/// <summary>The 3-letter language for this subtitle</summary>
		public FString LanguageExt;
		/// <summary>true if this sound is considered to contain mature content.</summary>
		public bool bMature;
		/// <summary>true if the subtitles have been split manually.</summary>
		public bool bManualWordWrap;
		/// <summary>true if the subtitles should be displayed one line at a time.</summary>
		public bool bSingleLine;
		
	}
	
}
