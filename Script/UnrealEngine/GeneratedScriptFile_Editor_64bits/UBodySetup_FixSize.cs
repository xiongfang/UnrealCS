#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// BodySetup contains all collision information that is associated with a single asset.
	/// A single BodySetup instance is shared among many BodyInstances so that geometry data is not duplicated.
	/// Assets typically implement a GetBodySetup function that is used during physics state creation.
	/// @see GetBodySetup
	/// @see FBodyInstance
	/// </summary>
	public partial class UBodySetup
	{
		static readonly int AggGeom__Offset;
		/// <summary>Simplified collision representation of this</summary>
		public FKAggregateGeom AggGeom
		{
			get{ CheckIsValid();return (FKAggregateGeom)Marshal.PtrToStructure(_this.Get()+AggGeom__Offset, typeof(FKAggregateGeom));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AggGeom__Offset, false);}
			
		}
		
		static readonly int BoneName__Offset;
		/// <summary>Used in the PhysicsAsset case. Associates this Body with Bone in a skeletal mesh.</summary>
		public FName BoneName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+BoneName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BoneName__Offset, false);}
			
		}
		
		static readonly int PhysicsType__Offset;
		/// <summary>If Unfixed it will use physics. If fixed, it will use kinematic. Default will inherit from OwnerComponent's behavior.</summary>
		public EPhysicsType PhysicsType
		{
			get{ CheckIsValid();return (EPhysicsType)Marshal.PtrToStructure(_this.Get()+PhysicsType__Offset, typeof(EPhysicsType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PhysicsType__Offset, false);}
			
		}
		
		static readonly int bAlwaysFullAnimWeight__Offset;
		/// <summary>
		/// If true (and bEnableFullAnimWeightBodies in SkelMeshComp is true), the physics of this bone will always be blended into the skeletal mesh, regardless of what PhysicsWeight of the SkelMeshComp is.
		/// This is useful for bones that should always be physics, even when blending physics in and out for hit reactions (eg cloth or pony-tails).
		/// </summary>
		public bool bAlwaysFullAnimWeight
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAlwaysFullAnimWeight__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bConsiderForBounds__Offset;
		/// <summary>
		/// Should this BodySetup be considered for the bounding box of the PhysicsAsset (and hence SkeletalMeshComponent).
		/// There is a speed improvement from having less BodySetups processed each frame when updating the bounds.
		/// </summary>
		public bool bConsiderForBounds
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bConsiderForBounds__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bConsiderForBounds__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bMeshCollideAll__Offset;
		/// <summary>
		/// If true, the physics of this mesh (only affects static meshes) will always contain ALL elements from the mesh - not just the ones enabled for collision.
		/// This is useful for forcing high detail collisions using the entire render mesh.
		/// </summary>
		public bool bMeshCollideAll
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMeshCollideAll__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bDoubleSidedGeometry__Offset;
		/// <summary>
		/// If true, the physics triangle mesh will use double sided faces when doing scene queries.
		/// This is useful for planes and single sided meshes that need traces to work on both sides.
		/// </summary>
		public bool bDoubleSidedGeometry
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDoubleSidedGeometry__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDoubleSidedGeometry__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bGenerateNonMirroredCollision__Offset;
		/// <summary>Should we generate data necessary to support collision on normal (non-mirrored) versions of this body.</summary>
		public bool bGenerateNonMirroredCollision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGenerateNonMirroredCollision__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bSharedCookedData__Offset;
		/// <summary>Whether the cooked data is shared by multiple body setups. This is needed for per poly collision case where we don't want to duplicate cooked data, but still need multiple body setups for in place geometry changes</summary>
		public bool bSharedCookedData
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSharedCookedData__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bGenerateMirroredCollision__Offset;
		/// <summary>
		/// Should we generate data necessary to support collision on mirrored versions of this mesh.
		/// This halves the collision data size for this mesh, but disables collision on mirrored instances of the body.
		/// </summary>
		public bool bGenerateMirroredCollision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGenerateMirroredCollision__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int PhysMaterial__Offset;
		/// <summary>Physical material to use for simple collision on this body. Encodes information about density, friction etc.</summary>
		public UPhysicalMaterial PhysMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PhysMaterial__Offset); if (v == IntPtr.Zero)return null; UPhysicalMaterial retValue = new UPhysicalMaterial(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PhysMaterial__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PhysMaterial__Offset, value._this.Get()); }
			
		}
		
		static readonly int CollisionReponse__Offset;
		/// <summary>Collision Type for this body. This eventually changes response to collision to others *</summary>
		public EBodyCollisionResponse CollisionReponse
		{
			get{ CheckIsValid();return (EBodyCollisionResponse)Marshal.PtrToStructure(_this.Get()+CollisionReponse__Offset, typeof(EBodyCollisionResponse));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CollisionReponse__Offset, false);}
			
		}
		
		static readonly int CollisionTraceFlag__Offset;
		/// <summary>Collision Trace behavior - by default, it will keep simple(convex)/complex(per-poly) separate *</summary>
		public ECollisionTraceFlag CollisionTraceFlag
		{
			get{ CheckIsValid();return (ECollisionTraceFlag)Marshal.PtrToStructure(_this.Get()+CollisionTraceFlag__Offset, typeof(ECollisionTraceFlag));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CollisionTraceFlag__Offset, false);}
			
		}
		
		static readonly int DefaultInstance__Offset;
		/// <summary>Default properties of the body instance, copied into objects on instantiation, was URB_BodyInstance</summary>
		public FBodyInstance DefaultInstance
		{
			get{ CheckIsValid();return (FBodyInstance)Marshal.PtrToStructure(_this.Get()+DefaultInstance__Offset, typeof(FBodyInstance));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultInstance__Offset, false);}
			
		}
		
		static readonly int WalkableSlopeOverride__Offset;
		/// <summary>Custom walkable slope setting for this body.</summary>
		public FWalkableSlopeOverride WalkableSlopeOverride
		{
			get{ CheckIsValid();return (FWalkableSlopeOverride)Marshal.PtrToStructure(_this.Get()+WalkableSlopeOverride__Offset, typeof(FWalkableSlopeOverride));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WalkableSlopeOverride__Offset, false);}
			
		}
		
		static readonly int BuildScale__Offset;
		public float BuildScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BuildScale__Offset, typeof(float));}
			
		}
		
		static readonly int BuildScale3D__Offset;
		/// <summary>Build scale for this body setup (static mesh settings define this value)</summary>
		public FVector BuildScale3D
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+BuildScale3D__Offset, typeof(FVector));}
			
		}
		
		static UBodySetup()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BodySetup");
			AggGeom__Offset=GetPropertyOffset(NativeClassPtr,"AggGeom");
			BoneName__Offset=GetPropertyOffset(NativeClassPtr,"BoneName");
			PhysicsType__Offset=GetPropertyOffset(NativeClassPtr,"PhysicsType");
			bAlwaysFullAnimWeight__Offset=GetPropertyOffset(NativeClassPtr,"bAlwaysFullAnimWeight");
			bConsiderForBounds__Offset=GetPropertyOffset(NativeClassPtr,"bConsiderForBounds");
			bMeshCollideAll__Offset=GetPropertyOffset(NativeClassPtr,"bMeshCollideAll");
			bDoubleSidedGeometry__Offset=GetPropertyOffset(NativeClassPtr,"bDoubleSidedGeometry");
			bGenerateNonMirroredCollision__Offset=GetPropertyOffset(NativeClassPtr,"bGenerateNonMirroredCollision");
			bSharedCookedData__Offset=GetPropertyOffset(NativeClassPtr,"bSharedCookedData");
			bGenerateMirroredCollision__Offset=GetPropertyOffset(NativeClassPtr,"bGenerateMirroredCollision");
			PhysMaterial__Offset=GetPropertyOffset(NativeClassPtr,"PhysMaterial");
			CollisionReponse__Offset=GetPropertyOffset(NativeClassPtr,"CollisionReponse");
			CollisionTraceFlag__Offset=GetPropertyOffset(NativeClassPtr,"CollisionTraceFlag");
			DefaultInstance__Offset=GetPropertyOffset(NativeClassPtr,"DefaultInstance");
			WalkableSlopeOverride__Offset=GetPropertyOffset(NativeClassPtr,"WalkableSlopeOverride");
			BuildScale__Offset=GetPropertyOffset(NativeClassPtr,"BuildScale");
			BuildScale3D__Offset=GetPropertyOffset(NativeClassPtr,"BuildScale3D");
			
		}
		
	}
	
}
#endif
#endif
