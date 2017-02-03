using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Root Bone Lock options when extracting Root Motion.</summary>
	public enum ERootMotionRootLock:byte
	{
		/// <summary>Use reference pose root bone position.</summary>
		RefPose=0,
		/// <summary>Use root bone position on first frame of animation.</summary>
		AnimFirstFrame=1,
		/// <summary>FTransform::Identity.</summary>
		Zero=2,
		ERootMotionRootLock_MAX=3,
		
	}
	
}
