#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FFunctionExpressionInput
	{
		[FieldOffset(4)]
		public FGuid ExpressionInputId;
		[FieldOffset(20)]
		public FExpressionInput Input;
		
	}
	
}
#endif
#endif
