using System;
namespace UnrealEngine
{
	public partial class UInterpTrackInstEvent:UInterpTrackInst
	{
		/// <summary>
		/// Position we were in last time we evaluated Events.
		/// During UpdateTrack, events between this time and the current time will be fired.
		/// </summary>
		public float LastUpdatePosition;
		
		
	}
	
}
