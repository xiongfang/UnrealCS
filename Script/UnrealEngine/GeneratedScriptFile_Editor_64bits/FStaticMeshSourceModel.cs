#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Source model from which a renderable static mesh is built.</summary>
	[StructLayout(LayoutKind.Explicit,Size=120)]
	public partial struct FStaticMeshSourceModel
	{
		/// <summary>Settings applied when building the mesh.</summary>
		[FieldOffset(8)]
		public FMeshBuildSettings BuildSettings;
		/// <summary>Reduction settings to apply when building render data.</summary>
		[FieldOffset(72)]
		public FMeshReductionSettings ReductionSettings;
		[FieldOffset(108)]
		public float LODDistance;
		/// <summary>
		/// ScreenSize to display this LOD.
		/// The screen size is based around the projected diameter of the bounding
		/// sphere of the model. i.e. 0.5 means half the screen's maximum dimension.
		/// </summary>
		[FieldOffset(112)]
		public float ScreenSize;
		
	}
	
}
#endif
#endif
