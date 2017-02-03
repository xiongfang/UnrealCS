#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Configurable properties for control axes.</summary>
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FInputAxisConfigEntry
	{
		/// <summary>Axis Key these properties apply to</summary>
		[FieldOffset(0)]
		public FName AxisKeyName;
		/// <summary>Properties for the Axis Key</summary>
		[FieldOffset(12)]
		public FInputAxisProperties AxisProperties;
		
	}
	
}
#endif
#endif
