#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=80)]
	public partial struct FFunctionExpressionInput
	{
		[FieldOffset(8)]
		public FGuid ExpressionInputId;
		[FieldOffset(24)]
		public FExpressionInput Input;
		
	}
	
}
#endif
#endif
