#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=52)]
	public partial struct FFunctionExpressionOutput
	{
		[FieldOffset(4)]
		public FGuid ExpressionOutputId;
		[FieldOffset(20)]
		public FExpressionOutput Output;
		
	}
	
}
#endif
#endif
