#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Preview items that are attached to the skeleton *</summary>
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FPreviewAttachedObjectPair
	{
		/// <summary>The name of the attach point of the Object (for example a bone or socket name)</summary>
		[FieldOffset(40)]
		public FName AttachedTo;
		
	}
	
}
#endif
#endif
