using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Movement modes for Characters.</summary>
	public enum EMovementMode:byte
	{
		/// <summary>None (movement is disabled).</summary>
		MOVE_None=0,
		/// <summary>Walking on a surface.</summary>
		MOVE_Walking=1,
		/// <summary>
		/// Simplified walking on navigation data (e.g. navmesh).
		/// If bGenerateOverlapEvents is true, then we will perform sweeps with each navmesh move.
		/// If bGenerateOverlapEvents is false then movement is cheaper but characters can overlap other objects without some extra process to repel/resolve their collisions.
		/// </summary>
		MOVE_NavWalking=2,
		/// <summary>Falling under the effects of gravity, such as after jumping or walking off the edge of a surface.</summary>
		MOVE_Falling=3,
		/// <summary>Swimming through a fluid volume, under the effects of gravity and buoyancy.</summary>
		MOVE_Swimming=4,
		/// <summary>Flying, ignoring the effects of gravity. Affected by the current physics volume's fluid friction.</summary>
		MOVE_Flying=5,
		/// <summary>User-defined custom movement mode, including many possible sub-modes.</summary>
		MOVE_Custom=6,
		MOVE_MAX=7,
		
	}
	
}
