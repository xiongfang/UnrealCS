#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FStructRedirect
	{
		[FieldOffset(0)]
		public FName OldStructName;
		[FieldOffset(12)]
		public FName NewStructName;
		
	}
	
}
#endif
#endif
