using System;
namespace UnrealEngine
{
	/// <summary>Special hierarchy depths for various behaviors.</summary>
	public partial struct FDestructibleSpecialHierarchyDepths
	{
		/// <summary>
		/// The chunk hierarchy depth at which to create a support graph.  Higher depth levels give more detailed support,
		/// but will give a higher computational load.  Chunks below the support depth will never be supported.
		/// </summary>
		public int SupportDepth;
		/// <summary>The chunks will not be broken free below this depth.</summary>
		public int MinimumFractureDepth;
		/// <summary>
		/// Enables debris at a specific depth level.
		/// @see DebrisDepth
		/// </summary>
		public bool bEnableDebris;
		/// <summary>The hierarchy depth at which chunks are considered to be "debris."</summary>
		public int DebrisDepth;
		/// <summary>
		/// The chunk hierarchy depth up to which chunks will always be processed.  These chunks are considered
		/// to be essential either for gameplay or visually.
		/// The minimum value is 0, meaning the level 0 chunk is always considered essential.
		/// Default value is 0.
		/// </summary>
		public int EssentialDepth;
		
	}
	
}
