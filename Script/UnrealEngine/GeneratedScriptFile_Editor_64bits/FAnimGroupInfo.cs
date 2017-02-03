#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FAnimGroupInfo
	{
		[FieldOffset(0)]
		public FName Name;
		[FieldOffset(12)]
		public FLinearColor Color;
		
	}
	
}
#endif
#endif
