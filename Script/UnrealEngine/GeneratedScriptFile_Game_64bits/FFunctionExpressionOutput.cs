#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FFunctionExpressionOutput
	{
		[FieldOffset(8)]
		public FGuid ExpressionOutputId;
		[FieldOffset(24)]
		public FExpressionOutput Output;
		
	}
	
}
#endif
#endif
