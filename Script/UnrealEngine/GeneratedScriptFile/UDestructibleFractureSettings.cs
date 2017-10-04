using System;
namespace UnrealEngine
{
	public partial class UDestructibleFractureSettings:UObject
	{
		/// <summary>The number of voronoi cell sites.</summary>
		public int CellSiteCount;
		
		/// <summary>Stored interior material data.  Just need one as we only support Voronoi splitting.</summary>
		public FFractureMaterial FractureMaterialDesc;
		
		/// <summary>Random seed for reproducibility</summary>
		public int RandomSeed;
		
		/// <summary>The mesh's original number of submeshes.  APEX needs to store this in the authoring.</summary>
		public int OriginalSubmeshCount;
		
		
	}
	
}
