#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FVirtualBone
	{
		[FieldOffset(0)]
		public FName SourceBoneName;
		[FieldOffset(12)]
		public FName TargetBoneName;
		[FieldOffset(24)]
		public FName VirtualBoneName;
		
	}
	
}
#endif
#endif
