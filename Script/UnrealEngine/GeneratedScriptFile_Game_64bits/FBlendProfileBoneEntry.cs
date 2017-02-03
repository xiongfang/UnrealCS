#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FBlendProfileBoneEntry
	{
		[FieldOffset(0)]
		public FBoneReference BoneReference;
		[FieldOffset(16)]
		public float BlendScale;
		
	}
	
}
#endif
#endif
