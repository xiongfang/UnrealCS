#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Describes the space around a Widget.</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FMargin
	{
		/// <summary>Holds the margin to the left.</summary>
		[FieldOffset(0)]
		public float Left;
		/// <summary>Holds the margin to the top.</summary>
		[FieldOffset(4)]
		public float Top;
		/// <summary>Holds the margin to the right.</summary>
		[FieldOffset(8)]
		public float Right;
		/// <summary>Holds the margin to the bottom.</summary>
		[FieldOffset(12)]
		public float Bottom;
		
	}
	
}
#endif
#endif
