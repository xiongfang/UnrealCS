#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FPerBoneInterpolation
	{
		[FieldOffset(0)]
		public FBoneReference BoneReference;
		[FieldOffset(20)]
		public float InterpolationSpeedPerSec;
		
	}
	
}
#endif
#endif
