using System;
namespace UnrealEngine
{
	public partial class UInterpTrackParticleReplay:UInterpTrack
	{
		/// <summary>True in the editor if track should be used to capture replay frames instead of play them back</summary>
		public bool bIsCapturingReplay;
		
		/// <summary>Current replay fixed time quantum between frames (one over frame rate)</summary>
		public float FixedTimeStep;
		
		
	}
	
}
