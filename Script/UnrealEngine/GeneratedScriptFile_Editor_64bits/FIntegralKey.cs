#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>An integral key, which holds the key time and the key value</summary>
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FIntegralKey
	{
		/// <summary>The keyed time</summary>
		[FieldOffset(0)]
		public float Time;
		/// <summary>The keyed integral value</summary>
		[FieldOffset(4)]
		public int Value;
		
	}
	
}
#endif
#endif
