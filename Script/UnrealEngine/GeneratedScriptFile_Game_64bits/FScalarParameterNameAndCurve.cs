#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=128)]
	public partial struct FScalarParameterNameAndCurve
	{
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(8)]
		public int Index;
		[FieldOffset(16)]
		public FRichCurve ParameterCurve;
		
	}
	
}
#endif
#endif
