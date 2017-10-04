using System;
namespace UnrealEngine
{
	public partial class UBodySetup:UObject
	{
		/// <summary>Simplified collision representation of this</summary>
		public FKAggregateGeom AggGeom;
		
		/// <summary>Used in the PhysicsAsset case. Associates this Body with Bone in a skeletal mesh.</summary>
		public FName BoneName;
		
		/// <summary>If Unfixed it will use physics. If fixed, it will use kinematic. Default will inherit from OwnerComponent's behavior.</summary>
		public EPhysicsType PhysicsType;
		
		/// <summary>
		/// If true (and bEnableFullAnimWeightBodies in SkelMeshComp is true), the physics of this bone will always be blended into the skeletal mesh, regardless of what PhysicsWeight of the SkelMeshComp is.
		/// This is useful for bones that should always be physics, even when blending physics in and out for hit reactions (eg cloth or pony-tails).
		/// </summary>
		public bool bAlwaysFullAnimWeight;
		
		/// <summary>
		/// Should this BodySetup be considered for the bounding box of the PhysicsAsset (and hence SkeletalMeshComponent).
		/// There is a speed improvement from having less BodySetups processed each frame when updating the bounds.
		/// </summary>
		public bool bConsiderForBounds;
		
		/// <summary>
		/// If true, the physics of this mesh (only affects static meshes) will always contain ALL elements from the mesh - not just the ones enabled for collision.
		/// This is useful for forcing high detail collisions using the entire render mesh.
		/// </summary>
		public bool bMeshCollideAll;
		
		/// <summary>
		/// If true, the physics triangle mesh will use double sided faces when doing scene queries.
		/// This is useful for planes and single sided meshes that need traces to work on both sides.
		/// </summary>
		public bool bDoubleSidedGeometry;
		
		/// <summary>Should we generate data necessary to support collision on normal (non-mirrored) versions of this body.</summary>
		public bool bGenerateNonMirroredCollision;
		
		/// <summary>Whether the cooked data is shared by multiple body setups. This is needed for per poly collision case where we don't want to duplicate cooked data, but still need multiple body setups for in place geometry changes</summary>
		public bool bSharedCookedData;
		
		/// <summary>
		/// Should we generate data necessary to support collision on mirrored versions of this mesh.
		/// This halves the collision data size for this mesh, but disables collision on mirrored instances of the body.
		/// </summary>
		public bool bGenerateMirroredCollision;
		
		/// <summary>Physical material to use for simple collision on this body. Encodes information about density, friction etc.</summary>
		public UPhysicalMaterial PhysMaterial;
		
		/// <summary>Collision Type for this body. This eventually changes response to collision to others *</summary>
		public EBodyCollisionResponse CollisionReponse;
		
		/// <summary>Collision Trace behavior - by default, it will keep simple(convex)/complex(per-poly) separate *</summary>
		public ECollisionTraceFlag CollisionTraceFlag;
		
		/// <summary>Default properties of the body instance, copied into objects on instantiation, was URB_BodyInstance</summary>
		public FBodyInstance DefaultInstance;
		
		/// <summary>Custom walkable slope setting for this body.</summary>
		public FWalkableSlopeOverride WalkableSlopeOverride;
		
		public float BuildScale;
		
		/// <summary>Build scale for this body setup (static mesh settings define this value)</summary>
		public FVector BuildScale3D;
		
		
	}
	
}
