#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FEdGraphPinReference
	{
		[FieldOffset(8)]
		public FGuid PinId;
		
	}
	
}
#endif
#endif
