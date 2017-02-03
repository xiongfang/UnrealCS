#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=348)]
	public partial struct FColorParameterNameAndCurves
	{
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(8)]
		public int Index;
		[FieldOffset(12)]
		public FRichCurve RedCurve;
		[FieldOffset(96)]
		public FRichCurve GreenCurve;
		[FieldOffset(180)]
		public FRichCurve BlueCurve;
		[FieldOffset(264)]
		public FRichCurve AlphaCurve;
		
	}
	
}
#endif
#endif
