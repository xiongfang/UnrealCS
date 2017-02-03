#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FAnchorData
	{
		/// <summary>Offset.</summary>
		[FieldOffset(0)]
		public FMargin Offsets;
		/// <summary>Anchors.</summary>
		[FieldOffset(16)]
		public FAnchors Anchors;
		/// <summary>
		/// Alignment is the pivot point of the widget.  Starting in the upper left at (0,0),
		/// ending in the lower right at (1,1).  Moving the alignment point allows you to move
		/// the origin of the widget.
		/// </summary>
		[FieldOffset(32)]
		public FVector2D Alignment;
		
	}
	
}
#endif
#endif
