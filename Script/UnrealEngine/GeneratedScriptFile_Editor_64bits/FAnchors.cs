#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Describes how a widget is anchored.</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FAnchors
	{
		/// <summary>Holds the minimum anchors, left + top.</summary>
		[FieldOffset(0)]
		public FVector2D Minimum;
		/// <summary>Holds the maximum anchors, right + bottom.</summary>
		[FieldOffset(8)]
		public FVector2D Maximum;
		
	}
	
}
#endif
#endif
