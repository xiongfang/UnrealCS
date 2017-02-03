#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=72)]
	public partial struct FCustomInput
	{
		[FieldOffset(0)]
		public FString InputName;
		[FieldOffset(16)]
		public FExpressionInput Input;
		
	}
	
}
#endif
#endif
