#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FWheelSetup
	{
		[FieldOffset(8)]
		public FName BoneName;
		[FieldOffset(16)]
		public FVector AdditionalOffset;
		
	}
	
}
#endif
#endif
