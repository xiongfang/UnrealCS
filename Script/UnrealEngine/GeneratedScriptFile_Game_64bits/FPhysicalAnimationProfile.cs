#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FPhysicalAnimationProfile
	{
		[FieldOffset(0)]
		public FName ProfileName;
		[FieldOffset(8)]
		public FPhysicalAnimationData PhysicalAnimationData;
		
	}
	
}
#endif
#endif
