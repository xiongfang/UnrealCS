#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Data about a single point in a projectile path trace.</summary>
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FPredictProjectilePathPointData
	{
		/// <summary>Location of this point</summary>
		[FieldOffset(0)]
		public FVector Location;
		/// <summary>Velocity at this point</summary>
		[FieldOffset(12)]
		public FVector Velocity;
		/// <summary>Elapsed time at this point from the start of the trace.</summary>
		[FieldOffset(24)]
		public float Time;
		
	}
	
}
#endif
#endif
