#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=464)]
	public partial struct FColorParameterNameAndCurves
	{
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(8)]
		public int Index;
		[FieldOffset(16)]
		public FRichCurve RedCurve;
		[FieldOffset(128)]
		public FRichCurve GreenCurve;
		[FieldOffset(240)]
		public FRichCurve BlueCurve;
		[FieldOffset(352)]
		public FRichCurve AlphaCurve;
		
	}
	
}
#endif
#endif
