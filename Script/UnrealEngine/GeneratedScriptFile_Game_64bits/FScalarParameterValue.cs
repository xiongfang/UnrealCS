#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FScalarParameterValue
	{
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(8)]
		public float ParameterValue;
		[FieldOffset(12)]
		public FGuid ExpressionGUID;
		
	}
	
}
#endif
#endif
