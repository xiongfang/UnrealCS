#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FVehicleInputRate
	{
		/// <summary>Rate at which the input value rises</summary>
		[FieldOffset(0)]
		public float RiseRate;
		/// <summary>Rate at which the input value falls</summary>
		[FieldOffset(4)]
		public float FallRate;
		
	}
	
}
#endif
#endif
