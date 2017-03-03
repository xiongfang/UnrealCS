#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=112)]
	public partial struct FStaticMeshSourceModel
	{
		[FieldOffset(0)]
		public FMeshBuildSettings BuildSettings;
		[FieldOffset(64)]
		public FMeshReductionSettings ReductionSettings;
		[FieldOffset(100)]
		public float LODDistance;
		[FieldOffset(104)]
		public float ScreenSize;
		
	}
	
}
#endif
#endif
