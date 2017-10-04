using System;
namespace UnrealEngine
{
	/// <summary>A set of parameters to describe how to transition between view targets.</summary>
	public partial struct FViewTargetTransitionParams
	{
		/// <summary>Total duration of blend to pending view target. 0 means no blending.</summary>
		public float BlendTime;
		/// <summary>Function to apply to the blend parameter.</summary>
		public EViewTargetBlendFunction BlendFunction;
		/// <summary>Exponent, used by certain blend functions to control the shape of the curve.</summary>
		public float BlendExp;
		/// <summary>
		/// If true, lock outgoing viewtarget to last frame's camera POV for the remainder of the blend.
		/// This is useful if you plan to teleport the old viewtarget, but don't want to affect the blend.
		/// </summary>
		public bool bLockOutgoing;
		
	}
	
}
