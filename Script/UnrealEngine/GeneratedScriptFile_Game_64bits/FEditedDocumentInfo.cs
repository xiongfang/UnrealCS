#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FEditedDocumentInfo
	{
		[FieldOffset(8)]
		public FVector2D SavedViewOffset;
		[FieldOffset(16)]
		public float SavedZoomAmount;
		
	}
	
}
#endif
#endif
