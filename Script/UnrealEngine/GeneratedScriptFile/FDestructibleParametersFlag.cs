using System;
namespace UnrealEngine
{
	/// <summary>Flags that apply to a destructible actor.</summary>
	public partial struct FDestructibleParametersFlag
	{
		/// <summary>
		/// If set, chunks will "remember" damage applied to them, so that many applications of a damage amount
		/// below damageThreshold will eventually fracture the chunk.  If not set, a single application of
		/// damage must exceed damageThreshold in order to fracture the chunk.
		/// </summary>
		public bool bAccumulateDamage;
		/// <summary>
		/// If set, then chunks which are tagged as "support" chunks (via NxDestructibleChunkDesc::isSupportChunk)
		/// will have environmental support in static destructibles.
		/// Note: if both bAssetDefinedSupport and bWorldSupport are set, then chunks must be tagged as
		/// "support" chunks AND overlap the Scene's static geometry in order to be environmentally supported.
		/// </summary>
		public bool bAssetDefinedSupport;
		/// <summary>
		/// If set, then chunks which overlap the Scene's static geometry will have environmental support in
		/// static destructibles.
		/// Note: if both bAssetDefinedSupport and bWorldSupport are set, then chunks must be tagged as
		/// "support" chunks AND overlap the Scene's static geometry in order to be environmentally supported.
		/// </summary>
		public bool bWorldSupport;
		/// <summary>
		/// Whether or not chunks at or deeper than the "debris" depth (see NxDestructibleParameters::debrisDepth)
		/// will time out.  The lifetime is a value between NxDestructibleParameters::debrisLifetimeMin and
		/// NxDestructibleParameters::debrisLifetimeMax, based upon the destructible module's LOD setting.
		/// </summary>
		public bool bDebrisTimeout;
		/// <summary>
		/// Whether or not chunks at or deeper than the "debris" depth (see NxDestructibleParameters::debrisDepth)
		/// will be removed if they separate too far from their origins.  The maxSeparation is a value between
		/// NxDestructibleParameters::debrisMaxSeparationMin and NxDestructibleParameters::debrisMaxSeparationMax,
		/// based upon the destructible module's LOD setting.
		/// </summary>
		public bool bDebrisMaxSeparation;
		/// <summary>
		/// If set, the smallest chunks may be further broken down, either by fluid crumbles (if a crumble particle
		/// system is specified in the NxDestructibleActorDesc), or by simply removing the chunk if no crumble
		/// particle system is specified.  Note: the "smallest chunks" are normally defined to be the deepest level
		/// of the fracture hierarchy.  However, they may be taken from higher levels of the hierarchy if
		/// NxModuleDestructible::setMaxChunkDepthOffset is called with a non-zero value.
		/// </summary>
		public bool bCrumbleSmallestChunks;
		/// <summary>
		/// If set, the NxDestructibleActor::rayCast function will search within the nearest visible chunk hit
		/// for collisions with child chunks.  This is used to get a better raycast position and normal, in
		/// case the parent collision volume does not tightly fit the graphics mesh.  The returned chunk index
		/// will always be that of the visible parent that is intersected, however.
		/// </summary>
		public bool bAccurateRaycasts;
		/// <summary>
		/// If set, the ValidBounds field of NxDestructibleParameters will be used.  These bounds are translated
		/// (but not scaled or rotated) to the origin of the destructible actor.  If a chunk or chunk island moves
		/// outside of those bounds, it is destroyed.
		/// </summary>
		public bool bUseValidBounds;
		/// <summary>
		/// If initially static, the destructible will become part of an extended support structure if it is
		/// in contact with another static destructible that also has this flag set.
		/// </summary>
		public bool bFormExtendedStructures;
		
	}
	
}
