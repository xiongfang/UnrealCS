using System;
namespace UnrealEngine
{
	/// <summary>A pose for a skeletal mesh</summary>
	public partial struct FPoseSnapshot
	{
		/// <summary>The name of the skeletal mesh that was used to take this snapshot</summary>
		public FName SkeletalMeshName;
		/// <summary>The name for this snapshot</summary>
		public FName SnapshotName;
		/// <summary>Whether the pose is valid</summary>
		public bool bIsValid;
		
	}
	
}
