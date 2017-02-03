#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=92)]
	public partial struct FStaticMeshSourceModel
	{
		[FieldOffset(0)]
		public FMeshBuildSettings BuildSettings;
		[FieldOffset(52)]
		public FMeshReductionSettings ReductionSettings;
		[FieldOffset(84)]
		public float LODDistance;
		[FieldOffset(88)]
		public float ScreenSize;
		
	}
	
}
#endif
#endif
