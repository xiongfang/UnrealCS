using System;
namespace UnrealEngine
{
	public partial class UInterpTrackSound:UInterpTrackVectorBase
	{
		/// <summary>if set, sound plays only when playing the matinee in reverse instead of when the matinee plays forward</summary>
		public bool bPlayOnReverse;
		
		/// <summary>If true, sounds on this track will not be forced to finish when the matinee sequence finishes.</summary>
		public bool bContinueSoundOnMatineeEnd;
		
		/// <summary>If true, don't show subtitles for sounds played by this track.</summary>
		public bool bSuppressSubtitles;
		
		/// <summary>If true and track is controlling a pawn, makes the pawn "speak" the given audio.</summary>
		public bool bTreatAsDialogue;
		
		public bool bAttach;
		
		
	}
	
}
