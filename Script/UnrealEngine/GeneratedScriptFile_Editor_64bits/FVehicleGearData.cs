#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FVehicleGearData
	{
		/// <summary>Determines the amount of torque multiplication</summary>
		[FieldOffset(0)]
		public float Ratio;
		/// <summary>Value of engineRevs/maxEngineRevs that is low enough to gear down</summary>
		[FieldOffset(4)]
		public float DownRatio;
		/// <summary>Value of engineRevs/maxEngineRevs that is high enough to gear up</summary>
		[FieldOffset(8)]
		public float UpRatio;
		
	}
	
}
#endif
#endif
