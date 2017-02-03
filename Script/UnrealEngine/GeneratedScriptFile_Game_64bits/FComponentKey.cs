#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FComponentKey
	{
		[FieldOffset(8)]
		public FName SCSVariableName;
		[FieldOffset(16)]
		public FGuid AssociatedGuid;
		
	}
	
}
#endif
#endif
