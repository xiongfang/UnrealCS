#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=52)]
	public partial struct FPhysicalAnimationProfile
	{
		/// <summary>Profile name used to identify set of physical animation parameters</summary>
		[FieldOffset(0)]
		public FName ProfileName;
		/// <summary>Physical animation parameters used to drive animation</summary>
		[FieldOffset(12)]
		public FPhysicalAnimationData PhysicalAnimationData;
		
	}
	
}
#endif
#endif
