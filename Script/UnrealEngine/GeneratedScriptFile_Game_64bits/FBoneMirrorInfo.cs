#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FBoneMirrorInfo
	{
		[FieldOffset(0)]
		public int SourceIndex;
		[FieldOffset(4)]
		public EAxis BoneFlipAxis;
		
	}
	
}
#endif
#endif
