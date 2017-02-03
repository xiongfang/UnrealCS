#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FComponentKey
	{
		[FieldOffset(4)]
		public FName SCSVariableName;
		[FieldOffset(12)]
		public FGuid AssociatedGuid;
		
	}
	
}
#endif
#endif
