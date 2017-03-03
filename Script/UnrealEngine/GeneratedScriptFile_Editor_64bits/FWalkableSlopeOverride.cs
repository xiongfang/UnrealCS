#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Struct allowing control over "walkable" normals, by allowing a restriction or relaxation of what steepness is normally walkable.</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FWalkableSlopeOverride
	{
		/// <summary>
		/// Behavior of this surface (whether we affect the walkable slope).
		/// @see GetWalkableSlopeBehavior(), SetWalkableSlopeBehavior()
		/// </summary>
		[FieldOffset(0)]
		public EWalkableSlopeBehavior WalkableSlopeBehavior;
		/// <summary>
		/// Override walkable slope angle (in degrees), applying the rules of the Walkable Slope Behavior.
		/// @see GetWalkableSlopeAngle(), SetWalkableSlopeAngle()
		/// </summary>
		[FieldOffset(4)]
		public float WalkableSlopeAngle;
		
	}
	
}
#endif
#endif
