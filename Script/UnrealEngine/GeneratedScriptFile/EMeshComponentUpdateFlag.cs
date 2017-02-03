using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Skinned Mesh Update Flag based on rendered or not.</summary>
	public enum EMeshComponentUpdateFlag:byte
	{
		/// <summary>Always Tick and Refresh BoneTransforms whether rendered or not.</summary>
		AlwaysTickPoseAndRefreshBones=0,
		/// <summary>Always Tick, but Refresh BoneTransforms only when rendered.</summary>
		AlwaysTickPose=1,
		/// <summary>Tick only when rendered, and it will only RefreshBoneTransforms when rendered.</summary>
		OnlyTickPoseWhenRendered=2,
		EMeshComponentUpdateFlag_MAX=3,
		
	}
	
}
