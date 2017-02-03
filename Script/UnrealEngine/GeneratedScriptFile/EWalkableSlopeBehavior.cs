using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Controls behavior of WalkableSlopeOverride, determining how to affect walkability of surfaces for Characters.
	/// @see FWalkableSlopeOverride
	/// @see UCharacterMovementComponent::GetWalkableFloorAngle(), UCharacterMovementComponent::SetWalkableFloorAngle()
	/// </summary>
	public enum EWalkableSlopeBehavior:byte
	{
		/// <summary>Don't affect the walkable slope. Walkable slope angle will be ignored.</summary>
		WalkableSlope_Default=0,
		/// <summary>
		/// Increase walkable slope.
		/// Makes it easier to walk up a surface, by allowing traversal over higher-than-usual angles.
		/// @see FWalkableSlopeOverride::WalkableSlopeAngle
		/// </summary>
		WalkableSlope_Increase=1,
		/// <summary>
		/// Decrease walkable slope.
		/// Makes it harder to walk up a surface, by restricting traversal to lower-than-usual angles.
		/// @see FWalkableSlopeOverride::WalkableSlopeAngle
		/// </summary>
		WalkableSlope_Decrease=2,
		/// <summary>
		/// Make surface unwalkable.
		/// Note: WalkableSlopeAngle will be ignored.
		/// </summary>
		WalkableSlope_Unwalkable=3,
		WalkableSlope_Max=4,
		
	}
	
}
