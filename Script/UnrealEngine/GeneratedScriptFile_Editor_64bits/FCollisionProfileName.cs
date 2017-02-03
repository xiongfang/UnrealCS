#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FCollisionProfileName
	{
		[FieldOffset(0)]
		public FName Name;
		
	}
	
}
#endif
#endif
