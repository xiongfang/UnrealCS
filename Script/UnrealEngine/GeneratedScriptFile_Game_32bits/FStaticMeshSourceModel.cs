#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=100)]
	public partial struct FStaticMeshSourceModel
	{
		[FieldOffset(0)]
		public FMeshBuildSettings BuildSettings;
		[FieldOffset(56)]
		public FMeshReductionSettings ReductionSettings;
		[FieldOffset(92)]
		public float LODDistance;
		[FieldOffset(96)]
		public float ScreenSize;
		
	}
	
}
#endif
#endif
