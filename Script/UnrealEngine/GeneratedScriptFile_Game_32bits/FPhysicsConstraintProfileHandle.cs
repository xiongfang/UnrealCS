#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=268)]
	public partial struct FPhysicsConstraintProfileHandle
	{
		[FieldOffset(0)]
		public FConstraintProfileProperties ProfileProperties;
		[FieldOffset(260)]
		public FName ProfileName;
		
	}
	
}
#endif
#endif
