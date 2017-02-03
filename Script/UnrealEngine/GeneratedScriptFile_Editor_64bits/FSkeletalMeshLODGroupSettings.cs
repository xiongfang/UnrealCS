#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=72)]
	public partial struct FSkeletalMeshLODGroupSettings
	{
		/// <summary>The screen sizes to use for the respective LOD level</summary>
		[FieldOffset(0)]
		public float ScreenSize;
		/// <summary>The optimization settings to use for the respective LOD level</summary>
		[FieldOffset(8)]
		public FSkeletalMeshOptimizationSettings OptimizationSettings;
		
	}
	
}
#endif
#endif
