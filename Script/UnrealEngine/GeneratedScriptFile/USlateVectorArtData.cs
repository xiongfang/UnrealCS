using System;
namespace UnrealEngine
{
	public partial class USlateVectorArtData:UObject
	{
		/// <summary>The mesh data asset from which the vector art is sourced</summary>
		public UStaticMesh MeshAsset;
		
		/// <summary>The material which we are using, or the material from with the MIC was constructed.</summary>
		public UMaterialInterface SourceMaterial;
		
		/// <summary>@see GetMaterial()</summary>
		public UMaterialInterface Material;
		
		public FVector2D ExtentMin;
		
		public FVector2D ExtentMax;
		
		
	}
	
}
