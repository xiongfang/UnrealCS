#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Flags that apply to a destructible actor.</summary>
	[StructLayout(LayoutKind.Explicit,Size=4)]
	public partial struct FDestructibleParametersFlag
	{
		/// <summary>
		/// If set, chunks will "remember" damage applied to them, so that many applications of a damage amount
		/// below damageThreshold will eventually fracture the chunk.  If not set, a single application of
		/// damage must exceed damageThreshold in order to fracture the chunk.
		/// </summary>
		public bool bAccumulateDamage
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 1); } }}
			
		}
		/// <summary>
		/// If set, then chunks which are tagged as "support" chunks (via NxDestructibleChunkDesc::isSupportChunk)
		/// will have environmental support in static destructibles.
		/// Note: if both bAssetDefinedSupport and bWorldSupport are set, then chunks must be tagged as
		/// "support" chunks AND overlap the Scene's static geometry in order to be environmentally supported.
		/// </summary>
		public bool bAssetDefinedSupport
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 2, 2); } }}
			
		}
		/// <summary>
		/// If set, then chunks which overlap the Scene's static geometry will have environmental support in
		/// static destructibles.
		/// Note: if both bAssetDefinedSupport and bWorldSupport are set, then chunks must be tagged as
		/// "support" chunks AND overlap the Scene's static geometry in order to be environmentally supported.
		/// </summary>
		public bool bWorldSupport
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 4, 4); } }}
			
		}
		/// <summary>
		/// Whether or not chunks at or deeper than the "debris" depth (see NxDestructibleParameters::debrisDepth)
		/// will time out.  The lifetime is a value between NxDestructibleParameters::debrisLifetimeMin and
		/// NxDestructibleParameters::debrisLifetimeMax, based upon the destructible module's LOD setting.
		/// </summary>
		public bool bDebrisTimeout
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 8, 8); } }}
			
		}
		/// <summary>
		/// Whether or not chunks at or deeper than the "debris" depth (see NxDestructibleParameters::debrisDepth)
		/// will be removed if they separate too far from their origins.  The maxSeparation is a value between
		/// NxDestructibleParameters::debrisMaxSeparationMin and NxDestructibleParameters::debrisMaxSeparationMax,
		/// based upon the destructible module's LOD setting.
		/// </summary>
		public bool bDebrisMaxSeparation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 16, 16); } }}
			
		}
		/// <summary>
		/// If set, the smallest chunks may be further broken down, either by fluid crumbles (if a crumble particle
		/// system is specified in the NxDestructibleActorDesc), or by simply removing the chunk if no crumble
		/// particle system is specified.  Note: the "smallest chunks" are normally defined to be the deepest level
		/// of the fracture hierarchy.  However, they may be taken from higher levels of the hierarchy if
		/// NxModuleDestructible::setMaxChunkDepthOffset is called with a non-zero value.
		/// </summary>
		public bool bCrumbleSmallestChunks
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 32, 32); } }}
			
		}
		/// <summary>
		/// If set, the NxDestructibleActor::rayCast function will search within the nearest visible chunk hit
		/// for collisions with child chunks.  This is used to get a better raycast position and normal, in
		/// case the parent collision volume does not tightly fit the graphics mesh.  The returned chunk index
		/// will always be that of the visible parent that is intersected, however.
		/// </summary>
		public bool bAccurateRaycasts
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 64, 64); } }}
			
		}
		/// <summary>
		/// If set, the ValidBounds field of NxDestructibleParameters will be used.  These bounds are translated
		/// (but not scaled or rotated) to the origin of the destructible actor.  If a chunk or chunk island moves
		/// outside of those bounds, it is destroyed.
		/// </summary>
		public bool bUseValidBounds
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 128, 128); } }}
			
		}
		/// <summary>
		/// If initially static, the destructible will become part of an extended support structure if it is
		/// in contact with another static destructible that also has this flag set.
		/// </summary>
		public bool bFormExtendedStructures
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 1, 1); } }}
			
		}
		
	}
	
}
#endif
#endif
