#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=264)]
	public partial struct FVectorParameterNameAndCurves
	{
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(8)]
		public int Index;
		[FieldOffset(12)]
		public FRichCurve XCurve;
		[FieldOffset(96)]
		public FRichCurve YCurve;
		[FieldOffset(180)]
		public FRichCurve ZCurve;
		
	}
	
}
#endif
#endif
