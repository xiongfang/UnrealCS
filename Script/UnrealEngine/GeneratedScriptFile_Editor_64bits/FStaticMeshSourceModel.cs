#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Source model from which a renderable static mesh is built.</summary>
	[StructLayout(LayoutKind.Explicit,Size=104)]
	public partial struct FStaticMeshSourceModel
	{
		/// <summary>Settings applied when building the mesh.</summary>
		[FieldOffset(8)]
		public FMeshBuildSettings BuildSettings;
		/// <summary>Reduction settings to apply when building render data.</summary>
		[FieldOffset(64)]
		public FMeshReductionSettings ReductionSettings;
		[FieldOffset(96)]
		public float LODDistance;
		/// <summary>ScreenSize to display this LOD</summary>
		[FieldOffset(100)]
		public float ScreenSize;
		
	}
	
}
#endif
#endif
