using System;
namespace UnrealEngine
{
	/// <summary>Information for one cut in this track.</summary>
	public partial struct FDirectorTrackCut
	{
		/// <summary>Time to perform the cut.</summary>
		public float Time;
		/// <summary>Time taken to move view to new camera.</summary>
		public float TransitionTime;
		/// <summary>GroupName of UInterpGroup to cut viewpoint to.</summary>
		public FName TargetCamGroup;
		/// <summary>Shot number for developer reference</summary>
		public int ShotNumber;
		
	}
	
}
