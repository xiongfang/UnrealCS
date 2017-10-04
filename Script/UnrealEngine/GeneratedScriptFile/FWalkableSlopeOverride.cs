using System;
namespace UnrealEngine
{
	/// <summary>Struct allowing control over "walkable" normals, by allowing a restriction or relaxation of what steepness is normally walkable.</summary>
	public partial struct FWalkableSlopeOverride
	{
		/// <summary>
		/// Behavior of this surface (whether we affect the walkable slope).
		/// @see GetWalkableSlopeBehavior(), SetWalkableSlopeBehavior()
		/// </summary>
		public EWalkableSlopeBehavior WalkableSlopeBehavior;
		/// <summary>
		/// Override walkable slope angle (in degrees), applying the rules of the Walkable Slope Behavior.
		/// @see GetWalkableSlopeAngle(), SetWalkableSlopeAngle()
		/// </summary>
		public float WalkableSlopeAngle;
		
	}
	
}
