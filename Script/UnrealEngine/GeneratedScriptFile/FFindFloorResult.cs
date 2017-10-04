using System;
namespace UnrealEngine
{
	/// <summary>Data about the floor for walking movement, used by CharacterMovementComponent.</summary>
	public partial struct FFindFloorResult
	{
		/// <summary>
		/// True if there was a blocking hit in the floor test that was NOT in initial penetration.
		/// The HitResult can give more info about other circumstances.
		/// </summary>
		public bool bBlockingHit;
		/// <summary>True if the hit found a valid walkable floor.</summary>
		public bool bWalkableFloor;
		/// <summary>True if the hit found a valid walkable floor using a line trace (rather than a sweep test, which happens when the sweep test fails to yield a walkable surface).</summary>
		public bool bLineTrace;
		/// <summary>The distance to the floor, computed from the swept capsule trace.</summary>
		public float FloorDist;
		/// <summary>The distance to the floor, computed from the trace. Only valid if bLineTrace is true.</summary>
		public float LineDist;
		/// <summary>Hit result of the test that found a floor. Includes more specific data about the point of impact and surface normal at that point.</summary>
		public FHitResult HitResult;
		
	}
	
}
