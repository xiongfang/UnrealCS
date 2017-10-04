using System;
namespace UnrealEngine
{
	/// <summary>Per-chunk authoring data.</summary>
	public partial struct FDestructibleChunkParameters
	{
		/// <summary>
		/// Defines the chunk to be environmentally supported, if the appropriate NxDestructibleParametersFlag flags
		/// are set in NxDestructibleParameters.
		/// Default = false.
		/// </summary>
		public bool bIsSupportChunk;
		/// <summary>
		/// Defines the chunk to be unfractureable.  If this is true, then none of its children will be fractureable.
		/// Default = false.
		/// </summary>
		public bool bDoNotFracture;
		/// <summary>
		/// Defines the chunk to be undamageable.  This means this chunk will not fracture, but its children might.
		/// Default = false.
		/// </summary>
		public bool bDoNotDamage;
		/// <summary>
		/// Defines the chunk to be uncrumbleable.  This means this chunk will not be broken down into fluid mesh particles
		/// no matter how much damage it takes.  Note: this only applies to chunks with no children.  For a chunk with
		/// children, then:
		/// 1) The chunk may be broken down into its children, and then its children may be crumbled, if the doNotCrumble flag
		/// is not set on them.
		/// 2) If the Destructible module's chunk depth offset LOD may be set such that this chunk effectively has no children.
		/// In this case, the doNotCrumble flag will apply to it.
		/// Default = false.
		/// </summary>
		public bool bDoNotCrumble;
		
	}
	
}
