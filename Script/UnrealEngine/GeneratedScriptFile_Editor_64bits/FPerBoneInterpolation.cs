#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FPerBoneInterpolation
	{
		[FieldOffset(0)]
		public FBoneReference BoneReference;
		[FieldOffset(16)]
		public float InterpolationSpeedPerSec;
		
	}
	
}
#endif
#endif
