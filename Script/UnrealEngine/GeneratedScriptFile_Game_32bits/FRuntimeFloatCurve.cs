#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=88)]
	public partial struct FRuntimeFloatCurve
	{
		[FieldOffset(0)]
		public FRichCurve EditorCurveData;
		
	}
	
}
#endif
#endif
