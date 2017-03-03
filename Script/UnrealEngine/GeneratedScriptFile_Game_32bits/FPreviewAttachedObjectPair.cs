#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FPreviewAttachedObjectPair
	{
		[FieldOffset(28)]
		public FName AttachedTo;
		
	}
	
}
#endif
#endif
