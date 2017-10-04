using System;
namespace UnrealEngine
{
	public partial class UInterpTrackToggle:UInterpTrack
	{
		/// <summary>
		/// If true, the track will call ActivateSystem on the emitter each update (the old 'incorrect' behavior).
		/// If false (the default), the System will only be activated if it was previously inactive.
		/// </summary>
		public bool bActivateSystemEachUpdate;
		
		/// <summary>If true, the track will activate the system w/ the 'Just Attached' flag.</summary>
		public bool bActivateWithJustAttachedFlag;
		
		/// <summary>If events should be fired when passed playing the sequence forwards.</summary>
		public bool bFireEventsWhenForwards;
		
		/// <summary>If events should be fired when passed playing the sequence backwards.</summary>
		public bool bFireEventsWhenBackwards;
		
		/// <summary>If true, events on this track are fired even when jumping forwads through a sequence - for example, skipping a cinematic.</summary>
		public bool bFireEventsWhenJumpingForwards;
		
		
	}
	
}
