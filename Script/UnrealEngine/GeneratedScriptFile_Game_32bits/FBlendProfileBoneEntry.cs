#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FBlendProfileBoneEntry
	{
		[FieldOffset(0)]
		public FBoneReference BoneReference;
		[FieldOffset(12)]
		public float BlendScale;
		
	}
	
}
#endif
#endif
