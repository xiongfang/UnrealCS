#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=72)]
	public partial struct FSkeletalMeshLODGroupSettings
	{
		[FieldOffset(0)]
		public float ScreenSize;
		[FieldOffset(8)]
		public FSkeletalMeshOptimizationSettings OptimizationSettings;
		
	}
	
}
#endif
#endif
