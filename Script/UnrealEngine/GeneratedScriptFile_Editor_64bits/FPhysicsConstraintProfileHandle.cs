#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=272)]
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
