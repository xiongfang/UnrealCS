#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=96)]
	public partial struct FStaticMeshSourceModel
	{
		[FieldOffset(0)]
		public FMeshBuildSettings BuildSettings;
		[FieldOffset(56)]
		public FMeshReductionSettings ReductionSettings;
		[FieldOffset(88)]
		public float LODDistance;
		[FieldOffset(92)]
		public float ScreenSize;
		
	}
	
}
#endif
#endif
