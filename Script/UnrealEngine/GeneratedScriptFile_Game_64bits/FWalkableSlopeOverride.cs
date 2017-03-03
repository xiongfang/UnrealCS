#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FWalkableSlopeOverride
	{
		[FieldOffset(0)]
		public EWalkableSlopeBehavior WalkableSlopeBehavior;
		[FieldOffset(4)]
		public float WalkableSlopeAngle;
		
	}
	
}
#endif
#endif
