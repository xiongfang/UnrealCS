using System;
namespace UnrealEngine
{
	public partial class USkeletalMesh:UObject
	{
		/// <summary>
		/// Checks whether the provided section is using APEX cloth. if bCheckCorrespondingSections is true
		/// disabled sections will defer to correspond sections to see if they use cloth (non-cloth sections
		/// are disabled and another section added when cloth is enabled, using this flag allows for a check
		/// on the original section to succeed)
		/// @param InSectionIndex Index to check
		/// @param bCheckCorrespondingSections Whether to check corresponding sections for disabled sections
		/// </summary>
		public extern bool IsSectionUsingCloth(int InSectionIndex,bool bCheckCorrespondingSections=true);
		/// <summary>Returns a socket by index. Max index is NumSockets(). The meshes sockets are accessed first, then the skeletons.</summary>
		public extern USkeletalMeshSocket GetSocketByIndex(int Index);
		/// <summary>Returns the number of sockets available. Both on this mesh and it's skeleton.</summary>
		public extern int NumSockets();
		/// <summary>
		/// Find a socket object in this SkeletalMesh by name.
		/// Entering NAME_None will return NULL. If there are multiple sockets with the same name, will return the first one.
		/// Also returns the index for the socket allowing for future fast access via GetSocketByIndex()
		/// </summary>
		public extern USkeletalMeshSocket FindSocketAndIndex(FName InSocketName,out int OutIndex);
		/// <summary>
		/// Find a socket object in this SkeletalMesh by name.
		/// Entering NAME_None will return NULL. If there are multiple sockets with the same name, will return the first one.
		/// </summary>
		public extern USkeletalMeshSocket FindSocket(FName InSocketName);
		/// <summary>Get the original imported bounds of the skel mesh</summary>
		public extern FBoxSphereBounds GetImportedBounds();
		/// <summary>Get the extended bounds of this mesh (imported bounds plus bounds extension)</summary>
		public extern FBoxSphereBounds GetBounds();
		/// <summary>Skeleton of this skeletal mesh *</summary>
		public USkeleton Skeleton;
		
		/// <summary>Original imported mesh bounds</summary>
		public FBoxSphereBounds ImportedBounds;
		
		/// <summary>Bounds extended by user values below</summary>
		public FBoxSphereBounds ExtendedBounds;
		
		/// <summary>
		/// Bound extension values in addition to imported bound in the positive direction of XYZ,
		///     positive value increases bound size and negative value decreases bound size.
		///     The final bound would be from [Imported Bound - Negative Bound] to [Imported Bound + Positive Bound].
		/// </summary>
		public FVector PositiveBoundsExtension;
		
		/// <summary>
		/// Bound extension values in addition to imported bound in the negative direction of XYZ,
		///     positive value increases bound size and negative value decreases bound size.
		///     The final bound would be from [Imported Bound - Negative Bound] to [Imported Bound + Positive Bound].
		/// </summary>
		public FVector NegativeBoundsExtension;
		
		public EAxis SkelMirrorAxis;
		
		public EAxis SkelMirrorFlipAxis;
		
		/// <summary>If true, use 32 bit UVs. If false, use 16 bit UVs to save memory</summary>
		public bool bUseFullPrecisionUVs;
		
		/// <summary>true if this mesh has ever been simplified with Simplygon.</summary>
		public bool bHasBeenSimplified;
		
		/// <summary>Whether or not the mesh has vertex colors</summary>
		public bool bHasVertexColors;
		
		/// <summary>Uses skinned data for collision data. Per poly collision cannot be used for simulation, in most cases you are better off using the physics asset</summary>
		public bool bEnablePerPolyCollision;
		
		/// <summary>Physics data for the per poly collision case. In 99% of cases you will not need this and are better off using simple ragdoll collision (physics asset)</summary>
		public UBodySetup BodySetup;
		
		/// <summary>
		/// Physics and collision information used for this USkeletalMesh, set up in PhAT.
		/// This is used for per-bone hit detection, accurate bounding box calculation and ragdoll physics for example.
		/// </summary>
		public UPhysicsAsset PhysicsAsset;
		
		/// <summary>
		/// Physics asset whose shapes will be used for shadowing when components have bCastCharacterCapsuleDirectShadow or bCastCharacterCapsuleIndirectShadow enabled.
		/// Only spheres and sphyl shapes in the physics asset can be supported.  The more shapes used, the higher the cost of the capsule shadows will be.
		/// </summary>
		public UPhysicsAsset ShadowPhysicsAsset;
		
		/// <summary>Importing data and options used for this mesh</summary>
		public UAssetImportData AssetImportData;
		
		/// <summary>Path to the resource used to construct this skeletal mesh</summary>
		public FString SourceFilePath;
		
		/// <summary>Date/Time-stamp of the file from the last import</summary>
		public FString SourceFileTimestamp;
		
		/// <summary>Information for thumbnail rendering</summary>
		public UThumbnailInfo ThumbnailInfo;
		
		/// <summary>Attached assets component for this mesh</summary>
		public FPreviewAssetAttachContainer PreviewAttachedAssetContainer;
		
		/// <summary>The section currently selected in the Editor. Used for highlighting</summary>
		public int SelectedEditorSection;
		
		/// <summary>The section currently selected for clothing. need to remember this index for reimporting cloth</summary>
		public int SelectedClothingSection;
		
		/// <summary>Height offset for the floor mesh in the editor</summary>
		public float FloorOffset;
		
		/// <summary>
		/// Animation Blueprint class to run as a post process for this mesh.
		/// This blueprint will be ran before physics, but after the main
		/// anim instance for any skeletal mesh component using this mesh.
		/// </summary>
		public TSubclassOf<UAnimInstance>  PostProcessAnimBlueprint;
		
		
	}
	
}
