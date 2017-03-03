#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A single entry for a blend scale within a profile, mapping a bone to a blendscale</summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FBlendProfileBoneEntry
	{
		[FieldOffset(0)]
		public FBoneReference BoneReference;
		[FieldOffset(20)]
		public float BlendScale;
		
	}
	
}
#endif
#endif
