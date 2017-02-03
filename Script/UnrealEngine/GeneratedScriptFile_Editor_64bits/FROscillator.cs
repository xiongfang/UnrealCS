#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Defines FRotator oscillation.</summary>
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FROscillator
	{
		/// <summary>Pitch oscillation.</summary>
		[FieldOffset(0)]
		public FFOscillator Pitch;
		/// <summary>Yaw oscillation.</summary>
		[FieldOffset(12)]
		public FFOscillator Yaw;
		/// <summary>Roll oscillation.</summary>
		[FieldOffset(24)]
		public FFOscillator Roll;
		
	}
	
}
#endif
#endif
