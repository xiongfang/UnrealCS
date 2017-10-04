using System;
namespace UnrealEngine
{
	/// <summary>Movement capabilities, determining available movement options for Pawns and used by AI for reachability tests.</summary>
	public partial struct FMovementProperties
	{
		/// <summary>If true, this Pawn is capable of crouching.</summary>
		public bool bCanCrouch;
		/// <summary>If true, this Pawn is capable of jumping.</summary>
		public bool bCanJump;
		/// <summary>If true, this Pawn is capable of walking or moving on the ground.</summary>
		public bool bCanWalk;
		/// <summary>If true, this Pawn is capable of swimming or moving through fluid volumes.</summary>
		public bool bCanSwim;
		/// <summary>If true, this Pawn is capable of flying.</summary>
		public bool bCanFly;
		
	}
	
}
