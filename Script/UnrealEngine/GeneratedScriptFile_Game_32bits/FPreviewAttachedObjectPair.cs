#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FPreviewAttachedObjectPair
	{
		[FieldOffset(32)]
		public FName AttachedTo;
		
	}
	
}
#endif
#endif
