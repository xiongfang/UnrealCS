using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Options that define how to blend when changing view targets.
	/// @see FViewTargetTransitionParams, SetViewTarget
	/// </summary>
	public enum EViewTargetBlendFunction:byte
	{
		/// <summary>Camera does a simple linear interpolation.</summary>
		VTBlend_Linear=0,
		/// <summary>Camera has a slight ease in and ease out, but amount of ease cannot be tweaked.</summary>
		VTBlend_Cubic=1,
		/// <summary>Camera immediately accelerates, but smoothly decelerates into the target.  Ease amount controlled by BlendExp.</summary>
		VTBlend_EaseIn=2,
		/// <summary>Camera smoothly accelerates, but does not decelerate into the target.  Ease amount controlled by BlendExp.</summary>
		VTBlend_EaseOut=3,
		/// <summary>Camera smoothly accelerates and decelerates.  Ease amount controlled by BlendExp.</summary>
		VTBlend_EaseInOut=4,
		VTBlend_MAX=5,
		
	}
	
}
