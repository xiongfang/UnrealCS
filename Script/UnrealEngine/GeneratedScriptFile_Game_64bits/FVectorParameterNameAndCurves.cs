#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=376)]
	public partial struct FVectorParameterNameAndCurves
	{
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(8)]
		public int Index;
		[FieldOffset(16)]
		public FRichCurve XCurve;
		[FieldOffset(136)]
		public FRichCurve YCurve;
		[FieldOffset(256)]
		public FRichCurve ZCurve;
		
	}
	
}
#endif
#endif
