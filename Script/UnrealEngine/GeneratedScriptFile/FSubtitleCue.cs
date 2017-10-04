using System;
namespace UnrealEngine
{
	/// <summary>A line of subtitle text and the time at which it should be displayed.</summary>
	public partial struct FSubtitleCue
	{
		/// <summary>The text to appear in the subtitle.</summary>
		public FText Text;
		/// <summary>The time at which the subtitle is to be displayed, in seconds relative to the beginning of the line.</summary>
		public float Time;
		
	}
	
}
