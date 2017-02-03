#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FCustomInput
	{
		[FieldOffset(0)]
		public FString InputName;
		[FieldOffset(12)]
		public FExpressionInput Input;
		
	}
	
}
#endif
#endif
