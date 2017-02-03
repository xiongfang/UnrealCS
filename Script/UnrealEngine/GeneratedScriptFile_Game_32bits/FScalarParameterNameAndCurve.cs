#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=96)]
	public partial struct FScalarParameterNameAndCurve
	{
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(8)]
		public int Index;
		[FieldOffset(12)]
		public FRichCurve ParameterCurve;
		
	}
	
}
#endif
#endif
