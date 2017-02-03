#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FEditedDocumentInfo
	{
		[FieldOffset(4)]
		public FVector2D SavedViewOffset;
		[FieldOffset(12)]
		public float SavedZoomAmount;
		
	}
	
}
#endif
#endif
