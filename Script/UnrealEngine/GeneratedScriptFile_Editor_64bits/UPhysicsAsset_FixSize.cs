#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// PhysicsAsset contains a set of rigid bodies and constraints that make up a single ragdoll.
	/// The asset is not limited to human ragdolls, and can be used for any physical simulation using bodies and constraints.
	/// A SkeletalMesh has a single PhysicsAsset, which allows for easily turning ragdoll physics on or off for many SkeletalMeshComponents
	/// The asset can be configured inside the Physics Asset Editor (PhAT).
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Physics/PhAT/Reference/index.html
	/// @see USkeletalMesh
	/// </summary>
	public partial class UPhysicsAsset
	{
		static readonly int DefaultSkelMesh__Offset;
		/// <summary>
		/// Default skeletal mesh to use when previewing this PhysicsAsset etc.
		/// Is the one that was used as the basis for creating this Asset.
		/// </summary>
		public USkeletalMesh DefaultSkelMesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultSkelMesh__Offset); if (v == IntPtr.Zero)return null; USkeletalMesh retValue = new USkeletalMesh(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PhysicalAnimationProfiles__Offset;
		public TStructArray<FName> PhysicalAnimationProfiles
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PhysicalAnimationProfiles__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PhysicalAnimationProfiles__Offset, false);}
			
		}
		
		static readonly int ConstraintProfiles__Offset;
		public TStructArray<FName> ConstraintProfiles
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ConstraintProfiles__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ConstraintProfiles__Offset, false);}
			
		}
		
		static readonly int CurrentPhysicalAnimationProfileName__Offset;
		public FName CurrentPhysicalAnimationProfileName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+CurrentPhysicalAnimationProfileName__Offset, typeof(FName));}
			
		}
		
		static readonly int CurrentConstraintProfileName__Offset;
		public FName CurrentConstraintProfileName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+CurrentConstraintProfileName__Offset, typeof(FName));}
			
		}
		
		static readonly int BoundsBodies__Offset;
		/// <summary>Index of bodies that are marked bConsiderForBounds</summary>
		public TStructArray<int> BoundsBodies
		{
			get{ CheckIsValid();return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BoundsBodies__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BoundsBodies__Offset, false);}
			
		}
		
		static readonly int SkeletalBodySetups__Offset;
		/// <summary>
		/// Array of SkeletalBodySetup objects. Stores information about collision shape etc. for each body.
		/// Does not include body position - those are taken from mesh.
		/// </summary>
		public TObjectArray<USkeletalBodySetup>  SkeletalBodySetups
		{
					get{ CheckIsValid();return new TObjectArray<USkeletalBodySetup>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SkeletalBodySetups__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SkeletalBodySetups__Offset, false);}
			
		}
		
		static readonly int ConstraintSetup__Offset;
		/// <summary>
		/// Array of RB_ConstraintSetup objects.
		/// Stores information about a joint between two bodies, such as position relative to each body, joint limits etc.
		/// </summary>
		public TObjectArray<UPhysicsConstraintTemplate>  ConstraintSetup
		{
					get{ CheckIsValid();return new TObjectArray<UPhysicsConstraintTemplate>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ConstraintSetup__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ConstraintSetup__Offset, false);}
			
		}
		
		static readonly int bUseAsyncScene__Offset;
		/// <summary>If true, bodies of the physics asset will be put into the asynchronous physics scene. If false, they will be put into the synchronous physics scene.</summary>
		public bool bUseAsyncScene
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseAsyncScene__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseAsyncScene__Offset, 1,0,1,1);}
			
		}
		
		static readonly int BodySetup__Offset;
		public TObjectArray<UBodySetup>  BodySetup
		{
					get{ CheckIsValid();return new TObjectArray<UBodySetup>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BodySetup__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BodySetup__Offset, false);}
			
		}
		
		static UPhysicsAsset()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PhysicsAsset");
			DefaultSkelMesh__Offset=GetPropertyOffset(NativeClassPtr,"DefaultSkelMesh");
			PhysicalAnimationProfiles__Offset=GetPropertyOffset(NativeClassPtr,"PhysicalAnimationProfiles");
			ConstraintProfiles__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintProfiles");
			CurrentPhysicalAnimationProfileName__Offset=GetPropertyOffset(NativeClassPtr,"CurrentPhysicalAnimationProfileName");
			CurrentConstraintProfileName__Offset=GetPropertyOffset(NativeClassPtr,"CurrentConstraintProfileName");
			BoundsBodies__Offset=GetPropertyOffset(NativeClassPtr,"BoundsBodies");
			SkeletalBodySetups__Offset=GetPropertyOffset(NativeClassPtr,"SkeletalBodySetups");
			ConstraintSetup__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintSetup");
			bUseAsyncScene__Offset=GetPropertyOffset(NativeClassPtr,"bUseAsyncScene");
			BodySetup__Offset=GetPropertyOffset(NativeClassPtr,"BodySetup");
			
		}
		
	}
	
}
#endif
#endif
