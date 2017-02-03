using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// This enum defines how you'd like to update bones to physics world.
	///       If bone is simulating, you don't have to waste time on updating bone transform from kinematic.
	///       But also sometimes you don't like fixed bones to be updated by animation data.
	/// </summary>
	public enum EKinematicBonesUpdateToPhysics:byte
	{
		/// <summary>Update any bones that are not simulating.</summary>
		SkipSimulatingBones=0,
		/// <summary>Skip physics update from kinematic changes.</summary>
		SkipAllBones=1,
		EKinematicBonesUpdateToPhysics_MAX=2,
		
	}
	
}
