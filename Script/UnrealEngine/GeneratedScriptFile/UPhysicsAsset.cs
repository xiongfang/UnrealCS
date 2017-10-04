using System;
namespace UnrealEngine
{
	public partial class UPhysicsAsset:UObject
	{
		/// <summary>
		/// Default skeletal mesh to use when previewing this PhysicsAsset etc.
		/// Is the one that was used as the basis for creating this Asset.
		/// </summary>
		public USkeletalMesh DefaultSkelMesh;
		
		public FName CurrentPhysicalAnimationProfileName;
		
		public FName CurrentConstraintProfileName;
		
		/// <summary>If true, bodies of the physics asset will be put into the asynchronous physics scene. If false, they will be put into the synchronous physics scene.</summary>
		public bool bUseAsyncScene;
		
		
	}
	
}
