using System;
namespace UnrealEngine
{
	public partial class UInterpTrackVisibility:UInterpTrack
	{
		/// <summary>If events should be fired when passed playing the sequence forwards.</summary>
		public bool bFireEventsWhenForwards;
		
		/// <summary>If events should be fired when passed playing the sequence backwards.</summary>
		public bool bFireEventsWhenBackwards;
		
		/// <summary>If true, events on this track are fired even when jumping forwads through a sequence - for example, skipping a cinematic.</summary>
		public bool bFireEventsWhenJumpingForwards;
		
		
	}
	
}
