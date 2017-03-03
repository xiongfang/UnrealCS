#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=120)]
	public partial struct FRuntimeFloatCurve
	{
		[FieldOffset(0)]
		public FRichCurve EditorCurveData;
		
	}
	
}
#endif
#endif
