#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FEditedDocumentInfo
	{
		/// <summary>Saved view position</summary>
		[FieldOffset(8)]
		public FVector2D SavedViewOffset;
		/// <summary>Saved zoom amount</summary>
		[FieldOffset(16)]
		public float SavedZoomAmount;
		
	}
	
}
#endif
#endif
