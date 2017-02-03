#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FWheelSetup
	{
		[FieldOffset(4)]
		public FName BoneName;
		[FieldOffset(12)]
		public FVector AdditionalOffset;
		
	}
	
}
#endif
#endif
