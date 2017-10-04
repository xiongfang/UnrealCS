using System;
namespace UnrealEngine
{
	public partial class UPoseAsset:UAnimationAsset
	{
		/// <summary>Animation Pose Data</summary>
		public FPoseDataContainer PoseContainer;
		
		/// <summary>Whether or not Additive Pose or not - these are property that needs post process, so</summary>
		public bool bAdditivePose;
		
		/// <summary>if -1, use ref pose</summary>
		public int BasePoseIndex;
		
		/// <summary>Base pose to use when retargeting</summary>
		public FName RetargetSource;
		
		public UAnimSequence SourceAnimation;
		
		
	}
	
}
