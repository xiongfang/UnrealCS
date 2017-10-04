using System;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationBoneSocket:UParticleModuleLocationBase
	{
		/// <summary>
		/// Whether the module uses Bones or Sockets for locations.
		/// BONESOCKETSOURCE_Bones          - Use Bones as the source locations.
		/// BONESOCKETSOURCE_Sockets        - Use Sockets as the source locations.
		/// </summary>
		public ELocationBoneSocketSource SourceType;
		
		/// <summary>An offset to apply to each bone/socket</summary>
		public FVector UniversalOffset;
		
		/// <summary>
		/// The method by which to select the bone/socket to spawn at.
		/// SEL_Sequential                  - loop through the bone/socket array in order
		/// SEL_Random                              - randomly select a bone/socket from the array
		/// </summary>
		public ELocationBoneSocketSelectionMethod SelectionMethod;
		
		/// <summary>If true, update the particle locations each frame with that of the bone/socket</summary>
		public bool bUpdatePositionEachFrame;
		
		/// <summary>If true, rotate mesh emitter meshes to orient w/ the socket</summary>
		public bool bOrientMeshEmitters;
		
		/// <summary>If true, particles inherit the associated bone velocity when spawned</summary>
		public bool bInheritBoneVelocity;
		
		/// <summary>A scale on how much of the bone's velocity a particle will inherit.</summary>
		public float InheritVelocityScale;
		
		/// <summary>The parameter name of the skeletal mesh actor that supplies the SkelMeshComponent for in-game.</summary>
		public FName SkelMeshActorParamName;
		
		/// <summary>
		/// When we have no source locations and we need to track bone velocities due to bInheritBoneVelocity, we pre select a set of bones to use each frame. This property determines how big the list is.
		/// Too low and the randomness of selection may suffer, too high and memory will be wasted.
		/// </summary>
		public int NumPreSelectedIndices;
		
		/// <summary>The name of the skeletal mesh to use in the editor</summary>
		public USkeletalMesh EditorSkelMesh;
		
		
	}
	
}
