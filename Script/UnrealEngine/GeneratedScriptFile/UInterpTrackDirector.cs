using System;
namespace UnrealEngine
{
	public partial class UInterpTrackDirector:UInterpTrack
	{
		/// <summary>True to allow clients to simulate their own camera cuts.  Can help with latency-induced timing issues.</summary>
		public bool bSimulateCameraCutsOnClients;
		
		/// <summary>The camera actor which the track is currently focused on. Only valid if this track or it's group is selected</summary>
		public ACameraActor PreviewCamera;
		
		
	}
	
}
