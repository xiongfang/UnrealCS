#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FVirtualBone
	{
		[FieldOffset(0)]
		public FName SourceBoneName;
		[FieldOffset(8)]
		public FName TargetBoneName;
		[FieldOffset(16)]
		public FName VirtualBoneName;
		
	}
	
}
#endif
#endif
