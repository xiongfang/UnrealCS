#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FConstrainComponentPropName
	{
		[FieldOffset(0)]
		public FName ComponentName;
		
	}
	
}
#endif
#endif
