#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FSkeletalMeshLODGroupSettings
	{
		[FieldOffset(0)]
		public float ScreenSize;
		[FieldOffset(4)]
		public FSkeletalMeshOptimizationSettings OptimizationSettings;
		
	}
	
}
#endif
#endif
