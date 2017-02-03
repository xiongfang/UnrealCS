#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=72)]
	public partial struct FFunctionExpressionInput
	{
		[FieldOffset(4)]
		public FGuid ExpressionInputId;
		[FieldOffset(24)]
		public FExpressionInput Input;
		
	}
	
}
#endif
#endif
