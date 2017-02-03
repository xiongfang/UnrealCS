#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FVehicleGearData
	{
		[FieldOffset(0)]
		public float Ratio;
		[FieldOffset(4)]
		public float DownRatio;
		[FieldOffset(8)]
		public float UpRatio;
		
	}
	
}
#endif
#endif
