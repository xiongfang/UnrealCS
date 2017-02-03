using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>For an additive animation, indicates what the animation is relative to.</summary>
	public enum EAdditiveBasePoseType:byte
	{
		/// <summary>Will be deprecated.</summary>
		ABPT_None=0,
		/// <summary>Use the Skeleton's ref pose as base.</summary>
		ABPT_RefPose=1,
		/// <summary>Use a whole animation as a base pose. BasePoseSeq must be set.</summary>
		ABPT_AnimScaled=2,
		/// <summary>Use one frame of an animation as a base pose. BasePoseSeq and RefFrameIndex must be set (RefFrameIndex will be clamped).</summary>
		ABPT_AnimFrame=3,
		ABPT_MAX=4,
		
	}
	
}
