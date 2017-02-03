#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Defines FVector oscillation.</summary>
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FVOscillator
	{
		/// <summary>Oscillation in the X axis.</summary>
		[FieldOffset(0)]
		public FFOscillator X;
		/// <summary>Oscillation in the Y axis.</summary>
		[FieldOffset(12)]
		public FFOscillator Y;
		/// <summary>Oscillation in the Z axis.</summary>
		[FieldOffset(24)]
		public FFOscillator Z;
		
	}
	
}
#endif
#endif
