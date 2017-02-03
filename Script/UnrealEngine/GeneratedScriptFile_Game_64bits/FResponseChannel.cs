#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FResponseChannel
	{
		[FieldOffset(0)]
		public FName Channel;
		[FieldOffset(8)]
		public ECollisionResponse Response;
		
	}
	
}
#endif
#endif
