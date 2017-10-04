using System;
namespace UnrealEngine
{
	/// <summary>Struct containing information for a particular LOD level, such as materials and info for when to use it.</summary>
	public partial struct FSkeletalMeshLODInfo
	{
		/// <summary>
		/// ScreenSize to display this LOD.
		/// The screen size is based around the projected diameter of the bounding
		/// sphere of the model. i.e. 0.5 means half the screen's maximum dimension.
		/// </summary>
		public float ScreenSize;
		/// <summary>Used to avoid 'flickering' when on LOD boundary. Only taken into account when moving from complex->simple.</summary>
		public float LODHysteresis;
		/// <summary>Whether to disable morph targets for this LOD.</summary>
		public bool bHasBeenSimplified;
		/// <summary>Reduction settings to apply when building render data.</summary>
		public FSkeletalMeshOptimizationSettings ReductionSettings;
		/// <summary>The filename of the file tha was used to import this LOD if it was not auto generated.</summary>
		public FString SourceImportFilename;
		
	}
	
}
