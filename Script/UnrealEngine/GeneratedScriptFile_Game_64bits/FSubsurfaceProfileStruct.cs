#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FSubsurfaceProfileStruct
	{
		[FieldOffset(0)]
		public float ScatterRadius;
		[FieldOffset(4)]
		public FLinearColor SubsurfaceColor;
		[FieldOffset(20)]
		public FLinearColor FalloffColor;
		
	}
	
}
#endif
#endif
