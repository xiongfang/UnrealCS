#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FSimpleMemberReference
	{
		[FieldOffset(4)]
		public FName MemberName;
		[FieldOffset(12)]
		public FGuid MemberGuid;
		
	}
	
}
#endif
#endif
