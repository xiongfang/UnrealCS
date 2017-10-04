using System;
namespace UnrealEngine
{
	/// <summary>Source model from which a renderable static mesh is built.</summary>
	public partial struct FStaticMeshSourceModel
	{
		/// <summary>Settings applied when building the mesh.</summary>
		public FMeshBuildSettings BuildSettings;
		/// <summary>Reduction settings to apply when building render data.</summary>
		public FMeshReductionSettings ReductionSettings;
		public float LODDistance;
		/// <summary>
		/// ScreenSize to display this LOD.
		/// The screen size is based around the projected diameter of the bounding
		/// sphere of the model. i.e. 0.5 means half the screen's maximum dimension.
		/// </summary>
		public float ScreenSize;
		
	}
	
}
