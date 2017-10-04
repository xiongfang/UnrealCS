using System;
namespace UnrealEngine
{
	public partial struct FNavDataConfig
	{
		public FName Name;
		public FColor Color;
		public FVector DefaultQueryExtent;
		public TSubclassOf<ANavigationData>  NavigationDataClass;
		public FStringClassReference NavigationDataClassName;
		/// <summary>Radius of the capsule used for navigation/pathfinding.</summary>
		public float AgentRadius;
		/// <summary>Total height of the capsule used for navigation/pathfinding.</summary>
		public float AgentHeight;
		/// <summary>Step height to use, or -1 for default value from navdata's config.</summary>
		public float AgentStepHeight;
		/// <summary>Scale factor to apply to height of bounds when searching for navmesh to project to when nav walking</summary>
		public float NavWalkingSearchHeightScale;
		/// <summary>Type of navigation data used by agent, null means "any"</summary>
		public TSubclassOf<ANavigationData>  PreferredNavData;
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
