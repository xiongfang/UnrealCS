#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FSimpleMemberReference
	{
		[FieldOffset(8)]
		public FName MemberName;
		[FieldOffset(16)]
		public FGuid MemberGuid;
		
	}
	
}
#endif
#endif
