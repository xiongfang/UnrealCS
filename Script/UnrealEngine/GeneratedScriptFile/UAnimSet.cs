using System;
namespace UnrealEngine
{
	public partial class UAnimSet:UObject
	{
		/// <summary>
		/// Indicates that only the rotation should be taken from the animation sequence and the translation should come from the USkeletalMesh ref pose.
		/// Note that the root bone always takes translation from the animation, even if this flag is set.
		/// You can use the UseTranslationBoneNames array to specify other bones that should use translation with this flag set.
		/// </summary>
		public bool bAnimRotationOnly;
		
		/// <summary>In the AnimSetEditor, when you switch to this AnimSet, it sees if this skeletal mesh is loaded and if so switches to it.</summary>
		public FName PreviewSkelMeshName;
		
		/// <summary>Holds the name of the skeletal mesh whose reference skeleton best matches the TrackBoneName array.</summary>
		public FName BestRatioSkelMeshName;
		
		
	}
	
}
