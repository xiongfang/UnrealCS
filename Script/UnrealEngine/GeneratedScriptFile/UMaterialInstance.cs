using System;
namespace UnrealEngine
{
	public partial class UMaterialInstance:UMaterialInterface
	{
		/// <summary>Physical material to use for this graphics material. Used for sounds, effects etc.</summary>
		public UPhysicalMaterial PhysMaterial;
		
		/// <summary>Parent material.</summary>
		public UMaterialInterface Parent;
		
		/// <summary>
		/// Indicates whether the instance has static permutation resources (which are required when static parameters are present)
		/// Read directly from the rendering thread, can only be modified with the use of a FMaterialUpdateContext.
		/// When true, StaticPermutationMaterialResources will always be valid and non-null.
		/// </summary>
		public bool bHasStaticPermutationResource;
		
		/// <summary>Defines if SubsurfaceProfile from this instance is used or it uses the parent one.</summary>
		public bool bOverrideSubsurfaceProfile;
		
		public bool bOverrideBaseProperties;
		
		public FMaterialInstanceBasePropertyOverrides BasePropertyOverrides;
		
		
	}
	
}
