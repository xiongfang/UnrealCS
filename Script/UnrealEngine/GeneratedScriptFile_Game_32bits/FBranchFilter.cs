#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FBranchFilter
	{
		[FieldOffset(0)]
		public FName BoneName;
		[FieldOffset(8)]
		public int BlendDepth;
		
	}
	
}
#endif
#endif
