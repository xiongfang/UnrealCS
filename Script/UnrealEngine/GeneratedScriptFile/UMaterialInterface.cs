using System;
namespace UnrealEngine
{
	public partial class UMaterialInterface:UObject
	{
		/// <summary>
		/// Return a pointer to the physical material used by this material instance.
		/// @return The physical material.
		/// </summary>
		public extern virtual UPhysicalMaterial GetPhysicalMaterial();
		/// <summary>Walks up parent chain and finds the base Material that this is an instance of. Just calls the virtual GetMaterial()</summary>
		public extern UMaterial GetBaseMaterial();
		/// <summary>SubsurfaceProfile, for Screen Space Subsurface Scattering</summary>
		public USubsurfaceProfile SubsurfaceProfile;
		
		/// <summary>The Lightmass settings for this object.</summary>
		public FLightmassMaterialInterfaceSettings LightmassSettings;
		
		/// <summary>Because of redirector, the texture names need to be resorted at each load in case they changed.</summary>
		public bool bTextureStreamingDataSorted;
		
		/// <summary>The mesh used by the material editor to preview the material.</summary>
		public FStringAssetReference PreviewMesh;
		
		/// <summary>Information for thumbnail rendering</summary>
		public UThumbnailInfo ThumbnailInfo;
		
		/// <summary>Unique ID for this material, used for caching during distributed lighting</summary>
		public FGuid LightingGuid;
		
		
	}
	
}
